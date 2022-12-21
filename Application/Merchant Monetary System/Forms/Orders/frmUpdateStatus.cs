using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;

namespace Merchant_Monetary_System
{
    public partial class frmUpdateStatus : Form
    {
        BL.Order previous=new Order();
        string role;
        public frmUpdateStatus(Order previous,string role)
        {
            InitializeComponent();
            this.previous =previous;   
            this.role =role;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmUpdateStatus_Load(object sender, EventArgs e)
        {
            cmbxStatus.Text = previous.Status;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                previous.UpdateOrderStatus(cmbxStatus.Text);
                MessageBox.Show("Status Updated");
                this.Hide();
                //Misc.sendEmail(UsersDL.GetEmail(previous.ShopKeeperName), "Order Status","Your Order is "+cmbxStatus.Text,role);

            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
        //
        private void cmbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
