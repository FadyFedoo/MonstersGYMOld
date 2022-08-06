using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonstersGYM.Core.PocoClasses;
using MonstersGYM.Core.Interface;
using MonstersGYM.Infrastructure.Repository;

namespace MonstersGYM
{
    public partial class MemberReportsUserControl : UserControl
    {
        IIncome Income = new IncomeRepo();
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        public MemberReportsUserControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadIncome(User.CurrentUser.ID, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
        }
        void LoadIncome(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<GeneralFinanceReport> general;
            List<FinanceReport> Logs = Income.LoadIncomeReport(userId, fromDate, toDate, out general, out errorMsg);
            var report = Logs.Select(x => new { x.MemberName, x.Amount, x.Date, x.RecievedBy }).ToList();
            dataGridView8.DataSource = report;
            label4.Text = Logs.Sum(x => x.Amount).ToString();
        }

        private void MemberReportsUserControl_Load(object sender, EventArgs e)
        {
            LoadIncome(User.CurrentUser.ID, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
            
        }
        public void LoadMemberShip(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<MembershipReport> memberShipDetails;
            List<GeneralMembershipReport> general = RegisteredCard.GetMembershipReport(userId, fromDate, toDate, out memberShipDetails, out errorMsg);
            dataGridView1.DataSource = general;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMemberShip(User.CurrentUser.ID, DateTime.MinValue, DateTime.MinValue);
        }
        void ExportToExcelSheet()
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Membership Report - " + User.CurrentUser.UserName ;
                // storing header part in Excel  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 2)
                            worksheet.Cells.NumberFormat = "@";
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
                var path = "e:\\" + worksheet.Name + ".xlsx";

                // save the application  
                workbook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
                MessageBox.Show("تم استخراج ملف الاكسيل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcelSheet();

        }
    }
}
