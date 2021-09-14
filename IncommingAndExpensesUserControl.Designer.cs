namespace MonstersGYM
{
    partial class IncommingAndExpensesUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomingTextBox = new System.Windows.Forms.TextBox();
            this.IncomingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IncomingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IncomingSaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ExpensesSaveButton = new System.Windows.Forms.Button();
            this.ExpensesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpensesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExpensesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IncomingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MonstersGYM.Properties.Resources.Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(478, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 205);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "المصروفات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(890, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "المدخلات";
            // 
            // IncomingTextBox
            // 
            this.IncomingTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingTextBox.Location = new System.Drawing.Point(677, 301);
            this.IncomingTextBox.Name = "IncomingTextBox";
            this.IncomingTextBox.Size = new System.Drawing.Size(260, 31);
            this.IncomingTextBox.TabIndex = 22;
            // 
            // IncomingNumericUpDown
            // 
            this.IncomingNumericUpDown.DecimalPlaces = 2;
            this.IncomingNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingNumericUpDown.Location = new System.Drawing.Point(758, 441);
            this.IncomingNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.IncomingNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IncomingNumericUpDown.Name = "IncomingNumericUpDown";
            this.IncomingNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.IncomingNumericUpDown.TabIndex = 23;
            this.IncomingNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IncomingDateTimePicker
            // 
            this.IncomingDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingDateTimePicker.Location = new System.Drawing.Point(677, 373);
            this.IncomingDateTimePicker.Name = "IncomingDateTimePicker";
            this.IncomingDateTimePicker.Size = new System.Drawing.Size(260, 26);
            this.IncomingDateTimePicker.TabIndex = 24;
            // 
            // IncomingSaveButton
            // 
            this.IncomingSaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IncomingSaveButton.FlatAppearance.BorderSize = 0;
            this.IncomingSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomingSaveButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingSaveButton.ForeColor = System.Drawing.Color.Gold;
            this.IncomingSaveButton.Image = global::MonstersGYM.Properties.Resources.save;
            this.IncomingSaveButton.Location = new System.Drawing.Point(786, 534);
            this.IncomingSaveButton.Name = "IncomingSaveButton";
            this.IncomingSaveButton.Size = new System.Drawing.Size(74, 64);
            this.IncomingSaveButton.TabIndex = 25;
            this.IncomingSaveButton.Text = "حفظ";
            this.IncomingSaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IncomingSaveButton.UseVisualStyleBackColor = false;
            this.IncomingSaveButton.Click += new System.EventHandler(this.IncomingSaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1022, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "الوصف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1051, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "اليوم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1043, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 33);
            this.label5.TabIndex = 28;
            this.label5.Text = "القيمة";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 33);
            this.label6.TabIndex = 35;
            this.label6.Text = "القيمة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 33);
            this.label7.TabIndex = 34;
            this.label7.Text = "اليوم";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 33);
            this.label8.TabIndex = 33;
            this.label8.Text = "الوصف";
            // 
            // ExpensesSaveButton
            // 
            this.ExpensesSaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExpensesSaveButton.FlatAppearance.BorderSize = 0;
            this.ExpensesSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpensesSaveButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesSaveButton.ForeColor = System.Drawing.Color.Gold;
            this.ExpensesSaveButton.Image = global::MonstersGYM.Properties.Resources.save;
            this.ExpensesSaveButton.Location = new System.Drawing.Point(147, 530);
            this.ExpensesSaveButton.Name = "ExpensesSaveButton";
            this.ExpensesSaveButton.Size = new System.Drawing.Size(74, 64);
            this.ExpensesSaveButton.TabIndex = 32;
            this.ExpensesSaveButton.Text = "حفظ";
            this.ExpensesSaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExpensesSaveButton.UseVisualStyleBackColor = false;
            this.ExpensesSaveButton.Click += new System.EventHandler(this.ExpensesSaveButton_Click);
            // 
            // ExpensesDateTimePicker
            // 
            this.ExpensesDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesDateTimePicker.Location = new System.Drawing.Point(38, 369);
            this.ExpensesDateTimePicker.Name = "ExpensesDateTimePicker";
            this.ExpensesDateTimePicker.Size = new System.Drawing.Size(260, 26);
            this.ExpensesDateTimePicker.TabIndex = 31;
            // 
            // ExpensesNumericUpDown
            // 
            this.ExpensesNumericUpDown.DecimalPlaces = 2;
            this.ExpensesNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesNumericUpDown.Location = new System.Drawing.Point(119, 437);
            this.ExpensesNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ExpensesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpensesNumericUpDown.Name = "ExpensesNumericUpDown";
            this.ExpensesNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.ExpensesNumericUpDown.TabIndex = 30;
            this.ExpensesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ExpensesTextBox
            // 
            this.ExpensesTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesTextBox.Location = new System.Drawing.Point(38, 297);
            this.ExpensesTextBox.Name = "ExpensesTextBox";
            this.ExpensesTextBox.Size = new System.Drawing.Size(260, 31);
            this.ExpensesTextBox.TabIndex = 29;
            // 
            // IncommingAndExpensesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExpensesSaveButton);
            this.Controls.Add(this.ExpensesDateTimePicker);
            this.Controls.Add(this.ExpensesNumericUpDown);
            this.Controls.Add(this.ExpensesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IncomingSaveButton);
            this.Controls.Add(this.IncomingDateTimePicker);
            this.Controls.Add(this.IncomingNumericUpDown);
            this.Controls.Add(this.IncomingTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "IncommingAndExpensesUserControl";
            this.Size = new System.Drawing.Size(1163, 635);
            ((System.ComponentModel.ISupportInitialize)(this.IncomingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IncomingTextBox;
        private System.Windows.Forms.NumericUpDown IncomingNumericUpDown;
        private System.Windows.Forms.DateTimePicker IncomingDateTimePicker;
        private System.Windows.Forms.Button IncomingSaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ExpensesSaveButton;
        private System.Windows.Forms.DateTimePicker ExpensesDateTimePicker;
        private System.Windows.Forms.NumericUpDown ExpensesNumericUpDown;
        private System.Windows.Forms.TextBox ExpensesTextBox;
    }
}
