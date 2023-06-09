﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.Forms.Emails;
using Merchant_Monetary_System.Forms.Payment;
using Merchant_Monetary_System.Forms;

namespace Merchant_Monetary_System.Forms.Dashboards
{
    public partial class frmWarehouseManagerDashboard : Form
    {
        string role;
        public frmWarehouseManagerDashboard(string role)
        {
            InitializeComponent();
            this.role=role;
        }
        public frmWarehouseManagerDashboard()
        {
            InitializeComponent();
        }
        private void load_form(object Form)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            load_form(new frmOrderDetail(role));
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            load_form(new frmProductDetails_());
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            load_form(new frmEmail());
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            load_form(new frmAddPayment());
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = new frmForgetPassword();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            load_form(new frmForgetPassword());
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            load_form(new frmViewStocks());
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_form(new frmEmail());
        }

        private void forgotPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_form(new frmForgetPassword(true));
        }

        private void orderDeatislToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_form(new frmOrderDetail(role));
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_form(new frmProductDetails_());
        }

        private void viewWarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_form(new frmAbout());  
        }

        private void frmWarehouseManagerDashboard_Load(object sender, EventArgs e)
        {
            load_form(new frmAbout());
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_form(new frmViewStocks());
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
    }
}
