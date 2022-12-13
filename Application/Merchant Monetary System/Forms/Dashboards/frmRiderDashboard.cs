﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.Forms.Payment;
using Merchant_Monetary_System.Forms.Emails;

namespace Merchant_Monetary_System.Forms.Dashboards
{
    public partial class frmRiderDashboard : Form
    {
        public frmRiderDashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            loadform(new frmAddPayment());
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            loadform(new frmViewOrders());
        }

        private void btnAddShopkeeper_Click(object sender, EventArgs e)
        {
            loadform(new frmAddShopkeeper());
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            loadform(new frmEmail());
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            loadform(new frmTakeOrder());

        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword());
        }
    }
}