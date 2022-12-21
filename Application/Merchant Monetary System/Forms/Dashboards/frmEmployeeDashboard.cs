using Merchant_Monetary_System.Forms.Emails;
using Merchant_Monetary_System.Forms.Payment;
using Merchant_Monetary_System.Forms.Product;
using Merchant_Monetary_System.Reports;
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
        string role;
        public frmEmployeeDashboard(string role)
        {
            InitializeComponent();
            this.role = role;   
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
            loadform(new frmOrderDetail(role));
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

        private void frmEmployeeDashboard_Load(object sender, EventArgs e)
        {
            loadform(new frmAbout());
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void forgotDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword(true));
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmEmail());
        }

        private void addRiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(2));
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(2));
        }

        private void viewRidersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAccountDetails(false));
        }

        private void addProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmAddProduct());
        }

        private void viewProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmProductDetails_());
        }

        private void addStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmAddStock());
        }

        private void viewStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmViewStockDetails());
        }

        private void viewOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmOrderDetail());
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddCategory());
        }

        private void viewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmViewCategory());
        }

        private void viewReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmViewReports());
        }

        private void addVendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmADDvendor());
        }

        private void viewVendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmVendorDetails());
        }

        private void addPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             loadform(new frmAddPayment());
        }

        private void viewPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            loadform(new frmViewLedger());
        }

        private void addShopAndShopKeeperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmAddShopkeeper());
        }

        private void viewShopAndShopKeeperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new ViewShopkeeperDetails());
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmAbout());
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            loadform(new frmRoutes());
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            loadform(new frmOrderDetail());
        }
    }
}
