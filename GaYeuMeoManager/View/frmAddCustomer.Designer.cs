namespace GaYeuMeoManager
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimeCustomerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rdoGenderMale = new System.Windows.Forms.RadioButton();
            this.rdoGenderFemale = new System.Windows.Forms.RadioButton();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Location = new System.Drawing.Point(131, 25);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(131, 77);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(131, 251);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT";
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(131, 315);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPhoneNumber.TabIndex = 6;
            // 
            // dateTimeCustomerBirthDate
            // 
            this.dateTimeCustomerBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeCustomerBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimeCustomerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimeCustomerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCustomerBirthDate.Location = new System.Drawing.Point(131, 136);
            this.dateTimeCustomerBirthDate.MaxDate = new System.DateTime(2050, 1, 25, 0, 0, 0, 0);
            this.dateTimeCustomerBirthDate.MinDate = new System.DateTime(1980, 6, 11, 0, 0, 0, 0);
            this.dateTimeCustomerBirthDate.Name = "dateTimeCustomerBirthDate";
            this.dateTimeCustomerBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimeCustomerBirthDate.TabIndex = 2;
            this.dateTimeCustomerBirthDate.Value = new System.DateTime(2022, 8, 7, 0, 0, 0, 0);
            // 
            // rdoGenderMale
            // 
            this.rdoGenderMale.AutoSize = true;
            this.rdoGenderMale.Location = new System.Drawing.Point(131, 199);
            this.rdoGenderMale.Name = "rdoGenderMale";
            this.rdoGenderMale.Size = new System.Drawing.Size(47, 17);
            this.rdoGenderMale.TabIndex = 3;
            this.rdoGenderMale.TabStop = true;
            this.rdoGenderMale.Text = "Nam";
            this.rdoGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdoGenderFemale
            // 
            this.rdoGenderFemale.AutoSize = true;
            this.rdoGenderFemale.Location = new System.Drawing.Point(192, 199);
            this.rdoGenderFemale.Name = "rdoGenderFemale";
            this.rdoGenderFemale.Size = new System.Drawing.Size(39, 17);
            this.rdoGenderFemale.TabIndex = 4;
            this.rdoGenderFemale.TabStop = true;
            this.rdoGenderFemale.Text = "Nữ";
            this.rdoGenderFemale.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(28, 358);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(79, 50);
            this.btnAddNewCustomer.TabIndex = 7;
            this.btnAddNewCustomer.Text = "Thêm";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.Location = new System.Drawing.Point(172, 358);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(79, 50);
            this.btnCancelCustomer.TabIndex = 8;
            this.btnCancelCustomer.Text = "Huỷ bỏ";
            this.btnCancelCustomer.UseVisualStyleBackColor = true;
            this.btnCancelCustomer.Click += new System.EventHandler(this.btnCancelCustomer_Click);
            // 
            // frmAddCustomer
            // 
            this.AcceptButton = this.btnAddNewCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 429);
            this.Controls.Add(this.btnCancelCustomer);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.rdoGenderFemale);
            this.Controls.Add(this.rdoGenderMale);
            this.Controls.Add(this.dateTimeCustomerBirthDate);
            this.Controls.Add(this.txtCustomerPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimeCustomerBirthDate;
        private System.Windows.Forms.RadioButton rdoGenderMale;
        private System.Windows.Forms.RadioButton rdoGenderFemale;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnCancelCustomer;
    }
}