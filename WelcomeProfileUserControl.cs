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
    public partial class WelcomeProfileUserControl : UserControl
    {
        IWelcomeProfile WelcomeProfile = new WelcomeProfileRepo();
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        IIncome Income = new IncomeRepo();
        ICardDefinition cardDefinition = new CardDefinitionRepo();
        public WelcomeProfileUserControl()
        {
            InitializeComponent();
            SessionComboBox.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";

            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(AddressTextBox.Text) || string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                MessageBox.Show("يجب ملئ جميع البيانات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SessionCheckBox.Checked && SessionComboBox.SelectedItem == null)
            {
                MessageBox.Show("يجب إختيار نوع الحصة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SessionCheckBox.Checked)
            {
                int cardId = cardDefinition.GetCardId(SessionComboBox.SelectedItem.ToString(), out errorMsg);
                var price = cardDefinition.GetCardPrice(cardId, out errorMsg);
                var result = MessageBox.Show("السعر " + price.ToString(), "تأكيد", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                    return;
            }
            bool exist = false;
            exist = WelcomeProfile.IsExist(NameTextBox.Text, out errorMsg);
            if (!exist || (exist && SessionCheckBox.Checked))
            {
                bool success = false;
                if (!exist)
                    success = WelcomeProfile.InsertNewProfile(NameTextBox.Text, AddressTextBox.Text, PhoneTextBox.Text, -1, out errorMsg);

                if (SessionCheckBox.Checked)
                {
                    int cardId = cardDefinition.GetCardId(SessionComboBox.SelectedItem.ToString(), out errorMsg);
                    var price = cardDefinition.GetCardPrice(cardId, out errorMsg);
                    var profile = WelcomeProfile.GetWelcomeProfile(NameTextBox.Text, out errorMsg);
                    success = Income.InsertNewIncome(profile.Id, User.CurrentUser.ID,cardId,2,price, price,-1,out errorMsg);
                }

                if (success)
                {
                    NameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("تم زيارة المدعو من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void WelcomeProfileUserControl_Load(object sender, EventArgs e)
        {
            string errorMsg = "";

            List<string> profiles = WelcomeProfile.LoadAllWelcomeProfileNames(out errorMsg);
            foreach (var profile in profiles)
                coll.Add(profile);
            NameTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NameTextBox.AutoCompleteCustomSource = coll;
        }
        public void LoadWelcomeProfile(long userId, DateTime fromDate, DateTime toDate)
        {
            string errorMsg;
            List<GeneralWelcomeProfileReport> general;
            List<WelcomeProfileReport> Logs = WelcomeProfile.LoadVisitsLogsReport(userId, fromDate, toDate, out general, out errorMsg);
            var report = Logs.Select(x => new { x.IsMember, x.MemberName, x.Phone, x.Date, x.Address, x.InvitedBy }).ToList();
            dataGridView1.DataSource = report;
        }
        private void SessionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SessionCheckBox.Checked)
                SessionComboBox.Enabled = true;
            else
                SessionComboBox.Enabled = false;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string errorMsg;
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                bool exist = WelcomeProfile.IsExist(NameTextBox.Text, out errorMsg);
                if (exist)
                {
                    var profile = WelcomeProfile.GetWelcomeProfile(NameTextBox.Text, out errorMsg);
                    PhoneTextBox.Text = profile.Phone;
                    AddressTextBox.Text = profile.Address;
                }
                else
                {
                    PhoneTextBox.Text = "";
                    AddressTextBox.Text = "";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcelSheet();
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
                worksheet.Name = "Welcome Profile Report - " + User.CurrentUser.UserName  ;
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
                MessageBox.Show(ex.ToString() + "/n details: " + ex.InnerException , "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
