using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonstersGYM.Infrastructure.Repository;
using MonstersGYM.Core.Interface;
using static MonstersGYM.Core.PocoClasses.SharedEnum;

namespace MonstersGYM
{
    public partial class IncommingAndExpensesUserControl : UserControl
    {
        IIncomingAndExpenses IncomingAndExpens = new IncomingAndExpensesRepo();
        public IncommingAndExpensesUserControl()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IncomingSaveButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("هل انت متأكد ؟ " ,"تأكيد", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                saveIncomingAndExpens(IncomingTextBox.Text, IncomingDateTimePicker.Value, (long)IncomingNumericUpDown.Value, FinanceStatus.Incoming);
                IncomingTextBox.Text = "";
            }
            
        }

        void saveIncomingAndExpens(string description,DateTime date,long value , FinanceStatus status)
        {
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("إدخل الوصف أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorMsg = "";
            bool success = IncomingAndExpens.InsertIncomingAndExpens(description, date, value, status, out errorMsg);
            if (success)
            {
                MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ExpensesSaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متأكد ؟ ", "تأكيد", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                saveIncomingAndExpens(ExpensesTextBox.Text, ExpensesDateTimePicker.Value, (long)ExpensesNumericUpDown.Value, FinanceStatus.expenses);
                ExpensesTextBox.Text = "";
            }
        }
    }
}
