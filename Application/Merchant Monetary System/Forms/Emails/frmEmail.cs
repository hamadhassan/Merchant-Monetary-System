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
                sendEmail(To, subject, body,From);
            }
            else
            {
                MessageBox.Show("Must Select From list");
            }
        }
        public void sendEmail(string To, string subject, string body, string From)
        {
            string fromMail = "syedhashir1001@gmail.com";
            string fromPassword = "ovzqzevxjyocsedg";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "From " + From + ": " + subject;
            message.To.Add(new MailAddress(To));
            message.Body = "<html><body>" + "From " + From + "<br>" + body + "</body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true

            };
            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Email Sent Successfully", "Sending...");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
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
    }
}
