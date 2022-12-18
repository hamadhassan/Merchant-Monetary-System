using Merchant_Monetary_System.Forms.Emails;
using Merchant_Monetary_System.Forms.Product;
using Merchant_Monetary_System.Forms.Users;
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
    public partial class frmCEODashboard : Form
    {
        public frmCEODashboard()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddWarehouseManager_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(1));
        }
        public void loadform(object Form)
        {
            if (this.pParent.Controls.Count > 0)
                this.pParent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.FormBorderStyle= FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pParent.Controls.Add(f);
            this.pParent.Tag = f;
            f.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword());

        }

        private void frmCEODashboard_Load(object sender, EventArgs e)
        {
            ////The following block will be deleted after testing
            ////---------------------------------
            //loadform(new frmAccountDetails());
            //Crediationals crediational = new Crediationals("123", "1");
            //Users user = new Users("CEO", "abc", "male", 1234567891111, "mhhjutt@gmail.com", 123456789, "23232323", crediational);
            //UsersDL.UsersList.Add(user);
            //Crediationals crediational2 = new Crediationals("abc", "1");
            //Users user2 = new Users("CEO", "abc", "Female", 1234567891111, "mhhjutt@gmail.com", 123456789, "23232323", crediational2);
            //UsersDL.UsersList.Add(user2);
            ////--------------------------------
        }

        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAccountDetails(true));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStriplblDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            toolStriplblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(3));
        }

        private void btnAddWarehouseManger_Click(object sender, EventArgs e)
        {
            loadform(new frmAddWarehouse());
        }

        private void viewWarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmWarehouseDetails());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            loadform(new frmAddProduct());
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp());
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            loadform(new frmProductDetails_());
        }

        private void pParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            loadform(new frmAddStock());
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            loadform(new frmViewOrders());
        }

        private void btnAddShopkeeper_Click(object sender, EventArgs e)
        {
            loadform(new frmAddShopkeeper());
        }

        private void btnForgotPassword_Click_1(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword());
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            loadform(new frmEmail());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmLogin();
            f.Show();
        }

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmADDvendor());
        }

        private void updateVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmAddCompnay(true));
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmViewCategory());
        }

        private void addWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddWarehouse());
        }

        private void updateCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void forgotPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword());
        }

        private void viewRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmRoutes());
        }
    }
}
