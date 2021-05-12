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
    public partial class AddTrainerUserControl : UserControl
    {
        ITrainers Trainers = new TrainersRepo();

        public AddTrainerUserControl()
        {
            InitializeComponent();
        }

        private void AddTrainerUserControl_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool isExist = Trainers.IsExist(NameTextBox.Text, out errorMsg);
            if (isExist)
            {
                MessageBox.Show("تم إضافة الاسم من قبل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = Trainers.InsertNewTrainer(NameTextBox.Text, out errorMsg);
                if (success)
                    MessageBox.Show("تم إضافة المدرب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
