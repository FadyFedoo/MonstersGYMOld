using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MonstersGYM.Core.Interface;
using MonstersGYM.Infrastructure.Repository;
using AForge.Video.DirectShow;

namespace MonstersGYM
{
    public partial class MemberInfoUserControl : UserControl
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        ICards Cards = new CardsRepo();
        IMemberProfile MemberProfile = new MemberProfileRepo();
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        IMemberSignIn MemberSignIn = new MemberSignInRepo();
        bool edit = false;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        bool OpenCamera = false;

        public MemberInfoUserControl()
        {
            InitializeComponent();
            EditMemberProfile();
            fillCameraComboox();
        }
        void EditMemberProfile()
        {
            if (!edit)
            {
                NameTextBox.Enabled = false;
                AddressEditText.Enabled = false;
                PhoneEditText.Enabled = false;
                BirthDateTimePicker.Enabled = false;
                HeightNumericUpDown.Enabled = false;
                WeightNumericUpDown.Enabled = false;
                CancelButton.Enabled = false;
                SaveButton.Enabled = false;
                TakePhotobutton.Enabled = false;
                comboBox1.Enabled = false;
                EditButton.Enabled = true;
            }
            else
            {
                NameTextBox.Enabled = true;
                AddressEditText.Enabled = true;
                PhoneEditText.Enabled = true;
                BirthDateTimePicker.Enabled = true;
                HeightNumericUpDown.Enabled = true;
                WeightNumericUpDown.Enabled = true;
                CancelButton.Enabled = true;
                SaveButton.Enabled = true;
                TakePhotobutton.Enabled = true;
                comboBox1.Enabled = true;
                EditButton.Enabled = false;
            }
        }
        private void ScannedBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ScannedBarcodeTextBox.Text))
            {
                string errorMsg = "";

                var memberInfo = MemberProfile.GetMemberInfo(ScannedBarcodeTextBox.Text, out errorMsg);

                NameTextBox.Text = memberInfo.Name;
                AddressEditText.Text = memberInfo.Address;
                PhoneEditText.Text = memberInfo.Phone;
                BirthDateTimePicker.Value = memberInfo.BirthDate == DateTime.MinValue ? DateTime.Now : memberInfo.BirthDate;
                HeightNumericUpDown.Value = memberInfo.Height == 0 ? HeightNumericUpDown.Minimum : memberInfo.Height;
                WeightNumericUpDown.Value = memberInfo.Weight == 0 ? WeightNumericUpDown.Minimum : memberInfo.Weight;



                var memberId = MemberProfile.GetMemberId(ScannedBarcodeTextBox.Text, out errorMsg);
                byte[] pic = MemberProfile.GetMemberProfile(ScannedBarcodeTextBox.Text, out errorMsg);
                loadPicture(pic);
                long registeredCardID = RegisteredCard.GetLastCardID(memberId, out errorMsg);

                int cardHeaderId = Cards.getCardHeaderID(registeredCardID, out errorMsg);
                CardTypeLabel.Text = CardDefinition.GetCardName(cardHeaderId, out errorMsg).Trim();

                DateTime startDate = RegisteredCard.GetLastStartDate(memberId, out errorMsg);
                StartFromLabel.Text = startDate.ToShortDateString();

                DateTime endDate = RegisteredCard.GetLastEndDate(memberId, out errorMsg);
                
                int takenFreez = RegisteredCard.GetLastOldFreez(memberId, out errorMsg);
                int remainingDays = (endDate - DateTime.Now.Date).Days + takenFreez;

                if (remainingDays < 0)
                    remainingDays = 0;

                RemainingDaysLabel.Text = remainingDays.ToString() + " يوم";

                if (endDate != DateTime.MinValue)
                    endDate = endDate.AddDays(-1);

                EndDateLabel.Text = endDate.ToShortDateString();

                int totalAttendance = MemberSignIn.GetTottalAttendance(memberId, registeredCardID, out errorMsg);

                AttendanceLabel.Text = totalAttendance.ToString();

                int totalFreez = RegisteredCard.GetLastTotalFreez(memberId, out errorMsg);
                int availableFreez = totalFreez - takenFreez;
                RemainingFreezLabel.Text = availableFreez.ToString();

                int TotalPersonal = RegisteredCard.GetLastTotalPersonal(memberId, out errorMsg);
                int takenPersonal = RegisteredCard.GetLastOldPersonal(memberId, out errorMsg);
                RemainningPTLabel.Text = (TotalPersonal - takenPersonal).ToString();

                int totalInvitation = RegisteredCard.GetLastTotalInvitation(memberId, out errorMsg);
                int takenInvitation = RegisteredCard.GetLastOldInvitation(memberId, out errorMsg);
                RemainingInvitationLabel.Text = (totalInvitation - takenInvitation).ToString();
            }
        }
        void loadPicture(byte[] PicFromDb)
        {
            if (PicFromDb != null)
            {
                MemoryStream mem = new MemoryStream(PicFromDb);
                pictureBox1.Image = Image.FromStream(mem);
            }
            else
                pictureBox1.Image = null;
        }

        private void MemberInfoUserControl_Load(object sender, EventArgs e)
        {
            LoadAllMembers();
        }
        public void LoadAllMembers()
        {
            string errorMsg = "";
            coll.Clear();
            List<string> Names = MemberProfile.GetAllMembersNames(out errorMsg);
            foreach (var name in Names)
            {
                if (!coll.Contains(name))
                    coll.Add(name);
            }
            ScannedBarcodeTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ScannedBarcodeTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ScannedBarcodeTextBox.AutoCompleteCustomSource = coll;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ScannedBarcodeTextBox.Text))
                return;
            edit = !edit;
            EditMemberProfile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillCameraComboox();
        }
        void fillCameraComboox()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboBox1.Items.Add(device.Name);
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            edit = !edit;
            EditMemberProfile();
            ScannedBarcodeTextBox_TextChanged(null, null);
            if(OpenCamera)
                TakePhotobutton_Click(null, null);
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
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipY);
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            byte[] picture = null;
            if (pictureBox1.Image != null)
                picture = ImageToByte2(pictureBox1.Image);
            else
            {
                var bmp = new Bitmap(MonstersGYM.Properties.Resources.Logo);
                picture = ImageToByte2(bmp);
            }
            bool exist = MemberProfile.IsExist(NameTextBox.Text.Trim(), out errorMsg);
            if (!exist || ScannedBarcodeTextBox.Text == NameTextBox.Text)
            {
                var memberId = MemberProfile.GetMemberId(ScannedBarcodeTextBox.Text, out errorMsg);

                bool success = MemberProfile.EditMemberProfile(memberId, NameTextBox.Text, AddressEditText.Text, PhoneEditText.Text, HeightNumericUpDown.Value, WeightNumericUpDown.Value
                    , BirthDateTimePicker.Value, picture, out errorMsg);
                if (success)
                {
                    LoadAllMembers();
                    ScannedBarcodeTextBox.Text = NameTextBox.Text;
                    edit = !edit;
                    EditMemberProfile();
                    if(OpenCamera)
                        TakePhotobutton_Click(null, null);
                    MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("يوجد عميل بنفس الأسم , قم بإضافة أسم شهرة للعميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
