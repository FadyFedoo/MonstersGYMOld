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
    public partial class CardDefinitionUserControl : UserControl
    {
        ICardDefinition CardDefinition = new CardDefinitionRepo();

        public CardDefinitionUserControl()
        {
            InitializeComponent();
        }

        private void AddHeaderButton_Click(object sender, EventArgs e)
        {
            AddCardHeader(true);
        }
        void AddCardHeader(bool IsCard)
        {
            string Name;int price;
            if (IsCard)
            {
                Name = CardNameTextBox.Text;
                price = (int)CardPriceNumericUpDown.Value;
            }
            else
            {
                Name = SexComboBox.SelectedItem.ToString();
                price = (int)SessionPriceNumericUpDown.Value;
            }

            string errorMsg = "";
            bool exist = CardDefinition.IsExist(Name, out errorMsg);
            if (!exist)
            {
                bool success = CardDefinition.InsertNewDefinition(Name, price, out errorMsg);
                if (success)
                {
                    CardNameTextBox.Text = "";
                    LoadCardHeadersAndSessions();
                    MessageBox.Show("تم إضافة إسم الكارت بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("إسم الكارت موجود من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CardDefinitionUserControl_Load(object sender, EventArgs e)
        {
            LoadCardHeadersAndSessions();
        }
        public void LoadCardHeadersAndSessions()
        {
            string errorMsg;
            List<CardDefinitions> allCards = CardDefinition.GetAllCardHeaderDetails(out errorMsg);
            
            var cards = allCards.Where(x => x.Name != "رجال" && x.Name != "سيدات").ToList();
            var sessions = allCards.Where(x => x.Name == "رجال" || x.Name == "سيدات").ToList();

            dataGridView1.DataSource = cards;
            dataGridView2.DataSource = sessions;
            if (dataGridView1.DataSource != null)
                dataGridView1.Columns[0].ReadOnly = true;
            if (dataGridView2.DataSource != null)
            {
                dataGridView2.Columns[0].ReadOnly = true;
                dataGridView2.Columns[1].ReadOnly = true;
            }
        }

        private void AddSessionButton_Click(object sender, EventArgs e)
        {
            AddCardHeader(false);
        }

        private void EditCardDefinitionBbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void EditSessionButton_Click(object sender, EventArgs e)
        {
            bool success = false;
            string errorMsg = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var id = (int)row.Cells["ID"].Value;
                var name = row.Cells["Name"].Value as string;
                int price = (int)row.Cells["Price"].Value;
                success = EditHeader(id, name, price, out errorMsg);
                if (!success)
                    break;
            }
            if (success)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var id = (int)row.Cells["ID"].Value;
                    var name = row.Cells["Name"].Value as string;
                    int price = (int)row.Cells["Price"].Value;
                    success = EditHeader(id, name, price, out errorMsg);
                    if (!success)
                        break;
                }
            }
            if (success)
            {
                LoadCardHeadersAndSessions();
                MessageBox.Show("تم تعديل الكارت بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool EditHeader(int Id,string cardName,int cardPrice,out string errorMsg)
        {
            bool success = CardDefinition.EditCardHeader(Id, cardName, cardPrice, out errorMsg);
            return success;
        }
    }
}
