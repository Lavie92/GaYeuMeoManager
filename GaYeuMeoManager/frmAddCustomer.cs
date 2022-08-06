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
    public partial class frmAddCustomer : Form
    {
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
    }
}
