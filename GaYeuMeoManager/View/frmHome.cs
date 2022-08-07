using GaYeuMeoManager.Models;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaYeuMeoManager
{
    public partial class frmHome : Form
    {
        GymContext GymContext = new GymContext();
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var chillView = new frmAddCustomer();
            chillView.ShowDialog();
        }
        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = GymContext.Customers.ToList<Customer>();
            //dgvCustomer.Customers.Load(); 
            //dgvCustomer.DataSource = GymContext.Customers.Local.ToBindingList();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = GymContext.Customers.ToList<Customer>();
        }
    }
}
