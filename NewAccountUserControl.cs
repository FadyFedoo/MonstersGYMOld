using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonstersGYM.Core.Interface;
using MonstersGYM.Infrastructure.Repository;
using MonstersGYM.Core.PocoClasses;
using static MonstersGYM.Core.PocoClasses.SharedEnum;

namespace MonstersGYM
{
    public partial class NewAccountUserControl : UserControl
    {
        IUserAccounts UserAccount = new UserAccountRepo();

        public NewAccountUserControl()
        {
            InitializeComponent();
        }

        private void NewAccountUserControl_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }
        void LoadAllUsers()
        {
            string errorMsg = "";
            List<User> Users = UserAccount.LoadAllUsers(out errorMsg);
            if (!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("تم حذف المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("إختر مستخدم واحد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool success = UserAccount.IsExist(UserNameTextBox.Text, out errorMsg);
            if (success)
                MessageBox.Show("أسم المستخدم موجود من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                success = UserAccount.InsertNewAccount(NameTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, UserType.Receptionist, UserStatus.Active, out errorMsg);
                if (success)
                {
                    UserNameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    LoadAllUsers();
                    MessageBox.Show("تم إضافة مستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
