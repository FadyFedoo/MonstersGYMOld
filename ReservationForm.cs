using MonstersGYM.Core.Interface;
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

namespace MonstersGYM
{
    public partial class ReservationForm : Form
    {
        ReceptionistOptionsForm ReceptionistOptionsForm;
        IMemberProfile MemberProfile = new MemberProfileRepo();
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        ICardDetails CardDetailes = new CardDetailsRepo();
        IWelcomeProfile WelcomeProfile = new WelcomeProfileRepo();
        ITrainers Trainers = new TrainersRepo();
        ITakenPT TakenPT = new TakenPTRepo();
        ITakenFreez TakenFreez = new TakenFreezRepo();

        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        long CurrentMemberId = -1;
        long CardDetailesId = -1;
        public ReservationForm(ReceptionistOptionsForm ReceptionistOptionsForm)
        {
            InitializeComponent();
            this.ReceptionistOptionsForm = ReceptionistOptionsForm;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            string errorMsg;
            List<string> Names = MemberProfile.GetAllMembersNames(out errorMsg);
            foreach (var name in Names)
            {
                long memberId = MemberProfile.GetMemberId(name, out errorMsg);
                if (RegisteredCard.IsMemberCurrentActive(memberId, out errorMsg))
                {
                        coll.Add(name);
                }
            }
            NamesTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NamesTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NamesTextBox.AutoCompleteCustomSource = coll;

            var trainers = Trainers.GetAllTrainers(out errorMsg);
            foreach (var trainer in trainers)
            {
                TrainersComboBox.Items.Add(trainer);
            }
        }

        private void NamesTextBox_TextChanged(object sender, EventArgs e)
        {
            string errorMsg;
            byte[] pic = MemberProfile.GetMemberProfile(NamesTextBox.Text, out errorMsg);
            loadPicture(pic);

            CurrentMemberId = MemberProfile.GetMemberId(NamesTextBox.Text, out errorMsg);
            int availableFreez = 0;
            CardDetailesId = RegisteredCard.GetCardDetailesID(CurrentMemberId, out errorMsg);

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
                MessageBox.Show("not deserved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentMemberId == -1)
            {
                MessageBox.Show("select member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (StartFromDateTimePicker.Value.Date == DateTime.Now.Date)
            //{
            //    MessageBox.Show("not valid ,Resrve before 24 hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (TrainersComboBox.SelectedItem == null)
            {
                MessageBox.Show("select trainer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool success = RegisteredCard.ReservePersonal(CurrentMemberId, out errorMsg);
            var cardId = RegisteredCard.GetCardID(CurrentMemberId, out errorMsg);
            var trainerId = Trainers.GetTrainerId(TrainersComboBox.SelectedItem.ToString(), out errorMsg);
            success = TakenPT.InsertTakenPT(CurrentMemberId, cardId, trainerId, StartFromDateTimePicker.Value, out errorMsg);
            if (!success)
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FreezDurationNumericUpDown.Value == 0)
            {
                MessageBox.Show("duration < 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string errorMsg;
            DateTime endDate = RegisteredCard.GetEndDate(CurrentMemberId, out errorMsg);
            if (StartFromDateTimePicker.Value >= endDate)
            {
                MessageBox.Show("date after end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool success = RegisteredCard.ReserveFreez(CurrentMemberId, (int)FreezDurationNumericUpDown.Value, out errorMsg);
            var cardId = RegisteredCard.GetCardID(CurrentMemberId, out errorMsg);
            success = TakenFreez.InsertNewTakenFreez(CurrentMemberId, cardId, dateTimePicker1.Value, 
                dateTimePicker1.Value.AddDays((int)FreezDurationNumericUpDown.Value), out errorMsg);
            if (!success)
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceptionistOptionsForm.Show();
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
                MessageBox.Show("not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool exist = WelcomeProfile.IsExist(NameTextBox.Text, out errorMsg);
            if (!exist)
            {
                bool success = WelcomeProfile.InsertNewProfile(NameTextBox.Text, AddressTextBox.Text, PhoneTextBox.Text, CurrentMemberId, out errorMsg);
                success = RegisteredCard.ReservePersonal(CurrentMemberId, out errorMsg);
                success = RegisteredCard.ReserveInvitation(CurrentMemberId, out errorMsg);
                if (!success)
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Name exist before", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
