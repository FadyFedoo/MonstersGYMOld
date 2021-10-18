using MonstersGYM.Core.Interface;
using MonstersGYM.Core.PocoClasses;
using MonstersGYM.Infrastructure.Repository;
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
        IUserInAndOut userInAndOut = new UserInAndOutRepo();
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

        }

        private void NewCardButton_Click(object sender, EventArgs e)
        {
            panel4.Height = NewCardButton.Height;
            panel4.Top = NewCardButton.Top;
            cardDetailsUserControl1.BringToFront();

        }

        private void CardRegisterationButton_Click(object sender, EventArgs e)
        {
            panel4.Height = CardRegisterationButton.Height;
            panel4.Top = CardRegisterationButton.Top;
            addCardsUserControl1.BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل تريد تسجيل الخروج ؟", "تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            else
            {
                string errorMsg = "";
                bool success = userInAndOut.InsertLogOut(out errorMsg);
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
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            panel4.Height = ReportsButton.Height;
            panel4.Top = ReportsButton.Top;
            reportsMainUserControl1.BringToFront();
        }

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            panel4.Height = ChangeInfoButton.Height;
            panel4.Top = ChangeInfoButton.Top;
            changeInfoUserControl1.BringToFront();
        }

        private void AddTrainerButton_Click(object sender, EventArgs e)
        {
            panel4.Height = AddTrainerButton.Height;
            panel4.Top = AddTrainerButton.Top;
            addTrainerUserControl1.BringToFront();

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

        private void addCardsUserControl1_Enter(object sender, EventArgs e)
        {
            addCardsUserControl1.LoadCardsName();
        }

        private void addTrainerUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void changeInfoUserControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void NewCardButton_Enter(object sender, EventArgs e)
        {
            cardDetailsUserControl1.FillCardsNamecomboBox();
            cardDetailsUserControl1.LoadCardsDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = CardHeaderButton.Height;
            panel4.Top = CardHeaderButton.Top;
            cardDefinitionUserControl1.BringToFront();
        }

        private void CardHeaderButton_Enter(object sender, EventArgs e)
        {
            cardDefinitionUserControl1.LoadCardHeadersAndSessions();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            incommingAndExpensesUserControl1.BringToFront();
        }

        private void OwnerOptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string errorMsg = "";
            bool success = userInAndOut.InsertLogOut(out errorMsg);
            User.CurrentUser = null;
        }
    }
}
