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
using MonstersGYM.Core.PocoClasses;

namespace MonstersGYM
{
    public partial class AddCardsUserControl : UserControl
    {
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        ICards Card = new CardsRepo();
        List<Cards> RegisteredCards;
        public AddCardsUserControl()
        {
            InitializeComponent();
        }

        private void AddCardsUserControl_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            LoadCardsName();
            LoadAllCards();
        }
        public void LoadCardsName()
        {
            comboBox1.Items.Clear();
            string errorMsg = "";
            var names = CardDefinition.GetAllCardName(out errorMsg);
            comboBox1.Items.Add("");
            if (string.IsNullOrEmpty(errorMsg))
            {
                foreach (var name in names)
                    comboBox1.Items.Add(name);
            }
            else
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void LoadAllCards()
        {
            string errorMsg = "";
            int cardHeaderID = -1;
            if (comboBox1.SelectedItem != null && !string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
                cardHeaderID = CardDefinition.GetCardId(comboBox1.SelectedItem.ToString().Trim(), out errorMsg);

            RegisteredCards = Card.GetAllCards(cardHeaderID , out errorMsg);
            CountLabel.Text = RegisteredCards.Count.ToString();
            dataGridView1.DataSource = RegisteredCards;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || (comboBox1.SelectedItem != null && string.IsNullOrEmpty(comboBox1.SelectedItem.ToString())) )
            {
                MessageBox.Show("أختر نوع الكارت أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("لا يمكن تسجيل باركود فارغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string errorMsg = "";
            int cardId = CardDefinition.GetCardId(comboBox1.SelectedItem.ToString().Trim(), out errorMsg);
            bool success = Card.InsertNewCard(cardId, textBox1.Text, out errorMsg);
            if (success)
            {
                LoadAllCards();
                //var card = new Cards();
                //card.CreatedOn = DateTime.Now;
                //card.CreatedBy = User.CurrentUser.Name;
                //card.Barcode = textBox1.Text;
                //card.CardType =comboBox1.SelectedItem.ToString().Trim();
                //RegisteredCards.Add(card);
                //RegisteredCards = RegisteredCards.OrderByDescending(x => x.CreatedOn).ToList();
                //MessageBox.Show("تم تسجيل الكارت بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            textBox1.Text = "";
            textBox1.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                bool success = Card.RemoveCard(row.Cells["Barcode"].Value as string, out errorMsg);
                if (success)
                {
                    LoadAllCards();
                    MessageBox.Show("تم حذف الكارت بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("من فضلك اختر كارت واحد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            SearchTextBox.Text = "";
        }

        private void AddCardsUserControl_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                RegisterButton_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllCards();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RegisteredCards = RegisteredCards.Where(x => x.Barcode == SearchTextBox.Text).ToList();
            CountLabel.Text = RegisteredCards.Count.ToString();
            dataGridView1.DataSource = RegisteredCards;
        }
    }
}
