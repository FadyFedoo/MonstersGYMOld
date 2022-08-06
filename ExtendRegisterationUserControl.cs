using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MonstersGYM.Infrastructure.Repository;
using MonstersGYM.Core.Interface;
using MonstersGYM.Core.PocoClasses;

namespace MonstersGYM
{
    public partial class ExtendRegisterationUserControl : UserControl
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        IMemberProfile MemberProfile = new MemberProfileRepo();
        IRegisteredCard RegisteredCard = new RegisteredCardRepo();
        ICards Cards = new CardsRepo();
        ICardDetails CardDetails = new CardDetailsRepo();
        ICardDefinition CardDefinition = new CardDefinitionRepo();
        IIncome Income = new IncomeRepo();
        IPromotion Promotion = new PromotionRepo();
        List<Promotions> promotions;

        int TotalPrice = 0;

        public ExtendRegisterationUserControl()
        {
            InitializeComponent();
        }

        private void ExtendRegisterationUserControl_Load(object sender, EventArgs e)
        {

            //LoadAllMembers();
            UseNewCardRadioButton.Checked = true;
        }
        public void LoadAllMembers()
        {
            string errorMsg = "";
            List<string> Names = MemberProfile.GetAllMembersNames(out errorMsg);
            foreach (var name in Names)
            {
                //long memberId = MemberProfile.GetMemberId(name, out errorMsg);
                if (/*!RegisteredCard.IsMemberCurrentActive(memberId, out errorMsg) &&*/ !coll.Contains(name))
                    coll.Add(name);
            }
            NamesTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            NamesTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NamesTextBox.AutoCompleteCustomSource = coll;
        }
        private void NamesTextBox_TextChanged(object sender, EventArgs e)
        {
            string errorMsg = "";
            byte[] PicFromDb = MemberProfile.GetMemberProfile(NamesTextBox.Text, out errorMsg);
            loadPicture(PicFromDb);
            long memberId = MemberProfile.GetMemberId(NamesTextBox.Text, out errorMsg);
            long cardId = RegisteredCard.GetCardID(memberId, out errorMsg);
            OldBarcodeLabel.Text = Cards.GetCardBarcode(cardId, out errorMsg);
            UseSameCardRadioButton.Checked = true;

            //bool isActive = RegisteredCard.IsMemberCurrentActive(memberId, out errorMsg);
            //if (isActive)
            //{
            //    radioButton2.Enabled = false;
            //    UseSameCardRadioButton.Checked = true;
            //}
            //else
            //    radioButton2.Enabled = true;

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!UseNewCardRadioButton.Checked)
            {
                ScannedBarcodeTextBox.Enabled = false;
                RecievOldCardCheckBox.Enabled = false;
            }
            else
            {
                ScannedBarcodeTextBox.Enabled = true;
                RecievOldCardCheckBox.Enabled = true;
            }

