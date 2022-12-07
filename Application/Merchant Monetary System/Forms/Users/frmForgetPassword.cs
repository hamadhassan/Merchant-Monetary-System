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
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        bool isPassword = true;
        bool isPasswordConfirm = true;
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtbxUsername.Clear();
            txtbxPassowrd.Clear();
            txtbxConfirmPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            txtbxPassowrd.UseSystemPasswordChar = false;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtbxPassowrd.UseSystemPasswordChar = true;
        }

        private void btnShowConfirmPassword_MouseHover(object sender, EventArgs e)
        {
            txtbxConfirmPassword.UseSystemPasswordChar = false;
        }

        private void btnShowConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            txtbxConfirmPassword.UseSystemPasswordChar = true;
        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            cmbxDesignation.SelectedIndex = 0;
        }

        private void txtbxPassowrd_TextChanged(object sender, EventArgs e)
        {
            string newPassword = txtbxPassowrd.Text;
            bool isLowercase = false;
            bool isUppercase = false;
            bool isNumber = false;
            bool isSpecialChar = false;
            bool isLength = false;
            int count = 0;
            int i;
            char[] specialCharactor = { '@', '#', '$', '%', '^', '&', '+', '=', '_', '!' };


            foreach (char c in newPassword)
            {//islowercase
                if (c >= 'a' && c <= 'z')
                {
                    isLowercase = true;
                    lblPasswordSignal.Text = " ";
                    break;
                }
            }
            foreach (char c in newPassword)
            {//isuppercase
                if (c >= 'A' && c <= 'Z')
                {
                    isUppercase = true;
                    lblPasswordSignal.Text = " ";
                    break;
                }
            }
            foreach (char c in newPassword)
            {//isnumber
                if (c >= '0' && c <= '9')
                {
                    isNumber = true;
                    lblPasswordSignal.Text = " ";
                    break;
                }
            }
            foreach (char c in newPassword)
            {//is special charactor
                foreach (char s in specialCharactor)
                {
                    if (c == s)
                    {
                        isSpecialChar = true;
                        lblPasswordSignal.Text = " ";
                    }
                }
            }
            foreach (char c in newPassword)
            {
                count++;
                if (count >= 8)
                {
                    isLength = true;
                }
            }
            if (newPassword == string.Empty)
            {// check is empty
                lblPasswordSignal.Text = "Enter the password";
            }
            else if (!isLowercase == true)
            {//check isLowercase
                lblPasswordSignal.Text = "Include least one lowercase charactor";
            }
            else if (!isUppercase == true)
            {//check isUppercase
                lblPasswordSignal.Text = "Include least one uppercase charactor";
            }
            else if (!isNumber == true)
            {//check isNumber
                lblPasswordSignal.Text = "Include least one number";
            }
            else if (!isSpecialChar == true)
            {//check isSpecial charactor
                lblPasswordSignal.Text = "Include least one special charactor";
            }
            else if (!(isLength == true))
            {//check is lenght >8
                lblPasswordSignal.Text = "Password must 8 characters long";
            }
            else
            {
                isPassword = false;
            }
        }

        private void txtbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbxConfirmPassword.Text == txtbxPassowrd.Text)
            {
                isPasswordConfirm = false;
                lblConfirmPasswordSignal.Text = " ";
            }
            else
            {
                lblConfirmPasswordSignal.Text = "Password is not matched";
            }
        }
    }
}
