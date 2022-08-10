using GaYeuMeoManager.Models;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaYeuMeoManager.View
{

    public partial class frmHome : Form
    {
        GymContext gymContext = new GymContext();
        public frmHome(string username, string password)
        {
            InitializeComponent();
            var roleId = (from a in gymContext.Accounts
                          join ap in gymContext.AccountPermissions on a.AccountId equals ap.AccountId
                          where a.Username == username && a.Password == password
                          select ap.PermissionId)
             .SingleOrDefault();
            if (roleId == 2)
            {
                groupBox1_Orders.Enabled = false;
                groupBox2_Supscription.Enabled = false;
                groupBox1_Subscription.Enabled = false;
            }
            CenterToParent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //groupBox1.Hide();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = gymContext.Customers.ToList();
            dgvSubscription.AutoGenerateColumns = false;
            dgvSubscription.DataSource = gymContext.GymSubscriptions.ToList();
            dgvSubscription.AutoGenerateColumns = false;
            dgvSubscription.DataSource = gymContext.GymSubscriptions.ToList<GymSubscription>();
            txtCustomerId.Text = dgvCustomer.SelectedCells[0].Value.ToString();
            RefreshOrders();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var chillView = new frmAddCustomer();
            chillView.ShowDialog();
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = gymContext.Customers.ToList<Customer>();
        }

        private void btnAddSubscription_Click(object sender, EventArgs e)
        {
            frmAddSubscription frmAddSubscription = new frmAddSubscription();
            frmAddSubscription.ShowDialog();
        }

        private void btnRefreshSubscription_Click(object sender, EventArgs e)
        {
            dgvSubscription.AutoGenerateColumns = false;
            dgvSubscription.DataSource = gymContext.GymSubscriptions.ToList<GymSubscription>();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            frmAddOrdersDetail frmAddOrders = new frmAddOrdersDetail();
            frmAddOrders.ShowDialog();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerId = (int)dgvCustomer.SelectedCells[0].Value;
            var customerdel = (from s in gymContext.Customers where s.CustomerId == customerId select s).First();
            gymContext.Customers.Remove(customerdel);
            gymContext.SaveChanges();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = gymContext.Customers.ToList();
        }
        int indexRow;

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvCustomer.Rows[indexRow];
            txtCustomerId.Text = row.Cells[0].Value.ToString();
            txtCustomerName.Text = row.Cells[1].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            dateTimeBirthDate.Text = row.Cells[2].Value.ToString();
            txtPhoneNumber.Text = row.Cells[5].Value.ToString();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dgvCustomer.Rows[indexRow];
            newDataRow.Cells[1].Value = txtCustomerName.Text;
            newDataRow.Cells[2].Value = dateTimeBirthDate.Value;
            newDataRow.Cells[3].Value = rdoMale.Checked ? true : false;
            newDataRow.Cells[4].Value = txtEmail.Text;
            newDataRow.Cells[5].Value = txtPhoneNumber.Text;
            Customer customer = new Customer();

            using (GymContext context = new GymContext())
            {
                int customerId = Int32.Parse(txtCustomerId.Text);
                customer = context.Customers.Where(d => d.CustomerId == customerId).FirstOrDefault();
                customer.CustomerName = txtCustomerName.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;
                customer.BirthDate = dateTimeBirthDate.Value;
                customer.Gender = rdoMale.Checked ? true : false;
                customer.Email = txtEmail.Text;
                context.SaveChanges();
            }
        }

      
        private void RefreshOrders()
        {
            var entryPoint = (from s in gymContext.GymSubscriptions
                              join od in gymContext.OrdersDetails on s.SubscriptionId equals od.SubscriptionId
                              join o in gymContext.Orders on od.OrdersId equals o.OrdersId
                              join c in gymContext.Customers on o.CustomerId equals c.CustomerId

                              select new
                              {
                                  OrdersId = o.OrdersId,
                                  CustomerId = o.CustomerId,
                                  CustomerName = c.CustomerName,
                                  Staff = o.StaffId,
                                  SubscriptionName = s.SubscriptionName,
                                  DateCreate = o.DateCreate,
                                  Total = o.Total,
                                  Quantity = od.Quantity
                              }).ToList();
            dgvOrders.DataSource = entryPoint;
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }
        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            int ordersId = (int)dgvOrders.SelectedCells[0].Value;
            var ordersDel = (from s in gymContext.Orders where s.OrdersId == ordersId select s).First();
            gymContext.Orders.Remove(ordersDel);
            gymContext.SaveChanges();
            RefreshOrders();
        }

        private void btnDeleteSubscription_Click(object sender, EventArgs e)
        {
            int subscriptionId = (int)dgvSubscription.SelectedCells[0].Value;
            var subscriptionDel = (from s in gymContext.GymSubscriptions where s.SubscriptionId == subscriptionId select s).First();
            gymContext.GymSubscriptions.Remove(subscriptionDel);
            gymContext.SaveChanges();
            dgvSubscription.AutoGenerateColumns = false;
            dgvSubscription.DataSource = gymContext.GymSubscriptions.ToList();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ảe you sủe đăng xuất khỏi trái đất?", "Bạn chắc chứ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                this.Hide();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void xemThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void xuấtFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void inHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fanpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hotlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Đợi 1 chút", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
