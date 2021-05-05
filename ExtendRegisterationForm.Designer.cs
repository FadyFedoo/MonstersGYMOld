namespace MonstersGYM
{
    partial class ExtendRegisterationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtendRegisterationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NamesTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OldBarcodeLabel = new System.Windows.Forms.Label();
            this.UseSameCardRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ScanBarcodeButton = new System.Windows.Forms.Button();
            this.ScannedBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.RecievOldCardCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "أسم المشترك";
            // 
            // NamesTextBox
            // 
            this.NamesTextBox.Location = new System.Drawing.Point(467, 60);
            this.NamesTextBox.Name = "NamesTextBox";
            this.NamesTextBox.Size = new System.Drawing.Size(200, 20);
            this.NamesTextBox.TabIndex = 1;
            this.NamesTextBox.TextChanged += new System.EventHandler(this.NamesTextBox_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(833, 22);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "رجوع";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 176);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "رقم الباركود القديم";
            // 
            // OldBarcodeLabel
            // 
            this.OldBarcodeLabel.AutoSize = true;
            this.OldBarcodeLabel.Location = new System.Drawing.Point(533, 132);
            this.OldBarcodeLabel.Name = "OldBarcodeLabel";
            this.OldBarcodeLabel.Size = new System.Drawing.Size(19, 13);
            this.OldBarcodeLabel.TabIndex = 11;
            this.OldBarcodeLabel.Text = "00";
            // 
            // UseSameCardRadioButton
            // 
            this.UseSameCardRadioButton.AutoSize = true;
            this.UseSameCardRadioButton.Location = new System.Drawing.Point(25, 19);
            this.UseSameCardRadioButton.Name = "UseSameCardRadioButton";
            this.UseSameCardRadioButton.Size = new System.Drawing.Size(126, 17);
            this.UseSameCardRadioButton.TabIndex = 12;
            this.UseSameCardRadioButton.TabStop = true;
            this.UseSameCardRadioButton.Text = "استخدم الكارت القديم";
            this.UseSameCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(304, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "كارت جديد";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // ScanBarcodeButton
            // 
            this.ScanBarcodeButton.Location = new System.Drawing.Point(643, 319);
            this.ScanBarcodeButton.Name = "ScanBarcodeButton";
            this.ScanBarcodeButton.Size = new System.Drawing.Size(75, 23);
            this.ScanBarcodeButton.TabIndex = 16;
            this.ScanBarcodeButton.Text = "مسح الباركود";
            this.ScanBarcodeButton.UseVisualStyleBackColor = true;
            // 
            // ScannedBarcodeTextBox
            // 
            this.ScannedBarcodeTextBox.Location = new System.Drawing.Point(754, 322);
            this.ScannedBarcodeTextBox.Name = "ScannedBarcodeTextBox";
            this.ScannedBarcodeTextBox.Size = new System.Drawing.Size(154, 20);
            this.ScannedBarcodeTextBox.TabIndex = 17;
            // 
            // RecievOldCardCheckBox
            // 
            this.RecievOldCardCheckBox.AutoSize = true;
            this.RecievOldCardCheckBox.Location = new System.Drawing.Point(739, 384);
            this.RecievOldCardCheckBox.Name = "RecievOldCardCheckBox";
            this.RecievOldCardCheckBox.Size = new System.Drawing.Size(122, 17);
            this.RecievOldCardCheckBox.TabIndex = 18;
            this.RecievOldCardCheckBox.Text = "استلام الكارت القديم";
            this.RecievOldCardCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(544, 439);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 35);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "حفظ";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UseSameCardRadioButton);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(467, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 56);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "المدة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "بداية الاشتراك";
            // 
            // ExtendRegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 697);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RecievOldCardCheckBox);
            this.Controls.Add(this.ScannedBarcodeTextBox);
            this.Controls.Add(this.ScanBarcodeButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OldBarcodeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NamesTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtendRegisterationForm";
            this.Text = "Monsters GYM";
            this.Load += new System.EventHandler(this.ExtendRegisterationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NamesTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OldBarcodeLabel;
        private System.Windows.Forms.RadioButton UseSameCardRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ScanBarcodeButton;
        private System.Windows.Forms.TextBox ScannedBarcodeTextBox;
        private System.Windows.Forms.CheckBox RecievOldCardCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}