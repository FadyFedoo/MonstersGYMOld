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

    public partial class ChaneInfoForm : Form
    {
        IUserAccounts UserAccount = new UserAccountRepo();
        Form PreviousForm;
        
        public ChaneInfoForm(Form form)
        {
            InitializeComponent();
            PreviousForm = form;
        }

        private void ChaneInfoForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = User.CurrentUser.Name;
            UserNameTextBox.Text = User.CurrentUser.UserName;
            PasswordTextBox.Text = User.CurrentUser.Password;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool exist = false;
            if(User.CurrentUser.UserName != UserNameTextBox.Text)
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
                    ChaneInfoForm_Load(null, null);
                }
                else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
