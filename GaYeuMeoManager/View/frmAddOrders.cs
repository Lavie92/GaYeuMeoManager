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

namespace GaYeuMeoManager.View
{
    public partial class frmAddOrdersDetail : Form
    {

        GymContext gymContext = new GymContext();
        public frmAddOrdersDetail()
        {
            InitializeComponent();
        }

        private void frmAddOrders_Load(object sender, EventArgs e)
        {
            cbxCustomer.DataSource = gymContext.Customers.ToList();
            cbxCustomer.ValueMember = "CustomerId";
            cbxCustomer.DisplayMember = "CustomerName";

            cbxSubscription.DataSource = gymContext.GymSubscriptions.ToList();
            cbxSubscription.ValueMember = "SubscriptionId";
            cbxSubscription.DisplayMember = "SubscriptionName";

            cbxStaff.DataSource = gymContext.Staffs.ToList();
            cbxStaff.ValueMember = "StaffId";
            cbxStaff.DisplayMember = "StaffName";
            

        }
        private void AddOrdersDetail(int orderId, int subscriptionId, int totalOrdersDetail, int quantity)
        {
            
            OrdersDetail ordersDetail = new OrdersDetail();
            ordersDetail.OrdersId = orderId;
            ordersDetail.SubscriptionId = subscriptionId;
            ordersDetail.TotalOrdersDetail = totalOrdersDetail;
            ordersDetail.Quantity = quantity;
             
            gymContext.OrdersDetails.Add(ordersDetail);
        }
        private int addOrders(int customerId, int staffId, int Total)
        {
            try
            {
                Orders orders = new Orders();
                orders.DateCreate = DateTime.Now;
                orders.CustomerId = customerId;
                orders.StaffId = staffId;
                orders.Total = Total;
                gymContext.Orders.Add(orders);
                gymContext.SaveChanges();
                return orders.OrdersId;
            }
            catch (Exception ex)
            {
                throw new Exception("loi them HD " + ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddOrdersDetail_Click(object sender, EventArgs e)
        {
            cbxSubscription.ValueMember = "SubscriptionId";

            int quantity = Convert.ToInt32(numericQuantity.Value);
            if (quantity <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            else
            {
                int customerId = Convert.ToInt32(cbxCustomer.SelectedValue);
                int staffId = Convert.ToInt32(cbxStaff.SelectedValue);
                int subscriptionId = Convert.ToInt32(cbxSubscription.SelectedValue);
                int price = (from a in gymContext.GymSubscriptions
                                            join c in gymContext.OrdersDetails on a.SubscriptionId equals c.SubscriptionId
                                            where c.SubscriptionId == subscriptionId
                                            select a.Price).FirstOrDefault();
                int totalOrdersDetail = Convert.ToInt32(quantity * price);
                int total = Convert.ToInt32((decimal)totalOrdersDetail);
                int ordersId = addOrders(customerId, staffId, total);

                try
                {

                    AddOrdersDetail(ordersId, subscriptionId, totalOrdersDetail, quantity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                dgvOrdersDetail.Rows.Add(ordersId, subscriptionId, quantity, totalOrdersDetail);
                gymContext.SaveChanges();
            }
            
        }

        
    }

    
}
