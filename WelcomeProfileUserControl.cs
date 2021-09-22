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
                    success = Income.InsertNewIncome(profile.Id, User.CurrentUser.ID,cardId,2,price,out errorMsg);
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
    }
}
