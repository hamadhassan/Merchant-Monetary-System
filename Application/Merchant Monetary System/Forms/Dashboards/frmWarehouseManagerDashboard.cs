using System;
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
        public frmWarehouseManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = new frmViewOrders();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = new frmProductDetails_();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = new frmEmail();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = new frmAddPayment();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
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
    }
}
