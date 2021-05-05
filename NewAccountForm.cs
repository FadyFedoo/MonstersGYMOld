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
using static MonstersGYM.Core.PocoClasses.SharedEnum;

namespace MonstersGYM
{
    public partial class NewAccountForm : Form
    {
        OwnerOptionForm OwnerOptionForm;
        IUserAccounts UserAccount = new UserAccountRepo();
        public NewAccountForm(OwnerOptionForm OwnerOptionForm)
        {
            InitializeComponent();
            this.OwnerOptionForm = OwnerOptionForm;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool success = UserAccount.IsExist(UserNameTextBox.Text, out errorMsg);
            if (success)
                MessageBox.Show("Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                success = UserAccount.InsertNewAccount(NameTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, UserType.Receptionist, UserStatus.Active, out errorMsg);
                if (success)
                {
                    UserNameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    LoadAllUsers();
                    MessageBox.Show("Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void NewAccountForm_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }
        void LoadAllUsers()
        {
            string errorMsg = "";
            List<User> Users = UserAccount.LoadAllUsers(out errorMsg);
            if (!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dataGridView1.DataSource = Users;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                bool success = UserAccount.DisableAccount(row.Cells["UserName"].Value as string, out errorMsg);
                if (success)
                {
                    LoadAllUsers();
                    MessageBox.Show("Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("select one record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            OwnerOptionForm.Show();
        }
    }
}
