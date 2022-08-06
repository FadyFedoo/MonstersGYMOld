namespace MonstersGYM
{
    partial class ExtendRegisterationUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UseSameCardRadioButton = new System.Windows.Forms.RadioButton();
            this.UseNewCardRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RecievOldCardCheckBox = new System.Windows.Forms.CheckBox();
            this.ScannedBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.OldBarcodeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NamesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PromotionComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UseSameCardRadioButton);
            this.groupBox1.Controls.Add(this.UseNewCardRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(522, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 56);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // UseSameCardRadioButton
            // 
            this.UseSameCardRadioButton.AutoSize = true;
            this.UseSameCardRadioButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseSameCardRadioButton.Location = new System.Drawing.Point(25, 19);
            this.UseSameCardRadioButton.Name = "UseSameCardRadioButton";
            this.UseSameCardRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UseSameCardRadioButton.Size = new System.Drawing.Size(188, 34);
            this.UseSameCardRadioButton.TabIndex = 12;
            this.UseSameCardRadioButton.TabStop = true;
            this.UseSameCardRadioButton.Text = "استخدم الكارت القديم";
            this.UseSameCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // UseNewCardRadioButton
            // 
            this.UseNewCardRadioButton.AutoSize = true;
            this.UseNewCardRadioButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseNewCardRadioButton.Location = new System.Drawing.Point(465, 16);
            this.UseNewCardRadioButton.Name = "UseNewCardRadioButton";
            this.UseNewCardRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UseNewCardRadioButton.Size = new System.Drawing.Size(116, 34);
            this.UseNewCardRadioButton.TabIndex = 13;
            this.UseNewCardRadioButton.TabStop = true;
            this.UseNewCardRadioButton.Text = "كارت جديد";
            this.UseNewCardRadioButton.UseVisualStyleBackColor = true;
            this.UseNewCardRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Gold;
            this.SaveButton.Image = global::MonstersGYM.Properties.Resources.save;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(135, 559);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 68);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "حفظ";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RecievOldCardCheckBox
            // 
            this.RecievOldCardCheckBox.AutoSize = true;
            this.RecievOldCardCheckBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievOldCardCheckBox.Location = new System.Drawing.Point(930, 450);
            this.RecievOldCardCheckBox.Name = "RecievOldCardCheckBox";
            this.RecievOldCardCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RecievOldCardCheckBox.Size = new System.Drawing.Size(182, 34);
            this.RecievOldCardCheckBox.TabIndex = 35;
            this.RecievOldCardCheckBox.Text = "استلام الكارت القديم";
            this.RecievOldCardCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScannedBarcodeTextBox
            // 
            this.ScannedBarcodeTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScannedBarcodeTextBox.Location = new System.Drawing.Point(755, 406);
            this.ScannedBarcodeTextBox.Name = "ScannedBarcodeTextBox";
            this.ScannedBarcodeTextBox.Size = new System.Drawing.Size(231, 31);
            this.ScannedBarcodeTextBox.TabIndex = 34;
            this.ScannedBarcodeTextBox.TextChanged += new System.EventHandler(this.ScannedBarcodeTextBox_TextChanged);
            // 
            // OldBarcodeLabel
            // 
            this.OldBarcodeLabel.AutoSize = true;
            this.OldBarcodeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldBarcodeLabel.Location = new System.Drawing.Point(594, 281);
            this.OldBarcodeLabel.Name = "OldBarcodeLabel";
            this.OldBarcodeLabel.Size = new System.Drawing.Size(39, 30);
            this.OldBarcodeLabel.TabIndex = 30;
            this.OldBarcodeLabel.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(980, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "رقم الباركود القديم";
            // 
            // NamesTextBox
            // 
            this.NamesTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamesTextBox.Location = new System.Drawing.Point(522, 229);
            this.NamesTextBox.Name = "NamesTextBox";
            this.NamesTextBox.Size = new System.Drawing.Size(340, 31);
            this.NamesTextBox.TabIndex = 26;
            this.NamesTextBox.TextChanged += new System.EventHandler(this.NamesTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1002, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "أسم المشترك";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 365);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MonstersGYM.Properties.Resources.Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(478, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 205);
            this.panel1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1033, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 41;
            this.label3.Text = "الباركود";
            // 
            // PromotionComboBox
            // 
            this.PromotionComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromotionComboBox.FormattingEnabled = true;
            this.PromotionComboBox.Location = new System.Drawing.Point(16, 384);
            this.PromotionComboBox.Name = "PromotionComboBox";
            this.PromotionComboBox.Size = new System.Drawing.Size(277, 30);
            this.PromotionComboBox.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 30);
            this.label8.TabIndex = 56;
            this.label8.Text = "العرض";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(996, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 30);
            this.label5.TabIndex = 61;
            this.label5.Text = "بداية الاشتراك";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1038, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 60;
            this.label4.Text = "المدة";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(527, 559);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 31);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.5",
            "1",
            "3",
            "6",
            "9",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(527, 504);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 30);
            this.comboBox1.TabIndex = 58;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExtendRegisterationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PromotionComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RecievOldCardCheckBox);
            this.Controls.Add(this.ScannedBarcodeTextBox);
            this.Controls.Add(this.OldBarcodeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NamesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ExtendRegisterationUserControl";
            this.Size = new System.Drawing.Size(1163, 635);
            this.Load += new System.EventHandler(this.ExtendRegisterationUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UseSameCardRadioButton;
        private System.Windows.Forms.RadioButton UseNewCardRadioButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox RecievOldCardCheckBox;
        private System.Windows.Forms.TextBox ScannedBarcodeTextBox;
        private System.Windows.Forms.Label OldBarcodeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NamesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PromotionComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
