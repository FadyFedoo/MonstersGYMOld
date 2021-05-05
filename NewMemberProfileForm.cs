using AForge.Video.DirectShow;
using MonstersGYM.Core.Interface;
using MonstersGYM.Core.PocoClasses;
using MonstersGYM.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MonstersGYM
{
    public partial class NewMemberProfileForm : Form
    {
        ReceptionistOptionsForm ReceptionistOptionsForm;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        bool OpenCamera = false;
        IMemberProfile MemberProfile = new MemberProfileRepo();
        ICards Card = new CardsRepo();
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        ICardDetails CardDetails = new CardDetailsRepo();
        IRegisteredCard RegistedCards = new RegisteredCardRepo();
        IIncome Income = new IncomeRepo();
        IWelcomeProfile WelcomeProfile = new WelcomeProfileRepo();
        ICards Cards = new CardsRepo();

        List<WelcomeProfileReport> welcomeProfiles;
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        int TotalPrice = 0;
        int previousPrice = 0;
        public NewMemberProfileForm(ReceptionistOptionsForm ReceptionistOptionsForm)
        {
            InitializeComponent();
            this.ReceptionistOptionsForm = ReceptionistOptionsForm;
        }

        private void NewMemberProfileForm_Load(object sender, EventArgs e)
        {
            string errorMsg = "";
            List<GeneralWelcomeProfileReport> general = new List<GeneralWelcomeProfileReport>();
            welcomeProfiles = WelcomeProfile.LoadVisitsLogsReport(-1, DateTime.MinValue, DateTime.MinValue, out general, out errorMsg);
            foreach (var profile in welcomeProfiles)
            {
                coll.Add(profile.MemberName);
            }
            NameTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NameTextBox.AutoCompleteCustomSource = coll;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("6");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("12");

        }

        private void TakePhotobutton_Click(object sender, EventArgs e)
        {
            if (!OpenCamera)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                OpenCamera = true;
                TakePhotobutton.Text = "التقط صورة";
            }
            else
            {
                if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    OpenCamera = false;
                    TakePhotobutton.Text = "أفتح الكاميرا";
                }
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > StartDateTimePicker.Value)
            {
                MessageBox.Show("select valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TotalPrice <= 0)
            {
                MessageBox.Show("Can't save with value <= 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("select duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string errorMsg = "";
            bool exist = MemberProfile.IsExist(NameTextBox.Text, out errorMsg);
            int cardHeaderId = Card.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
            long CardDetailsId = CardDetails.GetCardDetailesID(cardHeaderId, int.Parse(comboBox2.SelectedItem.ToString()), out errorMsg);
            long cardId = Card.GetCardId(ScannedBarcodeTextBox.Text, out errorMsg);
            bool Used = RegistedCards.IsCardCurrentActive(cardId, StartDateTimePicker.Value, out errorMsg);
            bool isregistedBefore = Card.IsCardOut(ScannedBarcodeTextBox.Text, out errorMsg);

            if (!exist && !Used && !isregistedBefore)
            {
                if (pictureBox1.Image != null )
                {
                    byte[] picture = null;
                    if(pictureBox1.Image != null)
                        picture = ImageToByte2(pictureBox1.Image);

                    bool success = false;
                    long memberId = -1;

                    success = MemberProfile.InsertNewMember(NameTextBox.Text, AddressTextBox.Text, PhoneTextBox.Text, HeightNumericUpDown.Value, WeightNumericUpDown.Value, BirthDateTimePicker.Value, picture, out errorMsg);
                    memberId = MemberProfile.GetMemberId(NameTextBox.Text, out errorMsg);

                    int cardHeaderID = Cards.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
                    long cardDetails = CardDetails.GetCardDetailesID(cardHeaderID, int.Parse(comboBox1.SelectedItem.ToString()), out errorMsg);
                    int totalFreez = CardDetails.GetTotalFreez(cardDetails, out errorMsg);
                    int totalInvitation = CardDetails.GetTotalInvitation(cardDetails, out errorMsg);
                    int totalPersonal = CardDetails.GetTotalPersonal(cardDetails, out errorMsg);


                    success = RegistedCards.InsertNewRegisteredCard(memberId, cardId, CardDetailsId,0,0,0, totalFreez, totalPersonal, totalInvitation,
                        StartDateTimePicker.Value, StartDateTimePicker.Value.AddMonths(int.Parse(comboBox2.SelectedItem.ToString())), out errorMsg);
                    success = Card.RegisterCard(ScannedBarcodeTextBox.Text, out errorMsg);
                    success = Income.InsertNewIncome(memberId, User.CurrentUser.ID, cardId, int.Parse(comboBox2.SelectedItem.ToString()), TotalPrice, out errorMsg);

                    if (success)
                    {
                        NameTextBox.Text = AddressTextBox.Text = PhoneTextBox.Text = "";
                        HeightNumericUpDown.Value = 150;
                        WeightNumericUpDown.Value = 50;
                        BirthDateTimePicker.Value = DateTime.Now;
                        pictureBox1.Image = null;
                        MessageBox.Show("Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Take a photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(isregistedBefore)
                MessageBox.Show("Card registed before", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (exist)
                MessageBox.Show("exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(Used)
                MessageBox.Show("used in this range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string errorMsg = "";
                TotalPrice -= previousPrice;
                int selectedMonths = int.Parse(comboBox2.SelectedItem.ToString());
                int cardHeaderId = Card.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
                previousPrice = CardDetails.GetPrice(cardHeaderId, selectedMonths, out errorMsg);
                TotalPrice += previousPrice;
                textBox8.Text = TotalPrice.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string errorMsg = "";
            TotalPrice = 0;
            int cardHeaderId = Card.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
            TotalPrice = CardDefinition.GetCardPrice(cardHeaderId, out errorMsg);
            previousPrice = 0;
            comboBox2.SelectedItem = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceptionistOptionsForm.Show();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            var profile = welcomeProfiles.FirstOrDefault(x => x.MemberName == NameTextBox.Text);
            if (profile != null)
            {
                PhoneTextBox.Text = profile.Phone;
                AddressTextBox.Text = profile.Address;
            }
        }
    }
}
