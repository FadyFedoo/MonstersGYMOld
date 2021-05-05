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
    public partial class CollectIncomeForm : Form
    {
        OwnerOptionForm OwnerOptionForm;
        IUserAccounts UserAccount = new UserAccountRepo();
        IIncome UserIncome = new IncomeRepo();

        List<User> Users = new List<User>();
        public CollectIncomeForm(OwnerOptionForm OwnerOptionForm)
        {
            InitializeComponent();
            this.OwnerOptionForm = OwnerOptionForm;
        }

        private void CollectIncomeForm_Load(object sender, EventArgs e)
        {
            string errorMsg = "";
            Users = UserAccount.LoadAllUsers(out errorMsg);

            foreach (var user in Users)
                comboBox1.Items.Add(user.UserName);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            OwnerOptionForm.Show();
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
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show("select user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var selectedUserName = comboBox1.SelectedItem.ToString();
            User currentUser = Users.FirstOrDefault(x => x.UserName == selectedUserName);
            bool success = UserIncome.CloseIncome(currentUser.ID, int.Parse(TotalIncomeTextBox.Text), out errorMsg);
            if(success)
                MessageBox.Show("updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dataGridView1.DataSource = null;
            comboBox1.SelectedItem = null;
        }
    }
}
