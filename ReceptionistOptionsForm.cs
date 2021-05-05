using MonstersGYM.Core.PocoClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonstersGYM
{
    public partial class ReceptionistOptionsForm : Form
    {
        LoginForm LoginForm;
        public ReceptionistOptionsForm(LoginForm LoginForm)
        {
            InitializeComponent();
            this.LoginForm = LoginForm;
        }

        private void WelcomeProfileButton_Click(object sender, EventArgs e)
        {
            WelcomeProfileForm newForm = new WelcomeProfileForm(this);
            this.Hide();
            newForm.Show();
        }

        private void NewMemberButton_Click(object sender, EventArgs e)
        {
            NewMemberProfileForm newForm = new NewMemberProfileForm(this);
            this.Hide();
            newForm.Show();
        }

        private void CardExchangeutton_Click(object sender, EventArgs e)
        {
            CardExchangeForm newForm = new CardExchangeForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ExtentRegisterationButton_Click(object sender, EventArgs e)
        {
            ExtendRegisterationForm newForm = new ExtendRegisterationForm(this);
            this.Hide();
            newForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure ? ", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                User.CurrentUser = null;
                this.Close();
                LoginForm.Show();
            }
        }

        private void PersonalTrainerButton_Click(object sender, EventArgs e)
        {
            ReservationForm newForm = new ReservationForm(this);
            this.Hide();
            newForm.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignInForm newForm = new SignInForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            ChaneInfoForm newForm = new ChaneInfoForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ReceptionistOptionsForm_Load(object sender, EventArgs e)
        {
            HomeButton_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure ? ", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                User.CurrentUser = null;
                this.Close();
                LoginForm.Show();
            }
        }

        private void ChangeInfoButton2_Click(object sender, EventArgs e)
        {
            panel4.Height = ChangeInfoButton2.Height;
            panel4.Top = ChangeInfoButton2.Top;
            changeInfoUserControl1.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            homeUserControl1.BringToFront();
            panel4.Height = 0;
            panel4.Top = 0;
        }

        private void SignInButton2_Click(object sender, EventArgs e)
        {
            panel4.Height = SignInButton2.Height;
            panel4.Top = SignInButton2.Top;
            signInUserControl1.BringToFront();
        }

        private void WelcomeProfileButton2_Click(object sender, EventArgs e)
        {
            panel4.Height = WelcomeProfileButton2.Height;
            panel4.Top = WelcomeProfileButton2.Top;
            welcomeProfileUserControl1.BringToFront();
        }

        private void NewMemberButton2_Click(object sender, EventArgs e)
        {
            panel4.Height = NewMemberButton2.Height;
            panel4.Top = NewMemberButton2.Top;
            newMemberProfileUserControl1.BringToFront();
        }

        private void ExtentRegisterationButton2_Click(object sender, EventArgs e)
        {
            panel4.Height = ExtentRegisterationButton2.Height;
            panel4.Top = ExtentRegisterationButton2.Top;
            extendRegisterationUserControl1.BringToFront();
        }

        private void PersonalTrainerButton2_Click(object sender, EventArgs e)
        {
            panel4.Height = PersonalTrainerButton2.Height;
            panel4.Top = PersonalTrainerButton2.Top;
            reservationUserControl1.BringToFront();
        }

        private void CardExchangeutton2_Click(object sender, EventArgs e)
        {
            panel4.Height = CardExchangeutton2.Height;
            panel4.Top = CardExchangeutton2.Top;
            cardExchangeUserControl1.BringToFront();
        }
    }
}
