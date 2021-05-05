namespace MonstersGYM
{
    partial class CardDefinitionAndDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDefinitionAndDetailsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddDetailsButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CardNameTextBox = new System.Windows.Forms.TextBox();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FreezNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PersonalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CardPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CardsNameComboBox = new System.Windows.Forms.ComboBox();
            this.AddHeaderButton = new System.Windows.Forms.Button();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.InvitationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreezNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvitationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "أسم الكارت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "مدرب شخصى";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تجميد(باليوم)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "السعر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "المدة(بالشهر)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 381);
            this.dataGridView1.TabIndex = 5;
            // 
            // AddDetailsButton
            // 
            this.AddDetailsButton.Location = new System.Drawing.Point(86, 385);
            this.AddDetailsButton.Name = "AddDetailsButton";
            this.AddDetailsButton.Size = new System.Drawing.Size(194, 36);
            this.AddDetailsButton.TabIndex = 6;
            this.AddDetailsButton.Text = "إضافة";
            this.AddDetailsButton.UseVisualStyleBackColor = true;
            this.AddDetailsButton.Click += new System.EventHandler(this.AddDetailsButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(682, 399);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(82, 56);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "مسح";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.Location = new System.Drawing.Point(49, 49);
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.CardNameTextBox.TabIndex = 8;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Location = new System.Drawing.Point(281, 299);
            this.PriceNumericUpDown.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.PriceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.PriceNumericUpDown.TabIndex = 9;
            this.PriceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FreezNumericUpDown
            // 
            this.FreezNumericUpDown.Location = new System.Drawing.Point(193, 299);
            this.FreezNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.FreezNumericUpDown.Name = "FreezNumericUpDown";
            this.FreezNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.FreezNumericUpDown.TabIndex = 11;
            // 
            // PersonalNumericUpDown
            // 
            this.PersonalNumericUpDown.Location = new System.Drawing.Point(12, 301);
            this.PersonalNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.PersonalNumericUpDown.Name = "PersonalNumericUpDown";
            this.PersonalNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.PersonalNumericUpDown.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "السعر";
            // 
            // CardPriceNumericUpDown
            // 
            this.CardPriceNumericUpDown.Location = new System.Drawing.Point(160, 104);
            this.CardPriceNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CardPriceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CardPriceNumericUpDown.Name = "CardPriceNumericUpDown";
            this.CardPriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CardPriceNumericUpDown.TabIndex = 14;
            this.CardPriceNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "نوع الكارت";
            // 
            // CardsNameComboBox
            // 
            this.CardsNameComboBox.FormattingEnabled = true;
            this.CardsNameComboBox.Location = new System.Drawing.Point(451, 300);
            this.CardsNameComboBox.Name = "CardsNameComboBox";
            this.CardsNameComboBox.Size = new System.Drawing.Size(93, 21);
            this.CardsNameComboBox.TabIndex = 16;
            // 
            // AddHeaderButton
            // 
            this.AddHeaderButton.Location = new System.Drawing.Point(86, 157);
            this.AddHeaderButton.Name = "AddHeaderButton";
            this.AddHeaderButton.Size = new System.Drawing.Size(194, 36);
            this.AddHeaderButton.TabIndex = 17;
            this.AddHeaderButton.Text = "إضافة";
            this.AddHeaderButton.UseVisualStyleBackColor = true;
            this.AddHeaderButton.Click += new System.EventHandler(this.AddHeaderButton_Click);
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Location = new System.Drawing.Point(362, 299);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(68, 21);
            this.DurationComboBox.TabIndex = 18;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(804, 416);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "رجوع";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "الدعوات";
            // 
            // InvitationNumericUpDown
            // 
            this.InvitationNumericUpDown.Location = new System.Drawing.Point(114, 300);
            this.InvitationNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.InvitationNumericUpDown.Name = "InvitationNumericUpDown";
            this.InvitationNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.InvitationNumericUpDown.TabIndex = 21;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(566, 399);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(82, 56);
            this.EditButton.TabIndex = 22;
            this.EditButton.Text = "تعديل";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CardDefinitionAndDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 697);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.InvitationNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DurationComboBox);
            this.Controls.Add(this.AddHeaderButton);
            this.Controls.Add(this.CardsNameComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CardPriceNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PersonalNumericUpDown);
            this.Controls.Add(this.FreezNumericUpDown);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.CardNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddDetailsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardDefinitionAndDetailsForm";
            this.Text = "Monsters GYM";
            this.Load += new System.EventHandler(this.CardDefinitionAndDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreezNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvitationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddDetailsButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox CardNameTextBox;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown FreezNumericUpDown;
        private System.Windows.Forms.NumericUpDown PersonalNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CardPriceNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CardsNameComboBox;
        private System.Windows.Forms.Button AddHeaderButton;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown InvitationNumericUpDown;
        private System.Windows.Forms.Button EditButton;
    }
}