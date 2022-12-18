using Merchant_Monetary_System.Forms.Emails;
using Merchant_Monetary_System.Forms.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    public partial class frmEmployeeDashboard : Form
    {
        public frmEmployeeDashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.tParent.Controls.Count > 0)
                this.tParent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tParent.Controls.Add(f);
            this.tParent.Tag = f;
            f.Show();
        }
        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStriplblDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            toolStriplblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(2));
        }

        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAccountDetails(false));
        }

        private void btnAddWarehouseManger_Click(object sender, EventArgs e)
        {
            loadform(new frmAddWarehouse());
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmLogin());
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            loadform(new frmViewOrders());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            loadform(new frmAddProduct());
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            loadform(new frmProductDetails_());
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            loadform(new frmAddStock());
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            loadform(new frmEmail());
        }

        private void btnAddPayament_Click(object sender, EventArgs e)
        {
            loadform(new frmAddPayment());
        }

        private void riderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
