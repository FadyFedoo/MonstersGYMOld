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

        private void ReceptionistOptionsForm_Load(object sender, EventArgs e)
        {
            HomeButton_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل تريد تسجيل الخروج ؟", "تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            panel4.Height = 0;
            panel4.Top = 0;
            homeUserControl1.BringToFront();
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

        private void newMemberProfileUserControl1_Load(object sender, EventArgs e)
        {
            //newMemberProfileUserControl1.fillWelcomeProfile();
        }

        private void newMemberProfileUserControl1_Enter(object sender, EventArgs e)
        {
            newMemberProfileUserControl1.fillWelcomeProfile();
        }

        private void reservationUserControl1_Enter(object sender, EventArgs e)
        {
            reservationUserControl1.LoadAllMembers();
        }

        private void cardExchangeUserControl1_Enter(object sender, EventArgs e)
        {
            cardExchangeUserControl1.LoadAllMembers();
        }

        private void extendRegisterationUserControl1_Enter(object sender, EventArgs e)
        {
            extendRegisterationUserControl1.LoadAllMembers();
        }

        private void cardExchangeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            memberInfoUserControl1.BringToFront();
        }

        private void memberInfoUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void memberInfoUserControl1_Enter(object sender, EventArgs e)
        {
            memberInfoUserControl1.LoadAllMembers();
        }

        private void welcomeProfileUserControl1_Load(object sender, EventArgs e)
        {
        }

        private void welcomeProfileUserControl1_Enter(object sender, EventArgs e)
        {
            welcomeProfileUserControl1.LoadWelcomeProfile(User.CurrentUser.ID, DateTime.MinValue, DateTime.MinValue);

        }
    }
}
