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
using MonstersGYM.Core.PocoClasses;

namespace MonstersGYM
{
    public partial class ReportsMainUserControl : UserControl
    {
        IUserAccounts UserAccount = new UserAccountRepo();
        IUserInAndOut UserLogs = new UserInAndOutRepo();
        IWelcomeProfile WelcomeProfile = new WelcomeProfileRepo();
        IMemberSignIn MemberSignIn = new MemberSignInRepo();
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        IIncomingAndExpenses IncomingAndExpenses = new IncomingAndExpensesRepo();
        IIncome Income = new IncomeRepo();

        List<MembershipReport> memberShipDetails = new List<MembershipReport>();
        List<User> users;

        public ReportsMainUserControl()
        {
            InitializeComponent();
        }

        private void ReportsMainUserControl_Load(object sender, EventArgs e)
        {
            string errorMsg;
            users = UserAccount.LoadAllUsers(out errorMsg);
            foreach (var user in users)
                comboBox1.Items.Add(user.UserName);
        }
        void loadUserLogsReport(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<UserLogsReport> Logs = UserLogs.LoadUserLogsReport(userId, fromDate, toDate, out errorMsg);
            dataGridView1.DataSource = Logs;
        }
        void LoadWelcomeProfile(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<GeneralWelcomeProfileReport> general;
            List<WelcomeProfileReport> Logs = WelcomeProfile.LoadVisitsLogsReport(userId, fromDate, toDate, out general, out errorMsg);
            dataGridView2.DataSource = Logs;
            dataGridView5.DataSource = general;
            
        }
        void LoadMemberSignIn(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<MemberLogsReport> Logs = MemberSignIn.LoadMemberLogsReport(userId, fromDate, toDate, out errorMsg);
            dataGridView3.DataSource = Logs;
        }
        void LoadIncome(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<GeneralFinanceReport> general;
            List<FinanceReport> Logs = Income.LoadIncomeReport(userId, fromDate, toDate, out general, out errorMsg);

            IncomingAndExpenses.GetFinanceReport(fromDate, toDate, ref Logs, ref general, out errorMsg);

            dataGridView4.DataSource = Logs;
            dataGridView6.DataSource = general;

            int totalIncoming = Logs.Where(x => x.OriginalAmount > 0).Sum(x => x.Amount);
            int totalExpenses = Logs.Where(x => x.OriginalAmount < 0).Sum(x => x.Amount);
            int totalDiscount = Logs.Sum(x => x.Discount);

            TotalIncomingLabel.Text = totalIncoming.ToString();
            TotalExpensesLabel.Text = (totalExpenses * -1).ToString();
            TotalDiscountLabel.Text = (totalDiscount * -1).ToString();

            TotalProfitLabel.Text = (totalIncoming + totalExpenses + totalDiscount).ToString();
        }
        void LoadPromotionReport(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<GeneralPromotionReport> general;
            List<PromotionReport> Logs = Income.LoadPromotionReport(userId, fromDate, toDate, out general, out errorMsg);

            dataGridView10.DataSource = Logs;
            dataGridView9.DataSource = general;

        }
        void LoadMemberShip(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<GeneralMembershipReport> general = RegisteredCard.GetMembershipReport(userId, fromDate, toDate, out memberShipDetails, out errorMsg);
            ActiveMemberLabel.Text =  general.Count(x => x.Active).ToString();
            InActiveMemberLabel.Text =  general.Count(x => !x.Active).ToString();
            dataGridView7.DataSource = general;
            dataGridView8.DataSource = null;
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = !checkBox1.Checked;
            dateTimePicker2.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox1.SelectedItem = null;
                comboBox1.Enabled = false;
            }
            else
                comboBox1.Enabled = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedUserName = "";
            long userId = -1;
            if (comboBox1.SelectedItem != null)
            {
                selectedUserName = comboBox1.SelectedItem.ToString();
                userId = users.FirstOrDefault(x => x.UserName == selectedUserName).ID;
            }

            DateTime fromDate = checkBox1.Checked ? DateTime.MinValue.Date : dateTimePicker1.Value.Date;
            DateTime toDate = checkBox1.Checked ? DateTime.MinValue.Date : dateTimePicker2.Value.Date;
            toDate = toDate.AddDays(1);

            progressBar1.Value = 0;

            if(UserLogsCheckBox.Checked)
                loadUserLogsReport(userId, fromDate, toDate);
            progressBar1.Value += 16;

            if(WelcomeProfileCheckBox.Checked)
                LoadWelcomeProfile(userId, fromDate, toDate);
            progressBar1.Value += 17;

            if(MemberSignInCheckBox.Checked)
                LoadMemberSignIn(userId, fromDate, toDate);
            progressBar1.Value += 16;

            if(IncomeCheckBox.Checked)
                LoadIncome(userId, fromDate, toDate);
            progressBar1.Value += 17;

            if(MemberShipCheckBox.Checked)
                LoadMemberShip(userId, fromDate, toDate);
            progressBar1.Value += 17;

            if (PromotionsCheckBox.Checked)
                LoadPromotionReport(userId, fromDate, toDate);
            progressBar1.Value += 17;

        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView7.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView7.SelectedRows[0];
                var memberName = row.Cells["MemberName"].Value as string;
                var detailes = memberShipDetails.Where(x => x.MemberName == memberName).ToList();
                dataGridView8.DataSource = detailes;
            }
        }
    }
}
