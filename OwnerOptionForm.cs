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
    public partial class OwnerOptionForm : Form
    {
        LoginForm loginForm;
        public OwnerOptionForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            HomeButton_Click(null, null);
        }

        private void NewAccountButton_Click(object sender, EventArgs e)
        {
            panel4.Height = NewAccountButton.Height;
            panel4.Top = NewAccountButton.Top;
            newAccountUserControl1.BringToFront();

            //NewAccountForm newForm = new NewAccountForm(this);
            //this.Hide();
            //newForm.Show();
        }

        private void NewCardButton_Click(object sender, EventArgs e)
        {
            panel4.Height = NewCardButton.Height;
            panel4.Top = NewCardButton.Top;
            cardDefinitionAndDetailsUserControl1.BringToFront();

            //CardDefinitionAndDetailsForm newForm = new CardDefinitionAndDetailsForm(this);
            //this.Hide();
            //newForm.Show();
        }

        private void CardRegisterationButton_Click(object sender, EventArgs e)
        {
            panel4.Height = CardRegisterationButton.Height;
            panel4.Top = CardRegisterationButton.Top;
            addCardsUserControl1.BringToFront();


            //AddCardsForm newForm = new AddCardsForm(this);
            //this.Hide();
            //newForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                User.CurrentUser = null;
                this.Close();
                loginForm.Show();
            }
        }

        private void SettlementButton_Click(object sender, EventArgs e)
        {
            panel4.Height = SettlementButton.Height;
            panel4.Top = SettlementButton.Top;
            collectIncomeUserControl1.BringToFront();

            //CollectIncomeForm newForm = new CollectIncomeForm(this);
            //this.Hide();
            //newForm.Show();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            panel4.Height = ReportsButton.Height;
            panel4.Top = ReportsButton.Top;
            reportsMainUserControl1.BringToFront();

            //ReportsMainForm newForm = new ReportsMainForm(this);
            //this.Hide();
            //newForm.Show();
        }

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            panel4.Height = ChangeInfoButton.Height;
            panel4.Top = ChangeInfoButton.Top;
            changeInfoUserControl1.BringToFront();

            //ChaneInfoForm newForm = new ChaneInfoForm(this);
            //this.Hide();
            //newForm.Show();
        }

        private void AddTrainerButton_Click(object sender, EventArgs e)
        {
            panel4.Height = AddTrainerButton.Height;
            panel4.Top = AddTrainerButton.Top;
            //addTrainerUserControl1.BringToFront();

            //AddTrainerForm newForm = new AddTrainerForm(this);
            //this.Hide();
            //newForm.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            homeUserControl1.BringToFront();
            panel4.Height = 0;
            panel4.Top = 0;
        }

        private void OwnerOptionForm_Load(object sender, EventArgs e)
        {

        }

        private void changeInfoUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
