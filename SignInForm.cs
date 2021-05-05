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
    public partial class SignInForm : Form
    {
        ReceptionistOptionsForm ReceptionistOptionsForm;
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        ICards Cards = new CardsRepo();
        IMemberProfile MemberProfile = new MemberProfileRepo();
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        IMemberSignIn MemberSignIn = new MemberSignInRepo();
        ITakenPT TakenPT = new TakenPTRepo();

        public SignInForm(ReceptionistOptionsForm ReceptionistOptionsForm)
        {
            InitializeComponent();
            this.ReceptionistOptionsForm = ReceptionistOptionsForm;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceptionistOptionsForm.Show();
        }

        private void ScannedBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            string errorMsg = "";
            long cardId = Cards.GetCardId(ScannedBarcodeTextBox.Text, out errorMsg);
            long memberId = RegisteredCard.GetMemberID(cardId, out errorMsg);
            NameLabel.Text =  MemberProfile.GetMemberName(memberId, out errorMsg);
            byte[] pic = MemberProfile.GetMemberProfile(NameLabel.Text, out errorMsg);
            loadPicture(pic);
            int cardHeaderId = Cards.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
            CardTypeLabel.Text = CardDefinition.GetCardName(cardHeaderId, out errorMsg);

            DateTime startDate = RegisteredCard.GetStartDate(memberId, out errorMsg);
            StartFromLabel.Text = startDate.ToShortDateString();

            DateTime endDate = RegisteredCard.GetEndDate(memberId, out errorMsg);
            EndDateLabel.Text = endDate.ToShortDateString();
            int takenFreez = RegisteredCard.GetOldFreez(memberId, out errorMsg);
            int remainingDays = (endDate - DateTime.Now.Date).Days + takenFreez;

            RemainingDaysLabel.Text = remainingDays.ToString() + " يوم";

            long registeredCardID = RegisteredCard.GetCardID(memberId, out errorMsg);

            int totalAttendance = MemberSignIn.GetTottalAttendance(memberId, registeredCardID, out errorMsg);

            AttendanceLabel.Text = totalAttendance.ToString();

            var trainername = TakenPT.GetReservedPT(cardId, out errorMsg);
            TrainerNameLabel.Text = string.IsNullOrEmpty(trainername) ? "لا يوجد" : trainername;

            int totalFreez = RegisteredCard.GetTotalFreez(memberId, out errorMsg);
            int availableFreez = totalFreez - takenFreez;
            RemainingFreezLabel.Text = availableFreez.ToString();

            int TotalPersonal = RegisteredCard.GetTotalPersonal(memberId, out errorMsg);
            int takenPersonal = RegisteredCard.GetOldPersonal(memberId, out errorMsg);
            RemainningPTLabel.Text = (TotalPersonal - takenPersonal).ToString();

            int totalInvitation = RegisteredCard.GetTotalInvitation(memberId, out errorMsg);
            int takenInvitation = RegisteredCard.GetOldInvitation(memberId, out errorMsg);
            RemainingInvitationLabel.Text = (totalInvitation - takenInvitation).ToString();


            StatusLabel.ForeColor = Color.Black;
            try
            {
                if (MemberSignIn.SignInBefore(memberId, registeredCardID, out errorMsg))
                {
                    StatusLabel.Text = "not valid : signed before today";
                    StatusLabel.BackColor = Color.Red;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\notvalid.wav");
                    player.Play();
                }
                else if (endDate > DateTime.Now && startDate <= DateTime.Now)
                {
                    StatusLabel.Text = "valid";
                    StatusLabel.BackColor = Color.Green;
                    bool success = MemberSignIn.InsertNewSignIn(memberId, registeredCardID, out errorMsg);
                    if (!success)
                        MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\valid.wav");
                    player.Play();
                }
                else
                {
                    StatusLabel.Text = "not valid : not registered";
                    StatusLabel.BackColor = Color.Red;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\notvalid.wav");
                    player.Play();

                }
            }
            catch(Exception ex)
            {

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

        private void SignInForm_Load(object sender, EventArgs e)
        {
            ScannedBarcodeTextBox.Focus();
        }
    }
}
