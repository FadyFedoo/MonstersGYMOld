using MonstersGYM.Core.Interface;
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
    public partial class WelcomeProfileForm : Form
    {
        IWelcomeProfile WelcomeProfile = new WelcomeProfileRepo();
        ReceptionistOptionsForm ReceptionistOptionsForm;
        public WelcomeProfileForm(ReceptionistOptionsForm ReceptionistOptionsForm)
        {
            InitializeComponent();
            this.ReceptionistOptionsForm = ReceptionistOptionsForm;
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
                    MessageBox.Show("Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Name exist before", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceptionistOptionsForm.Show();
        }
    }
}
