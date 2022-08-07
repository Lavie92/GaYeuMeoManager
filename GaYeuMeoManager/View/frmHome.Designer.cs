﻿namespace GaYeuMeoManager
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCriteriaCustomer = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCriteriaCustomer = new System.Windows.Forms.ComboBox();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.rdoSortIdCustomer = new System.Windows.Forms.RadioButton();
            this.rdoSortCreateDayCustomer = new System.Windows.Forms.RadioButton();
            this.rdoSortNameCustomer = new System.Windows.Forms.RadioButton();
            this.grbAct = new System.Windows.Forms.GroupBox();
            this.btnRefreshCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCriteriaDevice = new System.Windows.Forms.TextBox();
            this.btnSearchDevice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCriteriaDevice = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoRFG = new System.Windows.Forms.RadioButton();
            this.rdoSortIdDevice = new System.Windows.Forms.RadioButton();
            this.rdoSortNameDevice = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefreshDevice = new System.Windows.Forms.Button();
            this.btnAddNewDevice = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSearchOrders = new System.Windows.Forms.TextBox();
            this.btnSearchOrders = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSearchRoders = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoSortTotalOrders = new System.Windows.Forms.RadioButton();
            this.rdoCreationDate = new System.Windows.Forms.RadioButton();
            this.rdoSortIdOrders = new System.Windows.Forms.RadioButton();
            this.rdoSortOrders = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.btnAddNewOrders = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.grbSort.SuspendLayout();
            this.grbAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 566);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.dgvCustomer);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QL KHÁCH HÀNG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbSort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbAct, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 383);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtCriteriaCustomer);
            this.groupBox7.Controls.Add(this.btnSearchCustomer);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.cbxCriteriaCustomer);
            this.groupBox7.Location = new System.Drawing.Point(701, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(343, 144);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm kiếm với";
            // 
            // txtCriteriaCustomer
            // 
            this.txtCriteriaCustomer.Location = new System.Drawing.Point(141, 61);
            this.txtCriteriaCustomer.Name = "txtCriteriaCustomer";
            this.txtCriteriaCustomer.Size = new System.Drawing.Size(166, 23);
            this.txtCriteriaCustomer.TabIndex = 3;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(57, 101);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(111, 31);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tiêu chí";
            // 
            // cbxCriteriaCustomer
            // 
            this.cbxCriteriaCustomer.FormattingEnabled = true;
            this.cbxCriteriaCustomer.Items.AddRange(new object[] {
            "Theo mã",
            "Theo tên",
            "Theo ngày sinh"});
            this.cbxCriteriaCustomer.Location = new System.Drawing.Point(141, 23);
            this.cbxCriteriaCustomer.Name = "cbxCriteriaCustomer";
            this.cbxCriteriaCustomer.Size = new System.Drawing.Size(121, 25);
            this.cbxCriteriaCustomer.TabIndex = 0;
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.rdoSortIdCustomer);
            this.grbSort.Controls.Add(this.rdoSortCreateDayCustomer);
            this.grbSort.Controls.Add(this.rdoSortNameCustomer);
            this.grbSort.Location = new System.Drawing.Point(352, 3);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(343, 144);
            this.grbSort.TabIndex = 1;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Sắp xếp ";
            // 
            // rdoSortIdCustomer
            // 
            this.rdoSortIdCustomer.AutoSize = true;
            this.rdoSortIdCustomer.Location = new System.Drawing.Point(102, 98);
            this.rdoSortIdCustomer.Name = "rdoSortIdCustomer";
            this.rdoSortIdCustomer.Size = new System.Drawing.Size(78, 21);
            this.rdoSortIdCustomer.TabIndex = 0;
            this.rdoSortIdCustomer.TabStop = true;
            this.rdoSortIdCustomer.Text = "Theo Mã";
            this.rdoSortIdCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoSortCreateDayCustomer
            // 
            this.rdoSortCreateDayCustomer.AutoSize = true;
            this.rdoSortCreateDayCustomer.Location = new System.Drawing.Point(102, 59);
            this.rdoSortCreateDayCustomer.Name = "rdoSortCreateDayCustomer";
            this.rdoSortCreateDayCustomer.Size = new System.Drawing.Size(138, 21);
            this.rdoSortCreateDayCustomer.TabIndex = 0;
            this.rdoSortCreateDayCustomer.TabStop = true;
            this.rdoSortCreateDayCustomer.Text = "Ngày tạo tài khoản";
            this.rdoSortCreateDayCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoSortNameCustomer
            // 
            this.rdoSortNameCustomer.AutoSize = true;
            this.rdoSortNameCustomer.Location = new System.Drawing.Point(102, 25);
            this.rdoSortNameCustomer.Name = "rdoSortNameCustomer";
            this.rdoSortNameCustomer.Size = new System.Drawing.Size(77, 21);
            this.rdoSortNameCustomer.TabIndex = 0;
            this.rdoSortNameCustomer.TabStop = true;
            this.rdoSortNameCustomer.Text = "Theo tên";
            this.rdoSortNameCustomer.UseVisualStyleBackColor = true;
            // 
            // grbAct
            // 
            this.grbAct.Controls.Add(this.btnRefreshCustomer);
            this.grbAct.Controls.Add(this.btnAddCustomer);
            this.grbAct.Location = new System.Drawing.Point(3, 3);
            this.grbAct.Name = "grbAct";
            this.grbAct.Size = new System.Drawing.Size(343, 144);
            this.grbAct.TabIndex = 0;
            this.grbAct.TabStop = false;
            this.grbAct.Text = "Hành động";
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCustomer.Image")));
            this.btnRefreshCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCustomer.Location = new System.Drawing.Point(187, 52);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(117, 40);
            this.btnRefreshCustomer.TabIndex = 0;
            this.btnRefreshCustomer.Text = "Làm mới";
            this.btnRefreshCustomer.UseVisualStyleBackColor = true;
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(38, 52);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(117, 40);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.BirthDate,
            this.Gender,
            this.CustomerPhoneNumber,
            this.Email});
            this.dgvCustomer.Location = new System.Drawing.Point(-4, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(1046, 377);
            this.dgvCustomer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1045, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QL THIẾT BỊ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCriteriaDevice);
            this.groupBox1.Controls.Add(this.btnSearchDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxCriteriaDevice);
            this.groupBox1.Location = new System.Drawing.Point(699, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm với";
            // 
            // txtCriteriaDevice
            // 
            this.txtCriteriaDevice.Location = new System.Drawing.Point(141, 61);
            this.txtCriteriaDevice.Name = "txtCriteriaDevice";
            this.txtCriteriaDevice.Size = new System.Drawing.Size(166, 23);
            this.txtCriteriaDevice.TabIndex = 3;
            // 
            // btnSearchDevice
            // 
            this.btnSearchDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDevice.Image")));
            this.btnSearchDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDevice.Location = new System.Drawing.Point(57, 101);
            this.btnSearchDevice.Name = "btnSearchDevice";
            this.btnSearchDevice.Size = new System.Drawing.Size(111, 31);
            this.btnSearchDevice.TabIndex = 2;
            this.btnSearchDevice.Text = "Tìm kiếm";
            this.btnSearchDevice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nội dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiêu chí";
            // 
            // cbxCriteriaDevice
            // 
            this.cbxCriteriaDevice.FormattingEnabled = true;
            this.cbxCriteriaDevice.Items.AddRange(new object[] {
            "Theo mã",
            "Theo tên",
            "Theo ngày sản xuất"});
            this.cbxCriteriaDevice.Location = new System.Drawing.Point(141, 23);
            this.cbxCriteriaDevice.Name = "cbxCriteriaDevice";
            this.cbxCriteriaDevice.Size = new System.Drawing.Size(121, 25);
            this.cbxCriteriaDevice.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoRFG);
            this.groupBox2.Controls.Add(this.rdoSortIdDevice);
            this.groupBox2.Controls.Add(this.rdoSortNameDevice);
            this.groupBox2.Location = new System.Drawing.Point(352, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp ";
            // 
            // rdoRFG
            // 
            this.rdoRFG.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoRFG.AutoSize = true;
            this.rdoRFG.Location = new System.Drawing.Point(133, 98);
            this.rdoRFG.Name = "rdoRFG";
            this.rdoRFG.Size = new System.Drawing.Size(139, 21);
            this.rdoRFG.TabIndex = 0;
            this.rdoRFG.TabStop = true;
            this.rdoRFG.Text = "Theo ngày sản xuất";
            this.rdoRFG.UseVisualStyleBackColor = true;
            // 
            // rdoSortIdDevice
            // 
            this.rdoSortIdDevice.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoSortIdDevice.AutoSize = true;
            this.rdoSortIdDevice.Location = new System.Drawing.Point(133, 67);
            this.rdoSortIdDevice.Name = "rdoSortIdDevice";
            this.rdoSortIdDevice.Size = new System.Drawing.Size(77, 21);
            this.rdoSortIdDevice.TabIndex = 0;
            this.rdoSortIdDevice.TabStop = true;
            this.rdoSortIdDevice.Text = "Theo mã";
            this.rdoSortIdDevice.UseVisualStyleBackColor = true;
            // 
            // rdoSortNameDevice
            // 
            this.rdoSortNameDevice.AutoSize = true;
            this.rdoSortNameDevice.Location = new System.Drawing.Point(133, 36);
            this.rdoSortNameDevice.Name = "rdoSortNameDevice";
            this.rdoSortNameDevice.Size = new System.Drawing.Size(77, 21);
            this.rdoSortNameDevice.TabIndex = 0;
            this.rdoSortNameDevice.TabStop = true;
            this.rdoSortNameDevice.Text = "Theo tên";
            this.rdoSortNameDevice.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefreshDevice);
            this.groupBox3.Controls.Add(this.btnAddNewDevice);
            this.groupBox3.Location = new System.Drawing.Point(2, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 144);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // btnRefreshDevice
            // 
            this.btnRefreshDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDevice.Image")));
            this.btnRefreshDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshDevice.Location = new System.Drawing.Point(187, 52);
            this.btnRefreshDevice.Name = "btnRefreshDevice";
            this.btnRefreshDevice.Size = new System.Drawing.Size(117, 40);
            this.btnRefreshDevice.TabIndex = 0;
            this.btnRefreshDevice.Text = "Làm mới";
            this.btnRefreshDevice.UseVisualStyleBackColor = true;
            // 
            // btnAddNewDevice
            // 
            this.btnAddNewDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewDevice.Image")));
            this.btnAddNewDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewDevice.Location = new System.Drawing.Point(38, 52);
            this.btnAddNewDevice.Name = "btnAddNewDevice";
            this.btnAddNewDevice.Size = new System.Drawing.Size(117, 40);
            this.btnAddNewDevice.TabIndex = 0;
            this.btnAddNewDevice.Text = "Thêm";
            this.btnAddNewDevice.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1046, 377);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1045, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QL HOÁ ĐƠN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSearchOrders);
            this.groupBox4.Controls.Add(this.btnSearchOrders);
            this.groupBox4.Controls.Add(this.lblContent);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbxSearchRoders);
            this.groupBox4.Location = new System.Drawing.Point(699, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 144);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm với";
            // 
            // txtSearchOrders
            // 
            this.txtSearchOrders.Location = new System.Drawing.Point(141, 61);
            this.txtSearchOrders.Name = "txtSearchOrders";
            this.txtSearchOrders.Size = new System.Drawing.Size(166, 23);
            this.txtSearchOrders.TabIndex = 3;
            // 
            // btnSearchOrders
            // 
            this.btnSearchOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchOrders.Image")));
            this.btnSearchOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchOrders.Location = new System.Drawing.Point(57, 101);
            this.btnSearchOrders.Name = "btnSearchOrders";
            this.btnSearchOrders.Size = new System.Drawing.Size(111, 31);
            this.btnSearchOrders.TabIndex = 2;
            this.btnSearchOrders.Text = "Tìm kiếm";
            this.btnSearchOrders.UseVisualStyleBackColor = true;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(54, 64);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(62, 17);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu chí";
            // 
            // cbxSearchRoders
            // 
            this.cbxSearchRoders.FormattingEnabled = true;
            this.cbxSearchRoders.Items.AddRange(new object[] {
            "Theo mã",
            "Theo ngày tạo",
            "Theo giá trị"});
            this.cbxSearchRoders.Location = new System.Drawing.Point(141, 23);
            this.cbxSearchRoders.Name = "cbxSearchRoders";
            this.cbxSearchRoders.Size = new System.Drawing.Size(121, 25);
            this.cbxSearchRoders.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoSortTotalOrders);
            this.groupBox5.Controls.Add(this.rdoCreationDate);
            this.groupBox5.Controls.Add(this.rdoSortIdOrders);
            this.groupBox5.Controls.Add(this.rdoSortOrders);
            this.groupBox5.Location = new System.Drawing.Point(353, 382);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 144);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sắp xếp ";
            // 
            // rdoSortTotalOrders
            // 
            this.rdoSortTotalOrders.AutoSize = true;
            this.rdoSortTotalOrders.Location = new System.Drawing.Point(108, 106);
            this.rdoSortTotalOrders.Name = "rdoSortTotalOrders";
            this.rdoSortTotalOrders.Size = new System.Drawing.Size(110, 21);
            this.rdoSortTotalOrders.TabIndex = 1;
            this.rdoSortTotalOrders.TabStop = true;
            this.rdoSortTotalOrders.Text = "Theo tổng tiền";
            this.rdoSortTotalOrders.UseVisualStyleBackColor = true;
            // 
            // rdoCreationDate
            // 
            this.rdoCreationDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoCreationDate.AutoSize = true;
            this.rdoCreationDate.Location = new System.Drawing.Point(108, 76);
            this.rdoCreationDate.Name = "rdoCreationDate";
            this.rdoCreationDate.Size = new System.Drawing.Size(109, 21);
            this.rdoCreationDate.TabIndex = 0;
            this.rdoCreationDate.TabStop = true;
            this.rdoCreationDate.Text = "Theo ngày lập";
            this.rdoCreationDate.UseVisualStyleBackColor = true;
            // 
            // rdoSortIdOrders
            // 
            this.rdoSortIdOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoSortIdOrders.AutoSize = true;
            this.rdoSortIdOrders.Location = new System.Drawing.Point(108, 46);
            this.rdoSortIdOrders.Name = "rdoSortIdOrders";
            this.rdoSortIdOrders.Size = new System.Drawing.Size(77, 21);
            this.rdoSortIdOrders.TabIndex = 0;
            this.rdoSortIdOrders.TabStop = true;
            this.rdoSortIdOrders.Text = "Theo mã";
            this.rdoSortIdOrders.UseVisualStyleBackColor = true;
            // 
            // rdoSortOrders
            // 
            this.rdoSortOrders.AutoSize = true;
            this.rdoSortOrders.Location = new System.Drawing.Point(108, 16);
            this.rdoSortOrders.Name = "rdoSortOrders";
            this.rdoSortOrders.Size = new System.Drawing.Size(77, 21);
            this.rdoSortOrders.TabIndex = 0;
            this.rdoSortOrders.TabStop = true;
            this.rdoSortOrders.Text = "Theo tên";
            this.rdoSortOrders.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRefreshOrders);
            this.groupBox6.Controls.Add(this.btnAddNewOrders);
            this.groupBox6.Location = new System.Drawing.Point(4, 382);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(343, 144);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hành động";
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshOrders.Image")));
            this.btnRefreshOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshOrders.Location = new System.Drawing.Point(187, 52);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(117, 40);
            this.btnRefreshOrders.TabIndex = 0;
            this.btnRefreshOrders.Text = "Làm mới";
            this.btnRefreshOrders.UseVisualStyleBackColor = true;
            // 
            // btnAddNewOrders
            // 
            this.btnAddNewOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewOrders.Image")));
            this.btnAddNewOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewOrders.Location = new System.Drawing.Point(38, 52);
            this.btnAddNewOrders.Name = "btnAddNewOrders";
            this.btnAddNewOrders.Size = new System.Drawing.Size(117, 40);
            this.btnAddNewOrders.TabIndex = 0;
            this.btnAddNewOrders.Text = "Thêm";
            this.btnAddNewOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1046, 377);
            this.dataGridView3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1045, 533);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "THỐNG KÊ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Tên";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Ngày sinh";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // CustomerPhoneNumber
            // 
            this.CustomerPhoneNumber.DataPropertyName = "PhoneNumber";
            this.CustomerPhoneNumber.HeaderText = "SĐT";
            this.CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            this.CustomerPhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 566);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.Text = "Gà yêu Mèo";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            this.grbAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.GroupBox grbAct;
        private System.Windows.Forms.Button btnRefreshCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rdoSortIdCustomer;
        private System.Windows.Forms.RadioButton rdoSortCreateDayCustomer;
        private System.Windows.Forms.RadioButton rdoSortNameCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSortIdDevice;
        private System.Windows.Forms.RadioButton rdoSortNameDevice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefreshDevice;
        private System.Windows.Forms.Button btnAddNewDevice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton rdoRFG;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearchOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSearchRoders;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoSortTotalOrders;
        private System.Windows.Forms.RadioButton rdoCreationDate;
        private System.Windows.Forms.RadioButton rdoSortIdOrders;
        private System.Windows.Forms.RadioButton rdoSortOrders;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.Button btnAddNewOrders;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtCriteriaCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCriteriaCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCriteriaDevice;
        private System.Windows.Forms.Button btnSearchDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCriteriaDevice;
        private System.Windows.Forms.TextBox txtSearchOrders;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}
