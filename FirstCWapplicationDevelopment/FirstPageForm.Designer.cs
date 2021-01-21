using System;

namespace FirstCWapplicationDevelopment
{
    partial class FirstPageForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.catogeryChart = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.catogeryAddition = new System.Windows.Forms.Button();
            this.catogeryAddTxt = new System.Windows.Forms.TextBox();
            this.catogeryList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login = new System.Windows.Forms.Button();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rateMe = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            this.rateBtn = new System.Windows.Forms.Button();
            this.todayDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Criteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excellent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dissatisfied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateMeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namePanel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.raterNameTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.descendingSortCriteriaBtn = new System.Windows.Forms.Button();
            this.ascendingSortCriteriaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.ratingGraphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.catogeryChart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rateMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateMeBindingSource)).BeginInit();
            this.namePanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingGraphBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1524, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage2.Controls.Add(this.catogeryChart);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.vScrollBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1516, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADMIN";
            // 
            // catogeryChart
            // 
            this.catogeryChart.Controls.Add(this.reset);
            this.catogeryChart.Controls.Add(this.catogeryAddition);
            this.catogeryChart.Controls.Add(this.catogeryAddTxt);
            this.catogeryChart.Controls.Add(this.catogeryList);
            this.catogeryChart.Controls.Add(this.label4);
            this.catogeryChart.Controls.Add(this.label3);
            this.catogeryChart.Location = new System.Drawing.Point(8, 156);
            this.catogeryChart.Name = "catogeryChart";
            this.catogeryChart.Size = new System.Drawing.Size(1491, 389);
            this.catogeryChart.TabIndex = 2;
            this.catogeryChart.TabStop = false;
            this.catogeryChart.Text = "Catogery";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(436, 151);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(158, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // catogeryAddition
            // 
            this.catogeryAddition.Location = new System.Drawing.Point(436, 68);
            this.catogeryAddition.Name = "catogeryAddition";
            this.catogeryAddition.Size = new System.Drawing.Size(158, 23);
            this.catogeryAddition.TabIndex = 4;
            this.catogeryAddition.Text = "ADD";
            this.catogeryAddition.UseVisualStyleBackColor = true;
            this.catogeryAddition.Click += new System.EventHandler(this.catogeryAddition_Click);
            // 
            // catogeryAddTxt
            // 
            this.catogeryAddTxt.Location = new System.Drawing.Point(136, 68);
            this.catogeryAddTxt.Name = "catogeryAddTxt";
            this.catogeryAddTxt.Size = new System.Drawing.Size(255, 22);
            this.catogeryAddTxt.TabIndex = 3;
            // 
            // catogeryList
            // 
            this.catogeryList.FormattingEnabled = true;
            this.catogeryList.ItemHeight = 16;
            this.catogeryList.Location = new System.Drawing.Point(136, 151);
            this.catogeryList.Name = "catogeryList";
            this.catogeryList.Size = new System.Drawing.Size(255, 164);
            this.catogeryList.TabIndex = 2;
            this.catogeryList.SelectedIndexChanged += new System.EventHandler(this.catogeryList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Avilable Catogery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Catogery";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.passTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1493, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(436, 33);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(158, 68);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(127, 79);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(255, 22);
            this.passTxt.TabIndex = 3;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(127, 34);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(255, 22);
            this.nameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1502, 7);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 550);
            this.vScrollBar1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.rateMe);
            this.tabPage1.Controls.Add(this.namePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1516, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ratings";
            // 
            // rateMe
            // 
            this.rateMe.BackColor = System.Drawing.Color.FloralWhite;
            this.rateMe.Controls.Add(this.refresh);
            this.rateMe.Controls.Add(this.rateBtn);
            this.rateMe.Controls.Add(this.todayDate);
            this.rateMe.Controls.Add(this.dataGridView1);
            this.rateMe.Location = new System.Drawing.Point(426, 6);
            this.rateMe.Name = "rateMe";
            this.rateMe.Size = new System.Drawing.Size(1193, 539);
            this.rateMe.TabIndex = 1;
            this.rateMe.TabStop = false;
            this.rateMe.Text = "Rate ME";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.SpringGreen;
            this.refresh.Location = new System.Drawing.Point(6, 469);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(113, 53);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "REFRESH";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // rateBtn
            // 
            this.rateBtn.BackColor = System.Drawing.Color.Crimson;
            this.rateBtn.Location = new System.Drawing.Point(542, 469);
            this.rateBtn.Name = "rateBtn";
            this.rateBtn.Size = new System.Drawing.Size(113, 53);
            this.rateBtn.TabIndex = 7;
            this.rateBtn.Text = "RATE ME";
            this.rateBtn.UseVisualStyleBackColor = false;
            this.rateBtn.Click += new System.EventHandler(this.rateBtn_Click);
            // 
            // todayDate
            // 
            this.todayDate.Enabled = false;
            this.todayDate.Location = new System.Drawing.Point(884, 469);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(200, 22);
            this.todayDate.TabIndex = 0;
            this.todayDate.ValueChanged += new System.EventHandler(this.todayDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criteria,
            this.Excellent,
            this.Good,
            this.Average,
            this.Dissatisfied,
            this.Date});
            this.dataGridView1.DataSource = this.rateMeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 442);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Criteria
            // 
            this.Criteria.DataPropertyName = "Criteria";
            this.Criteria.HeaderText = "Criteria";
            this.Criteria.MinimumWidth = 6;
            this.Criteria.Name = "Criteria";
            this.Criteria.ReadOnly = true;
            this.Criteria.Width = 125;
            // 
            // Excellent
            // 
            this.Excellent.DataPropertyName = "Excellent";
            this.Excellent.HeaderText = "Excellent";
            this.Excellent.MinimumWidth = 6;
            this.Excellent.Name = "Excellent";
            this.Excellent.ReadOnly = true;
            this.Excellent.Width = 125;
            // 
            // Good
            // 
            this.Good.DataPropertyName = "Good";
            this.Good.HeaderText = "Good";
            this.Good.MinimumWidth = 6;
            this.Good.Name = "Good";
            this.Good.ReadOnly = true;
            this.Good.Width = 125;
            // 
            // Average
            // 
            this.Average.DataPropertyName = "Average";
            this.Average.HeaderText = "Average";
            this.Average.MinimumWidth = 6;
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            this.Average.Width = 125;
            // 
            // Dissatisfied
            // 
            this.Dissatisfied.DataPropertyName = "Dissatisfied";
            this.Dissatisfied.HeaderText = "Dissatisfied";
            this.Dissatisfied.MinimumWidth = 6;
            this.Dissatisfied.Name = "Dissatisfied";
            this.Dissatisfied.ReadOnly = true;
            this.Dissatisfied.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.Beige;
            this.namePanel.Controls.Add(this.label6);
            this.namePanel.Controls.Add(this.label5);
            this.namePanel.Controls.Add(this.emailTxt);
            this.namePanel.Controls.Add(this.phoneTxt);
            this.namePanel.Controls.Add(this.raterNameTxt);
            this.namePanel.Controls.Add(this.emailLbl);
            this.namePanel.Controls.Add(this.phoneLbl);
            this.namePanel.Controls.Add(this.nameLbl);
            this.namePanel.Location = new System.Drawing.Point(6, 6);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(414, 539);
            this.namePanel.TabIndex = 0;
            this.namePanel.TabStop = false;
            this.namePanel.Text = "Contact Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Optional to Share your Contact Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Optional to Share your Contact Information";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(87, 196);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(308, 22);
            this.emailTxt.TabIndex = 5;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(87, 125);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(308, 22);
            this.phoneTxt.TabIndex = 4;
            // 
            // raterNameTxt
            // 
            this.raterNameTxt.Location = new System.Drawing.Point(87, 44);
            this.raterNameTxt.Name = "raterNameTxt";
            this.raterNameTxt.Size = new System.Drawing.Size(308, 22);
            this.raterNameTxt.TabIndex = 3;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(6, 201);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(6, 125);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(49, 17);
            this.phoneLbl.TabIndex = 1;
            this.phoneLbl.Text = "Phone";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(6, 44);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.descendingSortCriteriaBtn);
            this.tabPage3.Controls.Add(this.ascendingSortCriteriaBtn);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1516, 553);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graphs";
            // 
            // descendingSortCriteriaBtn
            // 
            this.descendingSortCriteriaBtn.Location = new System.Drawing.Point(152, 227);
            this.descendingSortCriteriaBtn.Name = "descendingSortCriteriaBtn";
            this.descendingSortCriteriaBtn.Size = new System.Drawing.Size(146, 53);
            this.descendingSortCriteriaBtn.TabIndex = 10;
            this.descendingSortCriteriaBtn.Text = "Sort By Ratings Descending";
            this.descendingSortCriteriaBtn.UseVisualStyleBackColor = true;
            this.descendingSortCriteriaBtn.Click += new System.EventHandler(this.descendingSortRateBtn_Click);
            // 
            // ascendingSortCriteriaBtn
            // 
            this.ascendingSortCriteriaBtn.Location = new System.Drawing.Point(8, 227);
            this.ascendingSortCriteriaBtn.Name = "ascendingSortCriteriaBtn";
            this.ascendingSortCriteriaBtn.Size = new System.Drawing.Size(138, 53);
            this.ascendingSortCriteriaBtn.TabIndex = 9;
            this.ascendingSortCriteriaBtn.Text = "Sort By Ratings Ascending";
            this.ascendingSortCriteriaBtn.UseVisualStyleBackColor = true;
            this.ascendingSortCriteriaBtn.Click += new System.EventHandler(this.ascendingSortRateBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(8, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 259);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(304, 13);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "ServiceRating";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1207, 532);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(290, 208);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1516, 553);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Outputs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "CategoryFile.txt";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1516, 553);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Files";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "Open Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openReport_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "rates.xml";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "reports.csv";
            // 
            // FirstPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 597);
            this.Controls.Add(this.tabControl1);
            this.Name = "FirstPageForm";
            this.Text = "Rate Us";
            this.Load += new System.EventHandler(this.FirstPageForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.catogeryChart.ResumeLayout(false);
            this.catogeryChart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.rateMe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateMeBindingSource)).EndInit();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ratingGraphBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox catogeryChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox catogeryAddTxt;
        private System.Windows.Forms.ListBox catogeryList;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button catogeryAddition;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox rateMe;
        private System.Windows.Forms.GroupBox namePanel;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox raterNameTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker todayDate;
        private System.Windows.Forms.Button rateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ratingGraphBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn criteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excellentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn goodDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn averageDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dissatisfiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criteria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excellent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Good;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Average;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dissatisfied;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource rateMeBindingSource;
        private System.Windows.Forms.Button descendingSortCriteriaBtn;
        private System.Windows.Forms.Button ascendingSortCriteriaBtn;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

