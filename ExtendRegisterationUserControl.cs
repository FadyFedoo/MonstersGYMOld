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
        int TotalPrice = 0;

        public ExtendRegisterationUserControl()
        {
            InitializeComponent();
        }

        private void ExtendRegisterationUserControl_Load(object sender, EventArgs e)
        {

            //LoadAllMembers();
            radioButton2.Checked = true;

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("12");
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
            long cardId = RegisteredCard.GetLastCardID(memberId, out errorMsg);
            OldBarcodeLabel.Text = Cards.GetCardBarcode(cardId, out errorMsg);
            bool isActive = RegisteredCard.IsMemberCurrentActive(memberId, out errorMsg);
            if (isActive)
            {
                radioButton2.Enabled = false;
                UseSameCardRadioButton.Checked = true;
            }
            else
                radioButton2.Enabled = true;

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
            if (!radioButton2.Checked)
            {
                ScannedBarcodeTextBox.Enabled = false;
                RecievOldCardCheckBox.Enabled = false;
            }
            else
            {
                ScannedBarcodeTextBox.Enabled = true;
                RecievOldCardCheckBox.Enabled = true;
            }
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
            {
                usedCardBarcode = OldBarcodeLabel.Text;
                cardId = Cards.GetCardId(usedCardBarcode, out errorMsg);
                int cardHeaderID = Cards.getCardHeaderID(cardId, out errorMsg);
                TotalPrice = CardDetails.GetPrice(cardHeaderID, int.Parse(comboBox1.SelectedItem.ToString()), out errorMsg);
            }
            else
            {
                usedCardBarcode = ScannedBarcodeTextBox.Text;

                int cardHeaderID = Cards.getCardHeaderID(usedCardBarcode, out errorMsg);
                cardId = Cards.GetCardId(usedCardBarcode, out errorMsg);
                TotalPrice = CardDefinition.GetCardPrice(cardHeaderID, out errorMsg);
                TotalPrice += CardDetails.GetPrice(cardHeaderID, int.Parse(comboBox1.SelectedItem.ToString()), out errorMsg);
                if (RecievOldCardCheckBox.Checked)
                {
                    int oldCardHeaderId = Cards.getCardHeaderID(OldBarcodeLabel.Text, out errorMsg);
                    int oldCardPrice = CardDefinition.GetCardPrice(oldCardHeaderId, out errorMsg);
                    TotalPrice -= oldCardPrice;
                }
            }
            if (TotalPrice <= 0)
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
            DialogResult result = MessageBox.Show("السعر : " + TotalPrice.ToString(), "هل تريد الأستمرار ؟", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;
            else
            {
                long memberId = MemberProfile.GetMemberId(NamesTextBox.Text, out errorMsg);
                int cardHeaderID = Cards.getCardHeaderID(usedCardBarcode, out errorMsg);
                long cardDetails = CardDetails.GetCardDetailesID(cardHeaderID, int.Parse(comboBox1.SelectedItem.ToString()), out errorMsg);
                int totalFreez = CardDetails.GetTotalFreez(cardDetails, out errorMsg);
                int totalInvitation = CardDetails.GetTotalInvitation(cardDetails, out errorMsg);
                int totalPersonal = CardDetails.GetTotalPersonal(cardDetails, out errorMsg);

                bool success = RegisteredCard.InsertNewRegisteredCard(memberId, cardId, cardDetails, 0, 0, 0, totalFreez, totalPersonal, totalInvitation
                    , dateTimePicker1.Value, dateTimePicker1.Value.AddMonths(int.Parse(comboBox1.SelectedItem.ToString()))
                    , out errorMsg);

                long registeredCardId = RegisteredCard.GetCardID(memberId, out errorMsg);
                success = Income.InsertNewIncome(memberId, User.CurrentUser.ID, registeredCardId, int.Parse(comboBox1.SelectedItem.ToString()), TotalPrice, out errorMsg);
                if (!UseSameCardRadioButton.Checked)
                {
                    Cards.RegisterCard(ScannedBarcodeTextBox.Text, out errorMsg);
                    if (RecievOldCardCheckBox.Checked)
                        Cards.UnRegisterCard(OldBarcodeLabel.Text, out errorMsg);
                }
                if (!success)
                    MessageBox.Show(errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("تم تجديد الأشتراك بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
