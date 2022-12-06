using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        bool isName=true;
        bool isUsername = true;
        bool isPassword = true;
        bool isPasswordConfirm=true;
        bool isCNIC = true;
        bool isEmail = true;
        bool isPhone = true;
        bool isAddress = true;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            cmbxDesignation.SelectedIndex = 0;
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {// check is empty
                lblNameSignal.Text = "Enter the name";
                isName = true;
            }
            else if (int.TryParse(txtbxName.Text, out i))
            {//Check isnumberic
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else if (txtbxName.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else
            {//ready for storage or action
                lblNameSignal.Text = " ";
                isName = false;
            }
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxUsername.Text == string.Empty)
            {// check is empty
                lblUsernameSignal.Text = "Enter the username";
                isUsername = true;
            }
            else if (txtbxUsername.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblUsernameSignal.Text = "Allowed characters: a-z, A-Z, 0-9";
                isUsername = true;
            }
            else
            {//ready for storage or action
                lblUsernameSignal.Text = " ";
                isUsername = false;
            }
        }

        private void txtbxNewPassowrd_TextChanged(object sender, EventArgs e)
        {
            string newPassword=txtbxNewPassowrd.Text;
            int validConditions = 0;
            int i;
            char[] specialCharactor = { '@', '#', '$', '%', '^', '&', '+', '=','_','!'};
            
            if (txtbxNewPassowrd.Text == string.Empty)
            {// check is empty
                lblNewPasswordSignal.Text = "Enter the password";
                validConditions++;
            }
            else
            {
                lblNewPasswordSignal.Text = " ";
            }
            
           
            foreach (char c in newPassword)
            {//islowercase
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    //lblNewPasswordSignal.Text = " ";
                    break;
                }
                else
                {
                    lblNewPasswordSignal.Text = "At least one lowercase charactor";
                }

            }
           
            foreach (char c in newPassword)
            {//isuppercase
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    //lblNewPasswordSignal.Text = " ";
                    break;
                }
                else
                {
                    lblNewPasswordSignal.Text = "At least one uppercase charactor";
                }
            }
           
            foreach (char c in newPassword)
            {//isnumber
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    //lblNewPasswordSignal.Text = " ";
                    lblNewPasswordSignal.Text = "At least one number";
                    break;
                }
                else
                {
                   
                }
            }
           
            if (newPassword.IndexOfAny(specialCharactor) == -1)
            {//is special charactor
               
                lblNewPasswordSignal.Text = "At least one special charactor";
            }
            else
            {
                validConditions++;
            }
            
            if (validConditions == 5)
            { // ready for storage or action
                lblNewPasswordSignal.Text = " ";
                isPassword = false;
            }
        }

        private void txtbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtbxConfirmPassword.Text == txtbxNewPassowrd.Text)
            {
               isPasswordConfirm=false;
            }
            else
            {
                lblConfirmPasswordSignal.Text = "Password is not matched";
            }
        }

        private void txtbxCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxContactNumber_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxContactNumber.Text == string.Empty)
            {// check is empty
                lblContactNumberSignal.Text = "Enter the contact number";
                isPhone = true;
            }
            else if (!int.TryParse(txtbxContactNumber.Text, out i))
            {//Check isalphabetic
                lblContactNumberSignal.Text = "Allowed characters: 0-9";
                isPhone = true;
            }
            else if (txtbxContactNumber.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblContactNumberSignal.Text = "Allowed characters: 0-9";
                isPhone = true;
            }
            else
            {//ready for storage
                lblContactNumberSignal.Text = " ";
                isPhone = false;
            }
        }

        private void txtbxEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtbxHomeAddress_TextChanged(object sender, EventArgs e)
        {
            if (rtxtbxHomeAddress.Text == string.Empty)
            {// check is empty
                lblHomeAddressSignal.Text = "Enter the address";
                isAddress = true;
            }
            else
            {//ready for storage
                lblHomeAddressSignal.Text = " ";
                isAddress = false;
            }
        }

        private void cmbxDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxDesignation.SelectedIndex == 2)
            {
                lblVehicle.Visible = true;
                cmbxVehicle.Visible = true;
            }
            else
            {
                lblVehicle.Visible = false;
                cmbxVehicle.Visible = false;
            }
        }
    }
}
