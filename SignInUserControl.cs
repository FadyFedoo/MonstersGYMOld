using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonstersGYM.Infrastructure.Repository;
using MonstersGYM.Core.Interface;
using System.IO;

namespace MonstersGYM
{
    public partial class SignInUserControl : UserControl
    {
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        ICards Cards = new CardsRepo();
        IMemberProfile MemberProfile = new MemberProfileRepo();
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        IMemberSignIn MemberSignIn = new MemberSignInRepo();
        ITakenPT TakenPT = new TakenPTRepo();

        public SignInUserControl()
        {
            InitializeComponent();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RemainingDaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void StartFromLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CardTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EndDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignInUserControl_Load(object sender, EventArgs e)
        {
            ScannedBarcodeTextBox.Focus();
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

        private void ScannedBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ScannedBarcodeTextBox.Text.Count() == 4)
            {
                string errorMsg = "";
                long cardId = Cards.GetCardId(ScannedBarcodeTextBox.Text, out errorMsg);
                long memberId = RegisteredCard.GetMemberID(cardId, out errorMsg);
                NameLabel.Text = MemberProfile.GetMemberName(memberId, out errorMsg);
                byte[] pic = MemberProfile.GetMemberProfile(NameLabel.Text, out errorMsg);
                loadPicture(pic);
                int cardHeaderId = Cards.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
                CardTypeLabel.Text = CardDefinition.GetCardName(cardHeaderId, out errorMsg).Trim();

                DateTime startDate = RegisteredCard.GetStartDate(memberId, out errorMsg);
                StartFromLabel.Text = startDate.ToShortDateString();

                DateTime endDate = RegisteredCard.GetEndDate(memberId, out errorMsg , cardId);
                int takenFreez = RegisteredCard.GetOldFreez(memberId, out errorMsg);
                int remainingDays = 0;
                if (endDate != DateTime.MinValue)
                {
                    endDate = endDate.AddDays(takenFreez);
                    remainingDays = (endDate - DateTime.Now.Date).Days;
                }

                EndDateLabel.Text = endDate.ToShortDateString();
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

                int totalClasses = RegisteredCard.GetTotalClasses(memberId, out errorMsg);
                int takenClasses = RegisteredCard.GetOldClasses(memberId, out errorMsg);
                RemainningClasseslabel.Text = (totalClasses - takenClasses).ToString();

                StatusLabel.ForeColor = Color.Black;
                try
                {
                    if (MemberSignIn.SignInBefore(memberId, registeredCardID, out errorMsg))
                    {
                        StatusLabel.Text = "غير مسموح , تم الدخول من قبل فى نفس اليوم";
                        StatusLabel.BackColor = Color.Red;
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\notvalid.wav");
                        player.Play();
                    }
                    else if (endDate > DateTime.Now && startDate <= DateTime.Now)
                    {
                        StatusLabel.Text = "مسموح بالدخول";
                        StatusLabel.BackColor = Color.Green;
                        bool success = MemberSignIn.InsertNewSignIn(memberId, registeredCardID, out errorMsg);
                        if (!success)
                            MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\valid.wav");
                        player.Play();
                    }
                    else
                    {
                        StatusLabel.Text = "غير مسموح , الكارت غير مسجل أو تم إنتهاء الإشتراك";
                        StatusLabel.BackColor = Color.Red;
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\notvalid.wav");
                        player.Play();

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    ScannedBarcodeTextBox.Text = "";
                }
            }
        }

        private void RemainingInvitationLabel_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void RemainningPTLabel_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RemainingFreezLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TrainerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignInUserControl_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
