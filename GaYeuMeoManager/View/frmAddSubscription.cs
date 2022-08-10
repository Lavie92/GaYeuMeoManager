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

namespace GaYeuMeoManager.View
{
    public partial class frmAddSubscription : Form
    {
        GymContext GymContext = new GymContext();
        public frmAddSubscription()
        {
            InitializeComponent();
        }

        private void btnAddSubscription_Click(object sender, EventArgs e)
        {
            GymSubscription subscription = new GymSubscription();
            string name = txtSubscriptionName.Text;
            int price = (int)numericSubscriptionPrice.Value;
            subscription.SubscriptionName = name;
            subscription.Price = price;
            GymContext.GymSubscriptions.Add(subscription);
            GymContext.SaveChanges();
        }

        private void btnSubscriptionCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn huỷ không>?", "Bạn chắc chứ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }
    }
}
