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

namespace MonstersGYM
{
    public partial class ChangeInfoUserControl : UserControl
    {
        IUserAccounts UserAccount = new UserAccountRepo();

        public ChangeInfoUserControl()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool exist = false;
            if (User.CurrentUser.UserName != UserNameTextBox.Text)
                exist = UserAccount.IsExist(UserNameTextBox.Text, out errorMsg);
            if (exist)
                MessageBox.Show("exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool success = UserAccount.UpdateInfo(NameTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, out errorMsg);
                if (success)
                {
                    User currentUser = UserAccount.LoadUser(UserNameTextBox.Text, out errorMsg);
                    User.CurrentUser = currentUser;
                    MessageBox.Show("updated", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ChangeInfoUserControl_Load(object sender, EventArgs e)
        {
            //load();
        }
        void load()
        {
            NameTextBox.Text = User.CurrentUser.Name;
            UserNameTextBox.Text = User.CurrentUser.UserName;
            PasswordTextBox.Text = User.CurrentUser.Password;
        }
    }
}
