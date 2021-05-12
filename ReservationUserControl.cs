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

namespace MonstersGYM
{
    public partial class ReservationUserControl : UserControl
    {
        IMemberProfile MemberProfile = new MemberProfileRepo();
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        ICardDetails CardDetailes = new CardDetailsRepo();
        IWelcomeProfile WelcomeProfile = new WelcomeProfileRepo();
        ITrainers Trainers = new TrainersRepo();
        ITakenPT TakenPT = new TakenPTRepo();
        ITakenFreez TakenFreez = new TakenFreezRepo();

        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        long CurrentMemberId = -1;

        public ReservationUserControl()
        {
            InitializeComponent();
        }

        private void ReservationUserControl_Load(object sender, EventArgs e)
        {
            string errorMsg;

            LoadAllMembers();
            var trainers = Trainers.GetAllTrainers(out errorMsg);
            foreach (var trainer in trainers)
            {
                TrainersComboBox.Items.Add(trainer);
            }
        }
        public void LoadAllMembers()
        {
            string errorMsg;
            List<string> Names = MemberProfile.GetAllMembersNames(out errorMsg);
            foreach (var name in Names)
            {
                long memberId = MemberProfile.GetMemberId(name, out errorMsg);
                if (RegisteredCard.IsMemberCurrentActive(memberId, out errorMsg))
                {
                    if(!coll.Contains(name))
                        coll.Add(name);
                }
            }
            NamesTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NamesTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NamesTextBox.AutoCompleteCustomSource = coll;
        }

        private void NamesTextBox_TextChanged(object sender, EventArgs e)
        {
            string errorMsg;
            byte[] pic = MemberProfile.GetMemberProfile(NamesTextBox.Text, out errorMsg);
            loadPicture(pic);

            CurrentMemberId = MemberProfile.GetMemberId(NamesTextBox.Text, out errorMsg);
            int availableFreez = 0;
            //CardDetailesId = RegisteredCard.GetCardDetailesID(CurrentMemberId, out errorMsg);

            int totalFreez = RegisteredCard.GetTotalFreez(CurrentMemberId, out errorMsg);
            int takenFreez = RegisteredCard.GetOldFreez(CurrentMemberId, out errorMsg);
            availableFreez = totalFreez - takenFreez;
            DateTime endDate = RegisteredCard.GetEndDate(CurrentMemberId, out errorMsg);
            int remainingInDays = (endDate - StartFromDateTimePicker.Value).Days + 1;

            if (remainingInDays < availableFreez)
                availableFreez = remainingInDays;
            if (availableFreez < 0)
                availableFreez = 0;

            FreezDurationNumericUpDown.Minimum = 0;
            FreezDurationNumericUpDown.Maximum = availableFreez;
            FreezDurationNumericUpDown.Value = 0;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg;
            int TotalPersonal = RegisteredCard.GetTotalPersonal(CurrentMemberId, out errorMsg);
            int takenPersonal = RegisteredCard.GetOldPersonal(CurrentMemberId, out errorMsg);
            if (TotalPersonal - takenPersonal <= 0)
            {
                MessageBox.Show("لا يمكن حجز مدرب شخصى للعضو", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentMemberId == -1)
            {
                MessageBox.Show("إختر عضو أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (StartFromDateTimePicker.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("لا يمكن حجز مدرب شخصى فى نفس اليوم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TrainersComboBox.SelectedItem == null)
            {
                MessageBox.Show("إختر مدرب أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool success = RegisteredCard.ReservePersonal(CurrentMemberId, out errorMsg);
            var cardId = RegisteredCard.GetCardID(CurrentMemberId, out errorMsg);
            var trainerId = Trainers.GetTrainerId(TrainersComboBox.SelectedItem.ToString(), out errorMsg);
            success = TakenPT.InsertTakenPT(CurrentMemberId, cardId, trainerId, StartFromDateTimePicker.Value, out errorMsg);
            if (!success)
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("تم حجز مدرب شخصى للعميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FreezDurationNumericUpDown.Value == 0)
            {
                MessageBox.Show("مدة التجميد غير صالحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string errorMsg;
            DateTime endDate = RegisteredCard.GetEndDate(CurrentMemberId, out errorMsg);
            if (StartFromDateTimePicker.Value >= endDate)
            {
                MessageBox.Show("لا يمكن طلب تجميد فى الفترة المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool success = RegisteredCard.ReserveFreez(CurrentMemberId, (int)FreezDurationNumericUpDown.Value, out errorMsg);
            var cardId = RegisteredCard.GetCardID(CurrentMemberId, out errorMsg);
            success = TakenFreez.InsertNewTakenFreez(CurrentMemberId, cardId, dateTimePicker1.Value,
                dateTimePicker1.Value.AddDays((int)FreezDurationNumericUpDown.Value), out errorMsg);
            if (!success)
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("تم تجميد المدة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            NamesTextBox_TextChanged(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string errorMsg;
            int totalInvitation = RegisteredCard.GetTotalInvitation(CurrentMemberId, out errorMsg);
            int takenInvitation = RegisteredCard.GetOldInvitation(CurrentMemberId, out errorMsg);

            int availableInvitation = 0;
            availableInvitation = totalInvitation - takenInvitation;
            if (availableInvitation <= 0)
            {
                MessageBox.Show("لا يمكن إستخدام دعوة للعميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool exist = WelcomeProfile.IsExist(NameTextBox.Text, out errorMsg);
            if (!exist)
            {
                bool success = WelcomeProfile.InsertNewProfile(NameTextBox.Text, AddressTextBox.Text, PhoneTextBox.Text, CurrentMemberId, out errorMsg);
                success = RegisteredCard.ReservePersonal(CurrentMemberId, out errorMsg);
                success = RegisteredCard.ReserveInvitation(CurrentMemberId, out errorMsg);
                if (!success)
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("تم إدخال حجز الدعوة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("تمت الزيارة للمدعو من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
