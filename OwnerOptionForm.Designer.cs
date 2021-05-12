namespace MonstersGYM
{
    partial class OwnerOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerOptionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CardRegisterationButton = new System.Windows.Forms.Button();
            this.ChangeInfoButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.AddTrainerButton = new System.Windows.Forms.Button();
            this.NewCardButton = new System.Windows.Forms.Button();
            this.SettlementButton = new System.Windows.Forms.Button();
            this.NewAccountButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.homeUserControl1 = new MonstersGYM.HomeUserControl();
            this.addCardsUserControl1 = new MonstersGYM.AddCardsUserControl();
            this.addTrainerUserControl1 = new MonstersGYM.AddTrainerUserControl();
            this.cardDefinitionAndDetailsUserControl1 = new MonstersGYM.CardDefinitionAndDetailsUserControl();
            this.collectIncomeUserControl1 = new MonstersGYM.CollectIncomeUserControl();
            this.newAccountUserControl1 = new MonstersGYM.NewAccountUserControl();
            this.reportsMainUserControl1 = new MonstersGYM.ReportsMainUserControl();
            this.changeInfoUserControl1 = new MonstersGYM.ChangeInfoUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.CardRegisterationButton);
            this.panel1.Controls.Add(this.ChangeInfoButton);
            this.panel1.Controls.Add(this.ReportsButton);
            this.panel1.Controls.Add(this.AddTrainerButton);
            this.panel1.Controls.Add(this.NewCardButton);
            this.panel1.Controls.Add(this.SettlementButton);
            this.panel1.Controls.Add(this.NewAccountButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 697);
            this.panel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(3, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 69);
            this.panel4.TabIndex = 12;
            // 
            // CardRegisterationButton
            // 
            this.CardRegisterationButton.FlatAppearance.BorderSize = 0;
            this.CardRegisterationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardRegisterationButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardRegisterationButton.Image = global::MonstersGYM.Properties.Resources.RegisterCards;
            this.CardRegisterationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CardRegisterationButton.Location = new System.Drawing.Point(20, 610);
            this.CardRegisterationButton.Name = "CardRegisterationButton";
            this.CardRegisterationButton.Size = new System.Drawing.Size(178, 69);
            this.CardRegisterationButton.TabIndex = 3;
            this.CardRegisterationButton.Text = "تسجيل كارت";
            this.CardRegisterationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CardRegisterationButton.UseVisualStyleBackColor = true;
            this.CardRegisterationButton.Click += new System.EventHandler(this.CardRegisterationButton_Click);
            // 
            // ChangeInfoButton
            // 
            this.ChangeInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeInfoButton.FlatAppearance.BorderSize = 0;
            this.ChangeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeInfoButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeInfoButton.Image = global::MonstersGYM.Properties.Resources.ChangeInfo3;
            this.ChangeInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeInfoButton.Location = new System.Drawing.Point(20, 3);
            this.ChangeInfoButton.Name = "ChangeInfoButton";
            this.ChangeInfoButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangeInfoButton.Size = new System.Drawing.Size(178, 69);
            this.ChangeInfoButton.TabIndex = 6;
            this.ChangeInfoButton.Text = "تغيير البيانات";
            this.ChangeInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeInfoButton.UseVisualStyleBackColor = true;
            this.ChangeInfoButton.Click += new System.EventHandler(this.ChangeInfoButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.FlatAppearance.BorderSize = 0;
            this.ReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.Image = global::MonstersGYM.Properties.Resources.Reporst;
            this.ReportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsButton.Location = new System.Drawing.Point(20, 194);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(178, 69);
            this.ReportsButton.TabIndex = 4;
            this.ReportsButton.Text = "التقارير";
            this.ReportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // AddTrainerButton
            // 
            this.AddTrainerButton.FlatAppearance.BorderSize = 0;
            this.AddTrainerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTrainerButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTrainerButton.Image = global::MonstersGYM.Properties.Resources.Trainer31;
            this.AddTrainerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTrainerButton.Location = new System.Drawing.Point(20, 402);
            this.AddTrainerButton.Name = "AddTrainerButton";
            this.AddTrainerButton.Size = new System.Drawing.Size(178, 69);
            this.AddTrainerButton.TabIndex = 7;
            this.AddTrainerButton.Text = "إضافة مدرب";
            this.AddTrainerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddTrainerButton.UseVisualStyleBackColor = true;
            this.AddTrainerButton.Click += new System.EventHandler(this.AddTrainerButton_Click);
            // 
            // NewCardButton
            // 
            this.NewCardButton.FlatAppearance.BorderSize = 0;
            this.NewCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCardButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCardButton.Image = global::MonstersGYM.Properties.Resources.addCard21;
            this.NewCardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewCardButton.Location = new System.Drawing.Point(20, 506);
            this.NewCardButton.Name = "NewCardButton";
            this.NewCardButton.Size = new System.Drawing.Size(178, 69);
            this.NewCardButton.TabIndex = 0;
            this.NewCardButton.Text = " كارت جديد";
            this.NewCardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewCardButton.UseVisualStyleBackColor = true;
            this.NewCardButton.Click += new System.EventHandler(this.NewCardButton_Click);
            // 
            // SettlementButton
            // 
            this.SettlementButton.FlatAppearance.BorderSize = 0;
            this.SettlementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettlementButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettlementButton.Image = global::MonstersGYM.Properties.Resources.CollectIncome;
            this.SettlementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettlementButton.Location = new System.Drawing.Point(20, 90);
            this.SettlementButton.Name = "SettlementButton";
            this.SettlementButton.Size = new System.Drawing.Size(178, 69);
            this.SettlementButton.TabIndex = 2;
            this.SettlementButton.Text = "تحصيل مالي";
            this.SettlementButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettlementButton.UseVisualStyleBackColor = true;
            this.SettlementButton.Click += new System.EventHandler(this.SettlementButton_Click);
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.FlatAppearance.BorderSize = 0;
            this.NewAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewAccountButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccountButton.Image = global::MonstersGYM.Properties.Resources.NewAccount;
            this.NewAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewAccountButton.Location = new System.Drawing.Point(20, 298);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(178, 69);
            this.NewAccountButton.TabIndex = 1;
            this.NewAccountButton.Text = " حساب جديد";
            this.NewAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewAccountButton.UseVisualStyleBackColor = true;
            this.NewAccountButton.Click += new System.EventHandler(this.NewAccountButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 60);
            this.panel2.TabIndex = 9;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Image = global::MonstersGYM.Properties.Resources.Back1;
            this.HomeButton.Location = new System.Drawing.Point(1012, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 57);
            this.HomeButton.TabIndex = 13;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = global::MonstersGYM.Properties.Resources.Exit1;
            this.BackButton.Location = new System.Drawing.Point(1093, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 56);
            this.BackButton.TabIndex = 5;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(202, 61);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.homeUserControl1.TabIndex = 10;
            // 
            // addCardsUserControl1
            // 
            this.addCardsUserControl1.Location = new System.Drawing.Point(201, 61);
            this.addCardsUserControl1.Name = "addCardsUserControl1";
            this.addCardsUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.addCardsUserControl1.TabIndex = 11;
            this.addCardsUserControl1.Enter += new System.EventHandler(this.addCardsUserControl1_Enter);
            // 
            // addTrainerUserControl1
            // 
            this.addTrainerUserControl1.Location = new System.Drawing.Point(200, 99);
            this.addTrainerUserControl1.Name = "addTrainerUserControl1";
            this.addTrainerUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.addTrainerUserControl1.TabIndex = 12;
            // 
            // cardDefinitionAndDetailsUserControl1
            // 
            this.cardDefinitionAndDetailsUserControl1.Location = new System.Drawing.Point(200, 61);
            this.cardDefinitionAndDetailsUserControl1.Name = "cardDefinitionAndDetailsUserControl1";
            this.cardDefinitionAndDetailsUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.cardDefinitionAndDetailsUserControl1.TabIndex = 13;
            // 
            // collectIncomeUserControl1
            // 
            this.collectIncomeUserControl1.Location = new System.Drawing.Point(201, 61);
            this.collectIncomeUserControl1.Name = "collectIncomeUserControl1";
            this.collectIncomeUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.collectIncomeUserControl1.TabIndex = 14;
            // 
            // newAccountUserControl1
            // 
            this.newAccountUserControl1.Location = new System.Drawing.Point(200, 61);
            this.newAccountUserControl1.Name = "newAccountUserControl1";
            this.newAccountUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.newAccountUserControl1.TabIndex = 15;
            // 
            // reportsMainUserControl1
            // 
            this.reportsMainUserControl1.Location = new System.Drawing.Point(200, 61);
            this.reportsMainUserControl1.Name = "reportsMainUserControl1";
            this.reportsMainUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.reportsMainUserControl1.TabIndex = 16;
            // 
            // changeInfoUserControl1
            // 
            this.changeInfoUserControl1.Location = new System.Drawing.Point(201, 61);
            this.changeInfoUserControl1.Name = "changeInfoUserControl1";
            this.changeInfoUserControl1.Size = new System.Drawing.Size(1163, 635);
            this.changeInfoUserControl1.TabIndex = 17;
            // 
            // OwnerOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1363, 697);
            this.Controls.Add(this.changeInfoUserControl1);
            this.Controls.Add(this.reportsMainUserControl1);
            this.Controls.Add(this.newAccountUserControl1);
            this.Controls.Add(this.collectIncomeUserControl1);
            this.Controls.Add(this.cardDefinitionAndDetailsUserControl1);
            this.Controls.Add(this.addTrainerUserControl1);
            this.Controls.Add(this.addCardsUserControl1);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OwnerOptionForm";
            this.Text = "Monsters GYM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OwnerOptionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewCardButton;
        private System.Windows.Forms.Button NewAccountButton;
        private System.Windows.Forms.Button SettlementButton;
        private System.Windows.Forms.Button CardRegisterationButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button ChangeInfoButton;
        private System.Windows.Forms.Button AddTrainerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button HomeButton;
        private HomeUserControl homeUserControl1;
        private AddCardsUserControl addCardsUserControl1;
        private AddTrainerUserControl addTrainerUserControl1;
        private CardDefinitionAndDetailsUserControl cardDefinitionAndDetailsUserControl1;
        private CollectIncomeUserControl collectIncomeUserControl1;
        private NewAccountUserControl newAccountUserControl1;
        private ReportsMainUserControl reportsMainUserControl1;
        private ChangeInfoUserControl changeInfoUserControl1;
    }
}