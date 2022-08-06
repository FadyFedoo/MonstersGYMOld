using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using MonstersGYM.Core.Interface;
using MonstersGYM.Infrastructure.Repository;
using MonstersGYM.Core.PocoClasses;
using System.IO;

namespace MonstersGYM
{
    public partial class NewMemberProfileUserControl : UserControl
    {
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
        IPromotion Promotion = new PromotionRepo();

        List<WelcomeProfileReport> welcomeProfiles;
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        int previousPrice = 0;
        List<Promotions> promotions;

        public NewMemberProfileUserControl()
        {
            InitializeComponent();
        }

        private void NewMemberProfileUserControl_Load(object sender, EventArgs e)
        {

            //fillWelcomeProfile();
            fillCameraComboox();

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("0.5");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("6");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("12");
        }
        public void LoadAllActivePromo(int CardHeaderID,decimal Duration)
        {
            PromotionComboBox.Items.Clear();
            string errorMsg = "";
            promotions = Promotion.GetAllActivePromotionByID(CardHeaderID.ToString(),Duration.ToString(), out errorMsg);
            if(!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (promotions.Count > 0)
            {
                PromotionComboBox.Enabled = true;
                foreach (var promo in promotions)
                {
                    PromotionComboBox.Items.Add(promo.Name);
                }
            }
            else
                PromotionComboBox.Enabled = false;

        }
        void fillCameraComboox()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboBox1.Items.Add(device.Name);
        }
        public void fillWelcomeProfile()
        {
            string errorMsg = "";
            List<GeneralWelcomeProfileReport> general;
            welcomeProfiles = WelcomeProfile.LoadVisitsLogsReport(-1, DateTime.MinValue, DateTime.MinValue, out general, out errorMsg);
            foreach (var profile in welcomeProfiles)
            {
                if (!coll.Contains(profile.MemberName))
                    coll.Add(profile.MemberName);
            }
            NameTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NameTextBox.AutoCompleteCustomSource = coll;
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipY);
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }
        private void TakePhotobutton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("من فضلك قم بالتأكد من توصيل الكاميرا جيدا , ثم قم بضغط زر التحديث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!OpenCamera)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

                videoCaptureDevice.Start();
                OpenCamera = true;
                TakePhotobutton.Text = "التقط صورة";
                TakePhotobutton.Image = global::MonstersGYM.Properties.Resources.Capture;
            }
            else
            {
                if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    OpenCamera = false;
                    TakePhotobutton.Text = "أفتح الكاميرا";
                    TakePhotobutton.Image = global::MonstersGYM.Properties.Resources.OpenCamera;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > StartDateTimePicker.Value)
            {
                MessageBox.Show("إختر تاريخ يبدأ من تاريخ اليوم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("إختر مدة أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorMsg = "";
            int TotalPrice = 0;
            int cardHeaderId = Card.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
            TotalPrice = CardDetails.GetPrice(cardHeaderId, decimal.Parse(comboBox2.SelectedItem.ToString()), out errorMsg);

            int originalAmount;
            int amount = originalAmount = TotalPrice;
            long PromoId = -1;
            if (PromotionComboBox.SelectedItem != null)
            {
                var promoName = PromotionComboBox.SelectedItem.ToString().Trim();
                var selectedPromo = promotions.FirstOrDefault(x => x.Name == promoName);
                var value = selectedPromo.Value;
                PromoId = selectedPromo.Id;
                int discount = (amount * value / 100);
                amount = amount - discount;
            }

            amount += CardDefinition.GetCardPrice(cardHeaderId, out errorMsg); // apply promotion on memberShip amount only

            if (originalAmount <= 0 || amount < 0 )
            {
                MessageBox.Show("لا يمكن الحفظ , السعر أقل من 0", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool exist = MemberProfile.IsExist(NameTextBox.Text.Trim(), out errorMsg);
            long CardDetailsId = CardDetails.GetCardDetailesID(cardHeaderId, decimal.Parse(comboBox2.SelectedItem.ToString()), out errorMsg);
            long cardId = Card.GetCardId(ScannedBarcodeTextBox.Text, out errorMsg);
            bool Used = RegistedCards.IsCardCurrentActive(cardId, StartDateTimePicker.Value, out errorMsg);
            bool isregistedBefore = Card.IsCardOut(ScannedBarcodeTextBox.Text, out errorMsg);

            if (!exist && !Used && !isregistedBefore)
            {
                var result = MessageBox.Show("السعر= "+ amount.ToString() + ", هل تريد الأستمرار؟", "تأكيد", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                    return;

                byte[] picture = null;
                if (pictureBox1.Image != null)
                    picture = ImageToByte2(pictureBox1.Image);
                else
                {
                    var bmp = new Bitmap(MonstersGYM.Properties.Resources.Logo);
                    picture = ImageToByte2(bmp);
                }

                bool success = false;
                long memberId = -1;

                success = MemberProfile.InsertNewMember(NameTextBox.Text.Trim(), AddressTextBox.Text, PhoneTextBox.Text, HeightNumericUpDown.Value, WeightNumericUpDown.Value
                    , BirthDateTimePicker.Value, picture, out errorMsg);
                memberId = MemberProfile.GetMemberId(NameTextBox.Text.Trim(), out errorMsg);

                int cardHeaderID = Cards.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
                long cardDetails = CardDetails.GetCardDetailesID(cardHeaderID, decimal.Parse(comboBox2.SelectedItem.ToString()), out errorMsg);
                int totalFreez = CardDetails.GetTotalFreez(cardDetails, out errorMsg);
                int totalInvitation = CardDetails.GetTotalInvitation(cardDetails, out errorMsg);
                int totalPersonal = CardDetails.GetTotalPersonal(cardDetails, out errorMsg);
                int totalClasses = CardDetails.GetTotalClasses(cardDetails, out errorMsg);
                DateTime endDate = StartDateTimePicker.Value;
                if (comboBox2.SelectedItem.ToString() == "0.5")
                    endDate = endDate.AddDays(15);
                else
                    endDate = endDate.AddMonths(int.Parse(comboBox2.SelectedItem.ToString()));

                success = RegistedCards.InsertNewRegisteredCard(memberId, cardId, CardDetailsId, 0, 0, 0,0, totalFreez, totalPersonal, totalInvitation, totalClasses,
                    StartDateTimePicker.Value, endDate, out errorMsg);
                success = Income.InsertNewIncome(memberId, User.CurrentUser.ID, cardId, decimal.Parse(comboBox2.SelectedItem.ToString()), amount,originalAmount,
                    PromoId, out errorMsg);
                success = Card.RegisterCard(ScannedBarcodeTextBox.Text, out errorMsg);

                if (success)
                {
                    NameTextBox.Text = AddressTextBox.Text = PhoneTextBox.Text = "";
                    HeightNumericUpDown.Value = 150;
                    WeightNumericUpDown.Value = 50;
                    BirthDateTimePicker.Value = DateTime.Now;
                    pictureBox1.Image = null;
                    PromotionComboBox.Items.Clear();
                    MessageBox.Show("تم الاشتراك بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (isregistedBefore)
                MessageBox.Show("تم مسح كارت مسجل من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (exist)
                MessageBox.Show("يوجد عميل بنفس الأسم , قم بتجديد الاشتراك بدل من تسجيل عضو جديد أو قم بإضافة أسم شهرة للعميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Used)
                MessageBox.Show("هذا الكارت مستخدم من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ScannedBarcodeTextBox.Text = "";
        }
        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string errorMsg = "";
                //TotalPrice -= previousPrice;
                decimal selectedMonths = decimal.Parse(comboBox2.SelectedItem.ToString());
                int cardHeaderId = Card.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
                //previousPrice = CardDetails.GetPrice(cardHeaderId, selectedMonths, out errorMsg);
                //TotalPrice += previousPrice;

                LoadAllActivePromo(cardHeaderId, selectedMonths);
            }
        }

        private void ScannedBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            //string errorMsg = "";
            //TotalPrice = 0;
            //int cardHeaderId = Card.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
            //TotalPrice = CardDefinition.GetCardPrice(cardHeaderId, out errorMsg);
            //previousPrice = 0;
            //comboBox2.SelectedItem = null;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            var profile = welcomeProfiles.FirstOrDefault(x => x.MemberName == NameTextBox.Text.Trim());
            if (profile != null)
            {
                PhoneTextBox.Text = profile.Phone;
                AddressTextBox.Text = profile.Address;
            }
            else
            {
                PhoneTextBox.Text = "";
                AddressTextBox.Text = "";
            }
        }

        private void ZoominButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = (int)(pictureBox1.Top - (pictureBox1.Height * 0.025));
            pictureBox1.Left = (int)(pictureBox1.Left - (pictureBox1.Width * 0.025));
            pictureBox1.Height = (int)(pictureBox1.Height + (pictureBox1.Height * 0.05));
            pictureBox1.Width = (int)(pictureBox1.Width + (pictureBox1.Width * 0.05));
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = (int)(pictureBox1.Top + (pictureBox1.Height * 0.025));
            pictureBox1.Left = (int)(pictureBox1.Left + (pictureBox1.Width * 0.025));
            pictureBox1.Height = (int)(pictureBox1.Height - (pictureBox1.Height * 0.05));
            pictureBox1.Width = (int)(pictureBox1.Width - (pictureBox1.Width * 0.05));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillCameraComboox();
        }
    }
}
