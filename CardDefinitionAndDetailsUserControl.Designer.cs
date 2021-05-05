namespace MonstersGYM
{
    partial class CardDefinitionAndDetailsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EditButton = new System.Windows.Forms.Button();
            this.InvitationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.CardsNameComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CardPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FreezNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CardNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddDetailsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddHeaderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InvitationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreezNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.Gold;
            this.EditButton.Image = global::MonstersGYM.Properties.Resources.edit;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditButton.Location = new System.Drawing.Point(858, 535);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(78, 93);
            this.EditButton.TabIndex = 44;
            this.EditButton.Text = "تعديل";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // InvitationNumericUpDown
            // 
            this.InvitationNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvitationNumericUpDown.Location = new System.Drawing.Point(171, 476);
            this.InvitationNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.InvitationNumericUpDown.Name = "InvitationNumericUpDown";
            this.InvitationNumericUpDown.Size = new System.Drawing.Size(71, 31);
            this.InvitationNumericUpDown.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 30);
            this.label8.TabIndex = 42;
            this.label8.Text = "الدعوات";
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Location = new System.Drawing.Point(498, 478);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(107, 30);
            this.DurationComboBox.TabIndex = 40;
            // 
            // CardsNameComboBox
            // 
            this.CardsNameComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsNameComboBox.FormattingEnabled = true;
            this.CardsNameComboBox.Location = new System.Drawing.Point(633, 476);
            this.CardsNameComboBox.Name = "CardsNameComboBox";
            this.CardsNameComboBox.Size = new System.Drawing.Size(107, 30);
            this.CardsNameComboBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "نوع الكارت";
            // 
            // CardPriceNumericUpDown
            // 
            this.CardPriceNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPriceNumericUpDown.Location = new System.Drawing.Point(137, 161);
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
            this.CardPriceNumericUpDown.Size = new System.Drawing.Size(137, 31);
            this.CardPriceNumericUpDown.TabIndex = 36;
            this.CardPriceNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "السعر";
            // 
            // PersonalNumericUpDown
            // 
            this.PersonalNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalNumericUpDown.Location = new System.Drawing.Point(24, 475);
            this.PersonalNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.PersonalNumericUpDown.Name = "PersonalNumericUpDown";
            this.PersonalNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.PersonalNumericUpDown.TabIndex = 34;
            // 
            // FreezNumericUpDown
            // 
            this.FreezNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreezNumericUpDown.Location = new System.Drawing.Point(273, 477);
            this.FreezNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.FreezNumericUpDown.Name = "FreezNumericUpDown";
            this.FreezNumericUpDown.Size = new System.Drawing.Size(85, 31);
            this.FreezNumericUpDown.TabIndex = 33;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceNumericUpDown.Location = new System.Drawing.Point(399, 477);
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
            this.PriceNumericUpDown.Size = new System.Drawing.Size(64, 31);
            this.PriceNumericUpDown.TabIndex = 32;
            this.PriceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameTextBox.Location = new System.Drawing.Point(26, 114);
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.Size = new System.Drawing.Size(248, 31);
            this.CardNameTextBox.TabIndex = 31;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Gold;
            this.DeleteButton.Image = global::MonstersGYM.Properties.Resources.Delete;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteButton.Location = new System.Drawing.Point(1035, 535);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 93);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "مسح";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddDetailsButton
            // 
            this.AddDetailsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddDetailsButton.FlatAppearance.BorderSize = 0;
            this.AddDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDetailsButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDetailsButton.ForeColor = System.Drawing.Color.Gold;
            this.AddDetailsButton.Image = global::MonstersGYM.Properties.Resources.add;
            this.AddDetailsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddDetailsButton.Location = new System.Drawing.Point(335, 528);
            this.AddDetailsButton.Name = "AddDetailsButton";
            this.AddDetailsButton.Size = new System.Drawing.Size(78, 93);
            this.AddDetailsButton.TabIndex = 29;
            this.AddDetailsButton.Text = "إضافة";
            this.AddDetailsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddDetailsButton.UseVisualStyleBackColor = false;
            this.AddDetailsButton.Click += new System.EventHandler(this.AddDetailsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Gold;
            this.dataGridView1.Location = new System.Drawing.Point(746, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 381);
            this.dataGridView1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "المدة(بالشهر)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "السعر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "تجميد(باليوم)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "مدرب شخصى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "أسم الكارت";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MonstersGYM.Properties.Resources.Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(478, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 205);
            this.panel1.TabIndex = 45;
            // 
            // AddHeaderButton
            // 
            this.AddHeaderButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddHeaderButton.FlatAppearance.BorderSize = 0;
            this.AddHeaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHeaderButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHeaderButton.ForeColor = System.Drawing.Color.Gold;
            this.AddHeaderButton.Image = global::MonstersGYM.Properties.Resources.add;
            this.AddHeaderButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddHeaderButton.Location = new System.Drawing.Point(164, 214);
            this.AddHeaderButton.Name = "AddHeaderButton";
            this.AddHeaderButton.Size = new System.Drawing.Size(78, 93);
            this.AddHeaderButton.TabIndex = 39;
            this.AddHeaderButton.Text = "إضافة";
            this.AddHeaderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddHeaderButton.UseVisualStyleBackColor = false;
            this.AddHeaderButton.Click += new System.EventHandler(this.AddHeaderButton_Click);
            // 
            // CardDefinitionAndDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.InvitationNumericUpDown);
            this.Controls.Add(this.label8);
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
            this.Name = "CardDefinitionAndDetailsUserControl";
            this.Size = new System.Drawing.Size(1163, 635);
            this.Load += new System.EventHandler(this.CardDefinitionAndDetailsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvitationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreezNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.NumericUpDown InvitationNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.Button AddHeaderButton;
        private System.Windows.Forms.ComboBox CardsNameComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CardPriceNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PersonalNumericUpDown;
        private System.Windows.Forms.NumericUpDown FreezNumericUpDown;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.TextBox CardNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddDetailsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
