﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MonstersGYM.Core.Interface;
using MonstersGYM.Infrastructure.Repository;
using MonstersGYM.Core.PocoClasses;

namespace MonstersGYM
{
    public partial class CardExchangeUserControl : UserControl
    {
        IMemberProfile MemberProfile = new MemberProfileRepo();
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        ICards Cards = new CardsRepo();
        IIncome Income = new IncomeRepo();
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        long memberId = -1;
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        public CardExchangeUserControl()
        {
            InitializeComponent();
        }

        private void NamesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NamesTextBox.Text != string.Empty)
            {
                string errorMsg;

                byte[] pic = MemberProfile.GetMemberProfile(NamesTextBox.Text, out errorMsg);
                loadPicture(pic);
                string name = NamesTextBox.Text;
                memberId = MemberProfile.GetMemberId(name, out errorMsg);
                long CardId = RegisteredCard.GetCardID(memberId, out errorMsg);
                int CardHeaderId = Cards.getCardHeaderID(CardId, out errorMsg);

                string cardName = CardDefinition.GetCardName(CardHeaderId, out errorMsg);
                string CardBarcode = Cards.GetCardBarcode(CardId, out errorMsg);

                OldBarcodeLabel.Text = CardBarcode;
                CardTypeLabel.Text = cardName;
            }
        }
        void loadPicture(byte[] PicFromDb)
        {
            if (PicFromDb != null)
            {
                MemoryStream mem = new MemoryStream(PicFromDb);
                pictureBox1.Image = Image.FromStream(mem);
            }
            else
                pictureBox1.Image = null;
        }

        private void CardExchangeUserControl_Load(object sender, EventArgs e)
        {
            string errorMsg;
            List<string> Names = MemberProfile.GetAllMembersNames(out errorMsg);
            foreach (var name in Names)
            {
                long memberId = MemberProfile.GetMemberId(name, out errorMsg);
                if (RegisteredCard.IsMemberCurrentActive(memberId, out errorMsg))
                    coll.Add(name);
            }
            NamesTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NamesTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NamesTextBox.AutoCompleteCustomSource = coll;
        }

        private void ScannedBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            string errorMsg = "";
            int CardHeaderId = Cards.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
            int price = CardDefinition.GetCardPrice(CardHeaderId, out errorMsg);
            PriceTextBox.Text = price.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (OldBarcodeLabel.Text == ScannedBarcodeTextBox.Text)
            {
                MessageBox.Show("same card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long cardId = Cards.GetCardId(ScannedBarcodeTextBox.Text, out errorMsg);
            if (RegisteredCard.IsRegistered(cardId, out errorMsg))
            {
                MessageBox.Show("Card registered before", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cardHeaderId = Cards.getCardHeaderID(ScannedBarcodeTextBox.Text, out errorMsg);
            string NewCardName = CardDefinition.GetCardName(cardHeaderId, out errorMsg);
            if (NewCardName != CardTypeLabel.Text)
            {
                MessageBox.Show("select same card type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime endDate = RegisteredCard.GetEndDate(memberId, out errorMsg);
            int duration = 0;
            double durationInMonths = Math.Ceiling((double)((endDate - DateTime.Now).Days / 30));

            if (durationInMonths <= 1)
                duration = 1;
            else if (durationInMonths <= 3)
                duration = 3;
            else if (durationInMonths <= 6)
                duration = 6;
            else if (durationInMonths <= 9)
                duration = 9;
            else if (durationInMonths <= 12)
                duration = 12;

            bool success = RegisteredCard.UpdateOldAndInsertNew(memberId, cardId, out errorMsg);
            success = Cards.RegisterCard(ScannedBarcodeTextBox.Text, out errorMsg);
            success = Income.InsertNewIncome(memberId, User.CurrentUser.ID, cardId, duration, 10, out errorMsg);

            if (success)
            {
                ScannedBarcodeTextBox.Text = "";
                PriceTextBox.Text = "0";
                OldBarcodeLabel.Text = "00";
                CardTypeLabel.Text = "00";
                NamesTextBox.Text = "";
                MessageBox.Show("updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}