            comboBox1.SelectedItem = null;
        }
        public void LoadAllActivePromo(int CardHeaderID,decimal duration)
        {
            PromotionComboBox.Items.Clear();
            string errorMsg = "";
            promotions = Promotion.GetAllActivePromotionByID(CardHeaderID.ToString(),duration.ToString(), out errorMsg);
            if (!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (promotions.Count > 0)
            {
                PromotionComboBox.Enabled = true;
                foreach (var promo in promotions)
                {
                    PromotionComboBox.Items.Add(promo.Name);
                }
            }
            else
                PromotionComboBox.Enabled = false;

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("إختر المدة أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (OldBarcodeLabel.Text.Trim() == ScannedBarcodeTextBox.Text.Trim())
            {
                UseSameCardRadioButton.Checked = true;
            }
            string errorMsg = "";
            long cardId = -1;
            string usedCardBarcode = "";

            if (UseSameCardRadioButton.Checked)
                usedCardBarcode = OldBarcodeLabel.Text;
            else
                usedCardBarcode = ScannedBarcodeTextBox.Text;

            cardId = Cards.GetCardId(usedCardBarcode, out errorMsg);
            int cardHeaderID = Cards.getCardHeaderID(cardId, out errorMsg);
            TotalPrice = CardDetails.GetPrice(cardHeaderID, decimal.Parse(comboBox1.SelectedItem.ToString()), out errorMsg);
            
            int originalAmount;
            int amount = originalAmount = TotalPrice;
            long PromoId = -1;
            if (PromotionComboBox.SelectedItem != null)
            {
                var promoName = PromotionComboBox.SelectedItem.ToString().Trim();
                var selectedPromo = promotions.FirstOrDefault(x => x.Name == promoName);
                var value = selectedPromo.Value;
                PromoId = selectedPromo.Id;
                int discount = (amount * value / 100);
                amount = amount - discount;
            }

            //apply promotion on memberShip amount only
            amount = UseNewCardRadioButton.Checked ? (amount + CardDefinition.GetCardPrice(cardHeaderID, out errorMsg))
                : UseSameCardRadioButton.Checked ? amount : 0;

            if (RecievOldCardCheckBox.Checked && UseNewCardRadioButton.Checked)
            {
                int oldCardHeaderId = Cards.getCardHeaderID(OldBarcodeLabel.Text, out errorMsg);
                int oldCardPrice = CardDefinition.GetCardPrice(oldCardHeaderId, out errorMsg);
                amount -= oldCardPrice;
            }

            if (originalAmount <= 0 || amount < 0)
            {
                MessageBox.Show("لا يمكن تجديد الأشتراك العضو غير مسجل من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool active = Cards.IsCardOut(usedCardBarcode, out errorMsg);
            if (active && !UseSameCardRadioButton.Checked)
            {
                MessageBox.Show("تم مسح كارت مستخدم من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            DialogResult result = MessageBox.Show("السعر : " + amount.ToString(), "هل تريد الأستمرار ؟", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                long memberId = MemberProfile.GetMemberId(NamesTextBox.Text, out errorMsg);
                long cardDetails = CardDetails.GetCardDetailesID(cardHeaderID, decimal.Parse(comboBox1.SelectedItem.ToString()), out errorMsg);
                int totalFreez = CardDetails.GetTotalFreez(cardDetails, out errorMsg);
                int totalInvitation = CardDetails.GetTotalInvitation(cardDetails, out errorMsg);
                int totalClasses = CardDetails.GetTotalClasses(cardDetails, out errorMsg);
                int totalPersonal = CardDetails.GetTotalPersonal(cardDetails, out errorMsg);
                DateTime endDate = dateTimePicker1.Value;
                if (comboBox1.SelectedItem.ToString() == "0.5")
                    endDate = endDate.AddDays(15);
                else
                    endDate = endDate.AddMonths(int.Parse(comboBox1.SelectedItem.ToString()));


                bool success = RegisteredCard.InsertNewRegisteredCard(memberId, cardId, cardDetails, 0, 0, 0,0, totalFreez, totalPersonal, totalInvitation, totalClasses
                    , dateTimePicker1.Value, endDate
                    , out errorMsg);
                if (success)
                {
                    long registeredCardId = RegisteredCard.GetCardID(memberId, out errorMsg);
                    success = Income.InsertNewIncome(memberId, User.CurrentUser.ID, registeredCardId, decimal.Parse(comboBox1.SelectedItem.ToString()), 
                        amount,originalAmount, PromoId, out errorMsg);

                    if (!UseSameCardRadioButton.Checked)
                    {
                        Cards.RegisterCard(ScannedBarcodeTextBox.Text, out errorMsg);
                        if (RecievOldCardCheckBox.Checked)
                            Cards.UnRegisterCard(OldBarcodeLabel.Text, out errorMsg);
                    }
                }
                if (!success)
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("تم تجديد الأشتراك بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string errorMsg = "";
                string usedCardBarcode;
                if (UseSameCardRadioButton.Checked)
                    usedCardBarcode = OldBarcodeLabel.Text;
                else
                    usedCardBarcode = ScannedBarcodeTextBox.Text;

                var cardId = Cards.GetCardId(usedCardBarcode, out errorMsg);
                int cardHeaderID = Cards.getCardHeaderID(cardId, out errorMsg);

                LoadAllActivePromo(cardHeaderID, decimal.Parse(comboBox1.SelectedItem.ToString()));
            }
            else
            {
                PromotionComboBox.Items.Clear();
                PromotionComboBox.Enabled = false;
            }
        }

        private void ScannedBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
        }
    }
}
