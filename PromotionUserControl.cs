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
    public partial class PromotionUserControl : UserControl
    {
        IPromotion Promotion = new PromotionRepo();
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        List<Promotions> PromotionList = new List<Promotions>();
        public PromotionUserControl()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PromotionNameTextBox.Text) || (int)numericUpDown1.Value == 0 
                || CardsNamesCheckedListBox.CheckedItems.Count == 0 || DurationCheckedListBox.CheckedItems.Count == 0 )
            {
                MessageBox.Show("إدخل البيانات كاملة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fromDate = FromDateTimePicker.Value.Date;
            var toDate = ToDateTimePicker.Value.Date.AddDays(1);
            if (fromDate > toDate)
            {
                MessageBox.Show("إختر مدة صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string errorMsg = "";

            string IDs = "";
            foreach (var item in CardsNamesCheckedListBox.CheckedItems)
            {
                var id = CardDefinition.GetCardId(item.ToString().Trim(), out errorMsg);
                if(id != -1)
                    IDs += id.ToString() + ";";
            }
            IDs = IDs.Remove(IDs.LastIndexOf(';'));

            string durations = "";
            foreach (var item in DurationCheckedListBox.CheckedItems)
            {
                durations += item.ToString().Trim() + ";";
            }
            durations = durations.Remove(durations.LastIndexOf(';'));

            bool success = Promotion.AddNewPromotion(PromotionNameTextBox.Text, fromDate, toDate, (int)numericUpDown1.Value, IDs, durations, SharedEnum.PromotionType.Cards , out errorMsg);
            if (!success || !string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                LoadAllPromo();
                MessageBox.Show("تم إضافة العرض بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromotionNameTextBox.Text = "";
                numericUpDown1.Value = 0;
                UncheckSelected(CardsNamesCheckedListBox);
                UncheckSelected(DurationCheckedListBox);
            }
        }
        void UncheckSelected(CheckedListBox Control)
        {
            foreach (int checkedItemIndex in Control.CheckedIndices)
            {
                Control.SetItemChecked(checkedItemIndex, false);
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                long PromoId = -1;
                string id = row.Cells[0].Value.ToString();
                DateTime to = DateTime.MinValue;
                DateTime from = DateTime.MinValue;
                bool active = false;

                DateTime.TryParse(row.Cells[6].Value.ToString(),out from);
                DateTime.TryParse(row.Cells[7].Value.ToString(), out to);
                bool.TryParse(row.Cells[8].Value.ToString(), out active);
                if (from == DateTime.MinValue || to == DateTime.MinValue)
                {
                    MessageBox.Show("صيغة التاريغ خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long.TryParse(id, out PromoId);
                bool success = Promotion.EditPromotion(PromoId,from,to, active, out errorMsg);
                if (success)
                {
                    LoadAllPromo();
                    MessageBox.Show("تم تعديل العرض بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("إختر عرض واحد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void LoadAllPromo()
        {
            string errorMsg = "";
            PromotionList = Promotion.GetAllPromotion(out errorMsg);
            dataGridView1.DataSource = PromotionList;

            dataGridView1.Columns[0].ReadOnly = dataGridView1.Columns[1].ReadOnly = dataGridView1.Columns[2].ReadOnly = dataGridView1.Columns[3].ReadOnly
                = dataGridView1.Columns[4].ReadOnly = dataGridView1.Columns[5].ReadOnly = dataGridView1.Columns[9].ReadOnly = dataGridView1.Columns[10].ReadOnly = true;
        }
        void LoadAllCardName()
        {
            string errorMsg = "";
            List<string> cardsNames = CardDefinition.GetAllCardName(out errorMsg);
            cardsNames = cardsNames.Where(x => x != "رجال" && x != "سيدات").ToList();
            CardsNamesCheckedListBox.Items.AddRange(cardsNames.ToArray());
        }
        private void PromotionUserControl_Load(object sender, EventArgs e)
        {
            LoadAllPromo();
            LoadAllCardName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
