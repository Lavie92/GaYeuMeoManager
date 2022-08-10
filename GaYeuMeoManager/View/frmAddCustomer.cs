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
using System.ComponentModel.DataAnnotations;


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
        //public bool IsValidEmail(string source)
        //{
        //    return new EmailAddressAttribute().IsValid(source);
        //}
        private void AddNewCustomer()
        {
            Customer Customer = new Customer();
            string name = txtCustomerName.Text;
            string email = txtCustomerEmail.Text;
            string phone = txtCustomerPhoneNumber.Text;
            DateTime birthDate = dateTimeCustomerBirthDate.Value;
            bool gender = rdoGenderFemale.Checked ? false : true;
            Customer.CustomerName = name;
            Customer.PhoneNumber = phone;
            Customer.BirthDate = birthDate;
            Customer.Gender = gender;
            Customer.Email = email;
            GymContext.Customers.Add(Customer);
            GymContext.SaveChanges();
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            Customer Customer = new Customer();
            string name = txtCustomerName.Text;
            string email = txtCustomerEmail.Text;
            string phone = txtCustomerPhoneNumber.Text;
            DateTime birthDate = dateTimeCustomerBirthDate.Value;
            bool gender = rdoGenderFemale.Checked ? false : true;
            CustomerController customerController = new CustomerController();
            try
            {
                if (!customerController.IsNameValid(name))
                {
                    throw new InvalidCustomerNameException("Tên không hợp lệ");
                }
                if (!customerController.IsPhoneValid(phone))
                {
                    throw new InvalidPhoneException("Số điện thoại không đúng định dạng");
                }
                if (!customerController.IsEmailValid(email))
                {
                    throw new InvalidEmailException("Email không đúng định dạng");
                }
                AddNewCustomer();
                this.Close();
            }
            
            catch (InvalidCustomerNameException ex)
            {
                var msg = ex.Message;
                ShowErrorMessage(ex.Message);

            }
            catch (InvalidEmailException ex)
            {
                ShowErrorMessage(ex.Message);

            }
            catch (InvalidPhoneException ex)
            {
                //var msg = ex.Message;
                //var title = "lỗi dữ liệu";
                //MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowErrorMessage(ex.Message);
            }
            //AddNewCustomer();
            //}
        }
        private void ShowErrorMessage(string msg)
        {
            var title = "Lỗi dữ liệu!";
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
