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

namespace MonstersGYM
{
    public partial class WelcomeProfileUserControl : UserControl
    {
        IWelcomeProfile WelcomeProfile = new WelcomeProfileRepo();

        public WelcomeProfileUserControl()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool exist = WelcomeProfile.IsExist(NameTextBox.Text, out errorMsg);
            if (!exist)
            {
                bool success = WelcomeProfile.InsertNewProfile(NameTextBox.Text, AddressTextBox.Text, PhoneTextBox.Text, -1, out errorMsg);
                if (success)
                {
                    NameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    MessageBox.Show("Inserted", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("تم زيارة المدعو من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void WelcomeProfileUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
