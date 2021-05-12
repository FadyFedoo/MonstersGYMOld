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
    public partial class CardDefinitionAndDetailsUserControl : UserControl
    {
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        ICardDetails CardDetailes = new CardDetailsRepo();
        List<CardsDetailes> Cards = new List<CardsDetailes>();
        public CardDefinitionAndDetailsUserControl()
        {
            InitializeComponent();
        }

        private void CardDefinitionAndDetailsUserControl_Load(object sender, EventArgs e)
        {
            FillCardsNamecomboBox();
            LoadCardsDataGrid();

            DurationComboBox.Items.Add("1");
            DurationComboBox.Items.Add("3");
            DurationComboBox.Items.Add("6");
            DurationComboBox.Items.Add("9");
            DurationComboBox.Items.Add("12");
            DurationComboBox.SelectedIndex = 0;
        }

        private void AddHeaderButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool exist = CardDefinition.IsExist(CardNameTextBox.Text, out errorMsg);
            if (!exist)
            {
                bool success = CardDefinition.InsertNewDefinition(CardNameTextBox.Text, (int)CardPriceNumericUpDown.Value, out errorMsg);
                if (success)
                {
                    FillCardsNamecomboBox();
                    CardNameTextBox.Text = "";
                    MessageBox.Show("تم إضافة إسم الكارت بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("إسم الكارت موجود من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void FillCardsNamecomboBox()
        {
            CardsNameComboBox.Items.Clear();
            string errorMsg = "";
            var names = CardDefinition.GetAllCardName(out errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                foreach (var name in names)
                    CardsNameComboBox.Items.Add(name);
            }
            else
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        void LoadCardsDataGrid()
        {
            string errorMsg = "";
            var Currentcards = CardDetailes.GetAllCardDetailes(out errorMsg);
            foreach (var item in Currentcards)
            {
                CardsDetailes detail = new CardsDetailes();
                detail.Name = item.Name;
                detail.Duration = item.Duration;
                detail.Price = item.Price;
                detail.Invitation = item.Invitation;
                detail.Personal = item.Personal;
                detail.Freez = item.Freez;

                Cards.Add(detail);
            }
            dataGridView1.DataSource = Currentcards;
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
            }
        }

        private void AddDetailsButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (DurationComboBox.SelectedItem == null)
            {
                MessageBox.Show("إختر المدة أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CardsNameComboBox.SelectedItem != null)
            {
                int cardId = CardDefinition.GetCardId(CardsNameComboBox.SelectedItem.ToString().Trim(), out errorMsg);
                if (string.IsNullOrEmpty(errorMsg))
                {
                    bool exist = CardDetailes.IsExist(cardId, int.Parse(DurationComboBox.SelectedItem.ToString()), out errorMsg);
                    if (!exist)
                    {
                        bool success = CardDetailes.InsertCardDetails(cardId, int.Parse(DurationComboBox.SelectedItem.ToString()), (int)FreezNumericUpDown.Value, (int)PersonalNumericUpDown.Value
                        , (int)InvitationNumericUpDown.Value, (int)PriceNumericUpDown.Value, out errorMsg);
                        if (success)
                        {
                            LoadCardsDataGrid();
                            MessageBox.Show("تم إضافة تفاصيل الكارت بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                        MessageBox.Show("تفاصيل الكارت موجودة من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("أختر نوع الكارت أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            bool success = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var name = row.Cells["Name"].Value as string;
                var duration = (int)row.Cells["Duration"].Value;
                int freez = (int)row.Cells["Freez"].Value;
                var invitation = (int)row.Cells["Invitation"].Value;
                var PT = (int)row.Cells["Personal"].Value;
                var price = (int)row.Cells["Price"].Value;

                if (Cards.Any(x => x.Name == name && x.Duration == duration
                && (x.Freez != freez || x.Invitation != invitation || x.Personal != PT || x.Price != price)))
                {
                    var cardHeaderId = CardDefinition.GetCardId(name, out errorMsg);
                    success = CardDetailes.UpdateCardDetailes(cardHeaderId, duration, freez, PT, price, invitation, out errorMsg);
                    if (!success)
                        break;
                }
            }
            if (!success)
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var cardName = row.Cells["Name"].Value as string;
                var cardId = CardDefinition.GetCardId(cardName.Trim(), out errorMsg);
                var cardDuration = (int)row.Cells["Duration"].Value;
                var cardPrice = (int)row.Cells["Price"].Value;
                var cardFreez = (int)row.Cells["Freez"].Value;
                var cardPersonal = (int)row.Cells["Personal"].Value;
                var cardInvitation = (int)row.Cells["Invitation"].Value;


                bool success = CardDetailes.RemoveCardDetailes(cardId, cardDuration, cardFreez, cardPersonal, cardPrice, cardInvitation, out errorMsg);
                if (success)
                {
                    LoadCardsDataGrid();
                    MessageBox.Show("تم حذف الكارت بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("إختر كارت واحد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
