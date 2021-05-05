namespace MonstersGYM
{
    partial class CardExchangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardExchangeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldBarcodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CardTypeLabel = new System.Windows.Forms.Label();
            this.ScannedBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.ScanBarcodeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NamesTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الأسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الباركود القديم";
            // 
            // OldBarcodeLabel
            // 
            this.OldBarcodeLabel.AutoSize = true;
            this.OldBarcodeLabel.Location = new System.Drawing.Point(662, 183);
            this.OldBarcodeLabel.Name = "OldBarcodeLabel";
            this.OldBarcodeLabel.Size = new System.Drawing.Size(19, 13);
            this.OldBarcodeLabel.TabIndex = 3;
            this.OldBarcodeLabel.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع الكارت القديم";
            // 
            // CardTypeLabel
            // 
            this.CardTypeLabel.AutoSize = true;
            this.CardTypeLabel.Location = new System.Drawing.Point(474, 183);
            this.CardTypeLabel.Name = "CardTypeLabel";
            this.CardTypeLabel.Size = new System.Drawing.Size(19, 13);
            this.CardTypeLabel.TabIndex = 5;
            this.CardTypeLabel.Text = "00";
            // 
            // ScannedBarcodeTextBox
            // 
            this.ScannedBarcodeTextBox.Location = new System.Drawing.Point(405, 264);
            this.ScannedBarcodeTextBox.Name = "ScannedBarcodeTextBox";
            this.ScannedBarcodeTextBox.Size = new System.Drawing.Size(190, 20);
            this.ScannedBarcodeTextBox.TabIndex = 6;
            this.ScannedBarcodeTextBox.TextChanged += new System.EventHandler(this.ScannedBarcodeTextBox_TextChanged);
            // 
            // ScanBarcodeButton
            // 
            this.ScanBarcodeButton.Location = new System.Drawing.Point(639, 261);
            this.ScanBarcodeButton.Name = "ScanBarcodeButton";
            this.ScanBarcodeButton.Size = new System.Drawing.Size(75, 23);
            this.ScanBarcodeButton.TabIndex = 7;
            this.ScanBarcodeButton.Text = "مسح الباركود";
            this.ScanBarcodeButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(487, 392);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(162, 31);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "حفظ";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "السعر";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Location = new System.Drawing.Point(405, 321);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(190, 20);
            this.PriceTextBox.TabIndex = 10;
            this.PriceTextBox.Text = "0";
            // 
            // NamesTextBox
            // 
            this.NamesTextBox.Location = new System.Drawing.Point(405, 59);
            this.NamesTextBox.Name = "NamesTextBox";
            this.NamesTextBox.Size = new System.Drawing.Size(190, 20);
            this.NamesTextBox.TabIndex = 11;
            this.NamesTextBox.TextChanged += new System.EventHandler(this.NamesTextBox_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(814, 31);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "رجوع";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CardExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 697);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NamesTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ScanBarcodeButton);
            this.Controls.Add(this.ScannedBarcodeTextBox);
            this.Controls.Add(this.CardTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OldBarcodeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardExchangeForm";
            this.Text = "Monsters GYM";
            this.Load += new System.EventHandler(this.CardExchangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OldBarcodeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CardTypeLabel;
        private System.Windows.Forms.TextBox ScannedBarcodeTextBox;
        private System.Windows.Forms.Button ScanBarcodeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox NamesTextBox;
        private System.Windows.Forms.Button BackButton;
    }
}