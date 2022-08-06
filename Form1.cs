using MonstersGYM.Core.Interface;
using MonstersGYM.Core.PocoClasses;
using MonstersGYM.Infrastructure;
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
    public partial class LoginForm : Form
    {
        IUserAccounts UserAccount = new UserAccountRepo();
        IUserInAndOut Log = new UserInAndOutRepo();

        public LoginForm()
        {
            InitializeComponent();
            if (Logs.CurrentLog == null)
                Logs.CurrentLog = new Logs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMsg;
            bool success = UserAccount.CheckLogIn(UserNameTextBox.Text, PasswordTextBox.Text, out errorMsg);
            if (!success)
            {
                var result = MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    return;
            }
            else
            {
                User currentUser = UserAccount.LoadUser(UserNameTextBox.Text, out errorMsg);
                User.CurrentUser = currentUser;
                success = Log.InsertLogIn(out errorMsg);
                if (!success)
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    UserNameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    if (currentUser.type == UserType.Receptionist)
                    {
                        this.Hide();
                        ReceptionistOptionsForm newForm = new ReceptionistOptionsForm(this);
                        newForm.Show();
                    }
                    else if (currentUser.type == UserType.Owner)
                    {

                        this.Hide();
                        OwnerOptionForm newForm = new OwnerOptionForm(this);
                        newForm.Show();
                    }
                }
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = UserNameTextBox;
            this.AcceptButton = LoginButton;  
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
