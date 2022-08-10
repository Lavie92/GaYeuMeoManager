namespace GaYeuMeoManager.View
{
    partial class frmAddOrdersDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrdersDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSubscription = new System.Windows.Forms.ComboBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrdersDetail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.dgvOrdersDetail = new System.Windows.Forms.DataGridView();
            this.OrdersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrdersDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(166, 31);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbxCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gói tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // cbxSubscription
            // 
            this.cbxSubscription.FormattingEnabled = true;
            this.cbxSubscription.Location = new System.Drawing.Point(166, 121);
            this.cbxSubscription.Name = "cbxSubscription";
            this.cbxSubscription.Size = new System.Drawing.Size(121, 21);
            this.cbxSubscription.TabIndex = 1;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(166, 163);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericQuantity.TabIndex = 2;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddOrdersDetail
            // 
            this.btnAddOrdersDetail.Location = new System.Drawing.Point(66, 220);
            this.btnAddOrdersDetail.Name = "btnAddOrdersDetail";
            this.btnAddOrdersDetail.Size = new System.Drawing.Size(78, 46);
            this.btnAddOrdersDetail.TabIndex = 3;
            this.btnAddOrdersDetail.Text = "Thêm";
            this.btnAddOrdersDetail.UseVisualStyleBackColor = true;
            this.btnAddOrdersDetail.Click += new System.EventHandler(this.btnAddOrdersDetail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhân viên";
            // 
            // cbxStaff
            // 
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(166, 72);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(121, 21);
            this.cbxStaff.TabIndex = 1;
            // 
            // dgvOrdersDetail
            // 
            this.dgvOrdersDetail.AllowUserToAddRows = false;
            this.dgvOrdersDetail.AllowUserToDeleteRows = false;
            this.dgvOrdersDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdersDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdersId,
            this.SubscriptionId,
            this.Quantity,
            this.TotalOrdersDetail});
            this.dgvOrdersDetail.Location = new System.Drawing.Point(392, 31);
            this.dgvOrdersDetail.Name = "dgvOrdersDetail";
            this.dgvOrdersDetail.ReadOnly = true;
            this.dgvOrdersDetail.Size = new System.Drawing.Size(474, 235);
            this.dgvOrdersDetail.TabIndex = 4;
            // 
            // OrdersId
            // 
            this.OrdersId.DataPropertyName = "OrdersId";
            this.OrdersId.HeaderText = "Mã HĐ";
            this.OrdersId.Name = "OrdersId";
            this.OrdersId.ReadOnly = true;
            // 
            // SubscriptionId
            // 
            this.SubscriptionId.DataPropertyName = "SubscriptionId";
            this.SubscriptionId.HeaderText = "Mã Gói Tập";
            this.SubscriptionId.Name = "SubscriptionId";
            this.SubscriptionId.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalOrdersDetail
            // 
            this.TotalOrdersDetail.DataPropertyName = "TotalOrdersDetail";
            this.TotalOrdersDetail.HeaderText = "Số Tiền";
            this.TotalOrdersDetail.Name = "TotalOrdersDetail";
            this.TotalOrdersDetail.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddOrdersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(878, 369);
            this.Controls.Add(this.dgvOrdersDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddOrdersDetail);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.cbxSubscription);
            this.Controls.Add(this.cbxStaff);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddOrdersDetail";
            this.Text = "Thêm hoá đơn";
            this.Load += new System.EventHandler(this.frmAddOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSubscription;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btnAddOrdersDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.DataGridView dgvOrdersDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrdersDetail;
        private System.Windows.Forms.Button btnCancel;
    }
}