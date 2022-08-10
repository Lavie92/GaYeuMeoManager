using GaYeuMeoManager.Models;
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

namespace GaYeuMeoManager.View
{
    public partial class frmLogin : Form
    {
        GymContext GymContext = new GymContext();
        public frmLogin()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var myaccount = GymContext.Accounts.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (myaccount != null)
            {
                frmHome frmHome = new frmHome(username, password);
                this.Hide();
                frmHome.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!", "Lỗi đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
