namespace MonstersGYM
{
    partial class ReportsMainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsMainForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserLogsTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WelcomeProfileTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MemberSignInTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IncomeTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.MemberShipTabPage = new System.Windows.Forms.TabPage();
            this.ShowDetailsButton = new System.Windows.Forms.Button();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.UserLogsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.WelcomeProfileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.MemberSignInTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.IncomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.MemberShipTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(759, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "رجوع";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserLogsTabPage);
            this.tabControl1.Controls.Add(this.WelcomeProfileTabPage);
            this.tabControl1.Controls.Add(this.MemberSignInTabPage);
            this.tabControl1.Controls.Add(this.IncomeTabPage);
            this.tabControl1.Controls.Add(this.MemberShipTabPage);
            this.tabControl1.Location = new System.Drawing.Point(26, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1335, 595);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            // 
            // UserLogsTabPage
            // 
            this.UserLogsTabPage.Controls.Add(this.dataGridView1);
            this.UserLogsTabPage.Location = new System.Drawing.Point(4, 22);
            this.UserLogsTabPage.Name = "UserLogsTabPage";
            this.UserLogsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserLogsTabPage.Size = new System.Drawing.Size(1004, 362);
            this.UserLogsTabPage.TabIndex = 0;
            this.UserLogsTabPage.Text = "تقرير تسجيل الدخول للمستخدم ";
            this.UserLogsTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(896, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // WelcomeProfileTabPage
            // 
            this.WelcomeProfileTabPage.Controls.Add(this.chart1);
            this.WelcomeProfileTabPage.Controls.Add(this.dataGridView5);
            this.WelcomeProfileTabPage.Controls.Add(this.dataGridView2);
            this.WelcomeProfileTabPage.Location = new System.Drawing.Point(4, 22);
            this.WelcomeProfileTabPage.Name = "WelcomeProfileTabPage";
            this.WelcomeProfileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.WelcomeProfileTabPage.Size = new System.Drawing.Size(1327, 569);
            this.WelcomeProfileTabPage.TabIndex = 1;
            this.WelcomeProfileTabPage.Text = "تقرير الزيارات";
            this.WelcomeProfileTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(20, 9);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView5.Size = new System.Drawing.Size(418, 302);
            this.dataGridView5.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(444, 9);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.Size = new System.Drawing.Size(548, 302);
            this.dataGridView2.TabIndex = 1;
            // 
            // MemberSignInTabPage
            // 
            this.MemberSignInTabPage.Controls.Add(this.dataGridView3);
            this.MemberSignInTabPage.Location = new System.Drawing.Point(4, 22);
            this.MemberSignInTabPage.Name = "MemberSignInTabPage";
            this.MemberSignInTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MemberSignInTabPage.Size = new System.Drawing.Size(1004, 362);
            this.MemberSignInTabPage.TabIndex = 2;
            this.MemberSignInTabPage.Text = "تقرير تسجيل الدخول للاعضاء";
            this.MemberSignInTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 11);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView3.Size = new System.Drawing.Size(962, 353);
            this.dataGridView3.TabIndex = 1;
            // 
            // IncomeTabPage
            // 
            this.IncomeTabPage.Controls.Add(this.dataGridView6);
            this.IncomeTabPage.Controls.Add(this.dataGridView4);
            this.IncomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.IncomeTabPage.Name = "IncomeTabPage";
            this.IncomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IncomeTabPage.Size = new System.Drawing.Size(1004, 362);
            this.IncomeTabPage.TabIndex = 3;
            this.IncomeTabPage.Text = "تقرير المالية";
            this.IncomeTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(6, 11);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(415, 334);
            this.dataGridView6.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(444, 11);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView4.Size = new System.Drawing.Size(541, 353);
            this.dataGridView4.TabIndex = 1;
            // 
            // MemberShipTabPage
            // 
            this.MemberShipTabPage.Controls.Add(this.ShowDetailsButton);
            this.MemberShipTabPage.Controls.Add(this.dataGridView8);
            this.MemberShipTabPage.Controls.Add(this.dataGridView7);
            this.MemberShipTabPage.Location = new System.Drawing.Point(4, 22);
            this.MemberShipTabPage.Name = "MemberShipTabPage";
            this.MemberShipTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MemberShipTabPage.Size = new System.Drawing.Size(1004, 362);
            this.MemberShipTabPage.TabIndex = 4;
            this.MemberShipTabPage.Text = "تقرير إشتراك الأعضاء";
            this.MemberShipTabPage.UseVisualStyleBackColor = true;
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.Location = new System.Drawing.Point(110, 327);
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Size = new System.Drawing.Size(111, 23);
            this.ShowDetailsButton.TabIndex = 17;
            this.ShowDetailsButton.Text = "عرض التفاصيل";
            this.ShowDetailsButton.UseVisualStyleBackColor = true;
            this.ShowDetailsButton.Click += new System.EventHandler(this.ShowDetailsButton_Click);
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(336, 6);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView8.Size = new System.Drawing.Size(662, 350);
            this.dataGridView8.TabIndex = 1;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(6, 6);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView7.Size = new System.Drawing.Size(310, 315);
            this.dataGridView7.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "الأسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "التاريخ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(348, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "جميع الايام";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(658, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "الجميع";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "من";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "الى";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(51, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(582, 59);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(110, 45);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "بحث";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 82);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(524, 12);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 16;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 317);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "WelcomeProfile";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1315, 249);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // ReportsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 697);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Monsters GYM";
            this.Load += new System.EventHandler(this.ReportsMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.UserLogsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.WelcomeProfileTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.MemberSignInTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.IncomeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.MemberShipTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserLogsTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage WelcomeProfileTabPage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage MemberSignInTabPage;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage IncomeTabPage;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TabPage MemberShipTabPage;
        private System.Windows.Forms.Button ShowDetailsButton;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}