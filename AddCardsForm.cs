using MonstersGYM.Core.Interface;
using MonstersGYM.Core.PocoClasses;
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
    public partial class AddCardsForm : Form
    {
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        ICards Card = new CardsRepo();
        OwnerOptionForm OwnerOptionForm;
        public AddCardsForm(OwnerOptionForm OwnerOptionForm)
        {
            InitializeComponent();
            this.OwnerOptionForm = OwnerOptionForm;
        }

        private void AddCardsForm_Load(object sender, EventArgs e)
        {
            ScanBarcodeButton.Focus();
            LoadCardsName();
            LoadAllCards();
        }
        void LoadCardsName()
        {
            comboBox1.Items.Clear();
            string errorMsg = "";
            var names = CardDefinition.GetAllCardName(out errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                foreach (var name in names)
                    comboBox1.Items.Add(name);
            }
            else
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void LoadAllCards()
        {
            string errorMsg = "";
            List<Cards> RegisteredCards = Card.GetAllCards(out errorMsg);
            dataGridView1.DataSource = RegisteredCards;
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            int cardId = CardDefinition.GetCardId(comboBox1.SelectedItem.ToString().Trim(), out errorMsg);
            
            bool success = Card.InsertNewCard(cardId, textBox1.Text, out errorMsg);
            if (success)
            {
                textBox1.Text = "";
                ScanBarcodeButton.Focus();
                LoadAllCards();
                MessageBox.Show("inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("select one record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            OwnerOptionForm.Show();
        }
    }
}
