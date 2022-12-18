using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Merchant_Monetary_System.DL;


namespace Merchant_Monetary_System.Forms.Emails
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {   
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cmbxFrom.Text != "" && cmbxTo.Text != "")
            {
                string To = cmbxTo.Text;
                string subject = txtbxSubject.Text;
                string body = txtBody.Text;
                string From = cmbxFrom.Text;
                Misc.sendEmail(To, subject, body,From);
            }
            else
            {
                MessageBox.Show("Must Select From list");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBody.Clear();
            txtbxSubject.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            foreach(var u in UsersDL.UsersList)
            {
                cmbxTo.Items.Add(u.EmailAddress);
            }
        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }
    }
}
