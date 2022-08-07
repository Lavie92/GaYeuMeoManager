using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaYeuMeoManager.Controller;
using GaYeuMeoManager.Models;
using Models;


namespace GaYeuMeoManager
{
    public partial class frmAddCustomer : Form
    {
        GymContext GymContext = new GymContext();
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ảe you sủe?", "Bạn chắc chứ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            Customer Customer = new Customer();
            string name = txtCustomerName.Text;
            string email = txtCustomerEmail.Text;
            string phone = txtCustomerPhoneNumber.Text;
            DateTime birthDate = dateTimeCustomerBirthDate.Value;
            bool gender = rdoGenderFemale.Checked ? false : true;
            try
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || birthDate == null || ((!rdoGenderFemale.Checked) && (!rdoGenderMale.Checked)))
                {
                    string message = "Vui lòng điền đầy đủ thông tin!!";
                    throw new InvalidCustomerNameException(message);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm người này hong?", "Bạn chắc chứ?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Customer.CustomerName = name;
                        Customer.PhoneNumber = phone;
                        Customer.BirthDate = birthDate;
                        Customer.Gender = gender;
                        Customer.Email = email;
                        GymContext.Customers.Add(Customer);
                        GymContext.SaveChanges();
                        this.Close();
                    }
                }
            }
            catch (InvalidCustomerNameException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi dữ liệu!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
