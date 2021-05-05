namespace MonstersGYM
{
    partial class CollectIncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectIncomeForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SettleButton = new System.Windows.Forms.Button();
            this.TotalIncomeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(893, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "رجوع";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(659, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 448);
            this.dataGridView1.TabIndex = 2;
            // 
            // SettleButton
            // 
            this.SettleButton.Location = new System.Drawing.Point(685, 386);
            this.SettleButton.Name = "SettleButton";
            this.SettleButton.Size = new System.Drawing.Size(176, 61);
            this.SettleButton.TabIndex = 3;
            this.SettleButton.Text = "أستلام";
            this.SettleButton.UseVisualStyleBackColor = true;
            this.SettleButton.Click += new System.EventHandler(this.SettleButton_Click);
            // 
            // TotalIncomeTextBox
            // 
            this.TotalIncomeTextBox.Enabled = false;
            this.TotalIncomeTextBox.Location = new System.Drawing.Point(685, 342);
            this.TotalIncomeTextBox.Name = "TotalIncomeTextBox";
            this.TotalIncomeTextBox.Size = new System.Drawing.Size(176, 20);
            this.TotalIncomeTextBox.TabIndex = 4;
            // 
            // CollectIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 697);
            this.Controls.Add(this.TotalIncomeTextBox);
            this.Controls.Add(this.SettleButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CollectIncomeForm";
            this.Text = "Monsters GYM";
            this.Load += new System.EventHandler(this.CollectIncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SettleButton;
        private System.Windows.Forms.TextBox TotalIncomeTextBox;
    }
}