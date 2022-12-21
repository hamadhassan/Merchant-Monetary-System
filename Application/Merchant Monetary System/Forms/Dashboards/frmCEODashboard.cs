using Merchant_Monetary_System.Forms.Emails;
using Merchant_Monetary_System.Forms.Payment;
using Merchant_Monetary_System.Forms.Product;
using Merchant_Monetary_System.Forms.Users;
using Merchant_Monetary_System.Forms.Vehicle;
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
    public partial class frmCEODashboard : Form
    {
        string role;
        public frmCEODashboard(string role)
        {
            InitializeComponent();
            this.role = role;   
        }
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
            try
            {
                if (this.pParent.Controls.Count > 0)
                    this.pParent.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.FormBorderStyle = FormBorderStyle.None;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.pParent.Controls.Add(f);
                this.pParent.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
           
        }

        private void frmCEODashboard_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadform(new frmAbout());
        }

        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadform(new frmAccountDetails(true));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                toolStriplblDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
                toolStriplblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmSignUp(3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddWarehouseManger_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmAddWarehouse());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void viewWarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmWarehouseDetails());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmAddProduct());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmSignUp());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmProductDetails_());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pParent_Paint(object sender, PaintEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmAddStock());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmOrderDetail(role));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnAddShopkeeper_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmAddShopkeeper());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnForgotPassword_Click_1(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmForgetPassword(true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmEmail());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form f = new frmLogin();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmADDvendor());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmViewReports());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmAddCompnay(true));
        }

        private void addWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new frmAddWarehouse());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword(true));
        }

        private void viewRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmRoutes());
        }

        private void viewRiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAccountDetails(true));
        }

        private void addRiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(3));
        }

        private void addAddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAccountDetails(true));
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(3));
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddProduct());
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmProductDetails_());
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddStock());
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmViewStocks());
        }

        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmViewReports());
        }

        private void viewVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmVendorDetails());
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddPayment());
        }

        private void viewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmViewLedger());
        }

        private void addWarehouseManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(3));
        }

        private void viewWarehouseManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAccountDetails(true));
        }

        private void addShopAndShopKeeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddShopkeeper());
        }

        private void viewShopAndShopkeeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ViewShopkeeperDetails());
        }

        private void viewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmViewVehicleData());
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddVehicle());  
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAbout());
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmEmail());
        }
    }
}
