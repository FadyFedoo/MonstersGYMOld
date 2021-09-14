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
    public partial class CollectIncomeUserControl : UserControl
    {
        IUserAccounts UserAccount = new UserAccountRepo();
        IIncome UserIncome = new IncomeRepo();

        List<User> Users = new List<User>();
        public CollectIncomeUserControl()
        {
            InitializeComponent();
        }

        private void CollectIncomeUserControl_Load(object sender, EventArgs e)
        {
            string errorMsg = "";
            Users = UserAccount.LoadAllUsers(out errorMsg);

            foreach (var user in Users)
                comboBox1.Items.Add(user.UserName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (comboBox1.SelectedItem != null)
            {
                var selectedUserName = comboBox1.SelectedItem.ToString();
                User currentUser = Users.FirstOrDefault(x => x.UserName == selectedUserName);
                var selectedIncome = UserIncome.GetUnClosedIncome(currentUser.ID, out errorMsg);
                TotalIncomeTextBox.Text = selectedIncome.Sum(x => x.Amount).ToString();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = selectedIncome;
            }
        }

        private void SettleButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("إختر أسم مستخدم لإستلام النقدية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedUserName = comboBox1.SelectedItem.ToString();
            User currentUser = Users.FirstOrDefault(x => x.UserName == selectedUserName);
            bool success = UserIncome.CloseIncome(currentUser.ID, int.Parse(TotalIncomeTextBox.Text), out errorMsg);
            if (success)
            {
                dataGridView1.DataSource = null;
                comboBox1.SelectedItem = null;
                TotalIncomeTextBox.Text = "0";
                MessageBox.Show("تم إستلام المبلغ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }
    }
}
