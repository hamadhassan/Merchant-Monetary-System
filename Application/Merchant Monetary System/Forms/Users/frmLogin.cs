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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {//respective dashboard will be open 
            
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgetPassword frmForgetPassword = new frmForgetPassword();
            frmForgetPassword.Show();
            this.Hide();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbxDesignation.SelectedIndex = 0;
        }

        private void cmbxDesignation_Leave(object sender, EventArgs e)
        {
            if (cmbxDesignation.SelectedIndex == 0)
            {
                lblDesignationSingal.Text = "Select a Designation";
            }
            else
            {
                lblDesignationSingal.Text = " ";
            }
        }

        private void btnShowPassword_MouseHover(object sender, EventArgs e)
        {
            txtbxPassowrd.UseSystemPasswordChar=false;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtbxPassowrd.UseSystemPasswordChar = true;
        }
    }
}
