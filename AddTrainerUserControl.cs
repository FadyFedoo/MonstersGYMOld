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
            loadAllTrainers();
        }
        void loadAllTrainers()
        {
            string errorMsg;
            var trainers = Trainers.GetAllTrainersList(out errorMsg);
            dataGridView1.DataSource = trainers;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("إدخل البيانات كاملة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                {
                    loadAllTrainers();
                    MessageBox.Show("تم إضافة المدرب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string errorMsg = "";
                var name = dataGridView1.SelectedRows[0].Cells["Name"].Value as string;
                bool success = Trainers.DeleteTrainer(name, out errorMsg);
                if (success)
                {
                    loadAllTrainers();
                    MessageBox.Show("تم مسح المدرب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("إختر مدرب واحد فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
