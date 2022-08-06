namespace MonstersGYM
{
    partial class CardDefinitionUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddHeaderButton = new System.Windows.Forms.Button();
            this.CardPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CardNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.SessionPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSessionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.EditSessionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MonstersGYM.Properties.Resources.Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(478, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 205);
            this.panel1.TabIndex = 46;
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
            this.AddHeaderButton.Location = new System.Drawing.Point(941, 383);
            this.AddHeaderButton.Name = "AddHeaderButton";
            this.AddHeaderButton.Size = new System.Drawing.Size(78, 93);
            this.AddHeaderButton.TabIndex = 51;
            this.AddHeaderButton.Text = "إضافة";
            this.AddHeaderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddHeaderButton.UseVisualStyleBackColor = false;
            this.AddHeaderButton.Click += new System.EventHandler(this.AddHeaderButton_Click);
            // 
            // CardPriceNumericUpDown
            // 
            this.CardPriceNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPriceNumericUpDown.Location = new System.Drawing.Point(844, 333);
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
            this.CardPriceNumericUpDown.Size = new System.Drawing.Size(175, 31);
            this.CardPriceNumericUpDown.TabIndex = 50;
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
            this.label6.Location = new System.Drawing.Point(1072, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 30);
            this.label6.TabIndex = 49;
            this.label6.Text = "السعر";
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameTextBox.Location = new System.Drawing.Point(844, 278);
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.Size = new System.Drawing.Size(175, 31);
            this.CardNameTextBox.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1048, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "أسم الكارت";
            // 
            // SexComboBox
            // 
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "رجال",
            "سيدات",
            "زومبا&ايروبيكس"});
            this.SexComboBox.Location = new System.Drawing.Point(481, 278);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(175, 21);
            this.SexComboBox.TabIndex = 52;
            // 
            // SessionPriceNumericUpDown
            // 
            this.SessionPriceNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionPriceNumericUpDown.Location = new System.Drawing.Point(481, 331);
            this.SessionPriceNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.SessionPriceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SessionPriceNumericUpDown.Name = "SessionPriceNumericUpDown";
            this.SessionPriceNumericUpDown.Size = new System.Drawing.Size(175, 31);
            this.SessionPriceNumericUpDown.TabIndex = 54;
            this.SessionPriceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 53;
            this.label2.Text = "السعر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 30);
            this.label3.TabIndex = 55;
            this.label3.Text = "النوع";
            // 
            // AddSessionButton
            // 
            this.AddSessionButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddSessionButton.FlatAppearance.BorderSize = 0;
            this.AddSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSessionButton.ForeColor = System.Drawing.Color.Gold;
            this.AddSessionButton.Image = global::MonstersGYM.Properties.Resources.add;
            this.AddSessionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddSessionButton.Location = new System.Drawing.Point(562, 383);
            this.AddSessionButton.Name = "AddSessionButton";
            this.AddSessionButton.Size = new System.Drawing.Size(78, 93);
            this.AddSessionButton.TabIndex = 56;
            this.AddSessionButton.Text = "إضافة";
            this.AddSessionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddSessionButton.UseVisualStyleBackColor = false;
            this.AddSessionButton.Click += new System.EventHandler(this.AddSessionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(925, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 57;
            this.label4.Text = "بيانات الكارت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 30);
            this.label5.TabIndex = 58;
            this.label5.Text = "بيانات الحصة";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.GridColor = System.Drawing.Color.Gold;
            this.dataGridView1.Location = new System.Drawing.Point(32, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 231);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.GridColor = System.Drawing.Color.Gold;
            this.dataGridView2.Location = new System.Drawing.Point(32, 326);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(416, 150);
            this.dataGridView2.TabIndex = 60;
            // 
            // EditSessionButton
            // 
            this.EditSessionButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditSessionButton.FlatAppearance.BorderSize = 0;
            this.EditSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSessionButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSessionButton.ForeColor = System.Drawing.Color.Gold;
            this.EditSessionButton.Image = global::MonstersGYM.Properties.Resources.edit;
            this.EditSessionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditSessionButton.Location = new System.Drawing.Point(185, 494);
            this.EditSessionButton.Name = "EditSessionButton";
            this.EditSessionButton.Size = new System.Drawing.Size(78, 93);
            this.EditSessionButton.TabIndex = 62;
            this.EditSessionButton.Text = "تعديل";
            this.EditSessionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditSessionButton.UseVisualStyleBackColor = false;
            this.EditSessionButton.Click += new System.EventHandler(this.EditSessionButton_Click);
            // 
            // CardDefinitionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.EditSessionButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddSessionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SessionPriceNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.AddHeaderButton);
            this.Controls.Add(this.CardPriceNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CardNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "CardDefinitionUserControl";
            this.Size = new System.Drawing.Size(1163, 635);
            this.Load += new System.EventHandler(this.CardDefinitionUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddHeaderButton;
        private System.Windows.Forms.NumericUpDown CardPriceNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CardNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.NumericUpDown SessionPriceNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddSessionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button EditSessionButton;
    }
}
