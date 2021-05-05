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
    public partial class AddTrainerForm : Form
    {
        
        OwnerOptionForm OwnerOptionForm;
        ITrainers Trainers = new TrainersRepo();
        public AddTrainerForm(OwnerOptionForm OwnerOptionForm)
        {
            InitializeComponent();
            this.OwnerOptionForm = OwnerOptionForm;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            OwnerOptionForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool isExist = Trainers.IsExist(NameTextBox.Text, out errorMsg);
            if (isExist)
            {
                MessageBox.Show("exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = Trainers.InsertNewTrainer(NameTextBox.Text, out errorMsg);
                if(success)
                    MessageBox.Show("inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AddTrainerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
