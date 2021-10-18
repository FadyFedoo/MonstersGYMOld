using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonstersGYM.Core.PocoClasses;
using MonstersGYM.Core.Interface;
using MonstersGYM.Infrastructure.Repository;

namespace MonstersGYM
{
    public partial class MemberReportsUserControl : UserControl
    {
        IIncome Income = new IncomeRepo();
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        public MemberReportsUserControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadIncome(User.CurrentUser.ID, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
        }
        void LoadIncome(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<GeneralFinanceReport> general;
            List<FinanceReport> Logs = Income.LoadIncomeReport(userId, fromDate, toDate, out general, out errorMsg);
            var report = Logs.Select(x => new { x.MemberName, x.Amount, x.Date, x.RecievedBy }).ToList();
            dataGridView8.DataSource = report;
            label4.Text = Logs.Sum(x => x.Amount).ToString();
        }

        private void MemberReportsUserControl_Load(object sender, EventArgs e)
        {
            LoadIncome(User.CurrentUser.ID, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
            LoadMemberShip(User.CurrentUser.ID, DateTime.MinValue, DateTime.MinValue);
        }
        public void LoadMemberShip(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<MembershipReport> memberShipDetails;
            List<GeneralMembershipReport> general = RegisteredCard.GetMembershipReport(userId, fromDate, toDate, out memberShipDetails, out errorMsg);
            dataGridView1.DataSource = general;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMemberShip(User.CurrentUser.ID, DateTime.MinValue, DateTime.MinValue);
        }
    }
}
