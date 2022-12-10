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
        Users previousObj= null;
        public frmSignUp()
        {
            InitializeComponent();
        }
        public frmSignUp(Users previousObj)
        {
            InitializeComponent();
            this.previousObj= previousObj;
        }
        bool isName=true;
        bool isUsername = true;
        bool isPassword = true;
        bool isPasswordConfirm=true;
        bool isCNIC = true;
        bool isEmail = true;
        bool isPhone = true;
        bool isAddress = true;
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            if (previousObj != null)
            {
                cmbxDesignation.Text = previousObj.Designation;
                txtbxName.Text = previousObj.Name;
                txtbxUsername.Text = previousObj.Crediational.Username;
                txtbxNewPassowrd.Text = previousObj.Crediational.Password;
                txtbxConfirmPassword.Text = previousObj.Crediational.Password;
                txtbxCNIC.Text = previousObj.Cnic.ToString();
                if (previousObj.Gender == "Male")
                    rdbtnMale.Checked=true;
                else
                    rdbtnFemale.Checked=true;
                txtbxEmailAddress.Text = previousObj.EmailAddress;
                txtbxContactNumber.Text = previousObj.ContactNumber.ToString();
                rtxtbxHomeAddress.Text = previousObj.HomeAddress;
                txtbxUsername.Enabled = false;
                lblSignUp.Text = "Update Account Information";
                lblSignUp.Left -=130;
                btnCreateAccount.Text = "Update";
                
            }
         
           
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
            else if(txtbxUsername.Text.Length <= 2)
            {//length greater than 3
                lblUsernameSignal.Text = "Username must 3 characters long";
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
            bool isLowercase = false;
            bool isUppercase = false;
            bool isNumber = false;
            bool isSpecialChar = false;
            int i;
            char[] specialCharactor = { '@', '#', '$', '%', '^', '&', '+', '=','_','!'};
            
            
            foreach (char c in newPassword)
            {//islowercase
                if (c >= 'a' && c <= 'z')
                {
                    isLowercase= true;
                    lblNewPasswordSignal.Text = " ";
                    break;
                }
            }
            foreach (char c in newPassword)
            {//isuppercase
                if (c >= 'A' && c <= 'Z')
                {
                    isUppercase = true;
                    lblNewPasswordSignal.Text = " ";
                    break;
                }
            }
            foreach (char c in newPassword)
            {//isnumber
                if (c >= '0' && c <= '9')
                {
                    isNumber=true;
                    lblNewPasswordSignal.Text = " ";
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
                        lblNewPasswordSignal.Text = " ";
                    }
                }
            }
            if (txtbxNewPassowrd.Text == string.Empty)
            {// check is empty
                lblNewPasswordSignal.Text = "Enter the password";
            }
            else if (!isLowercase == true)
            {//check isLowercase
                lblNewPasswordSignal.Text = "Include least one lowercase charactor";
            }
            else if (!isUppercase == true)
            {//check isUppercase
                lblNewPasswordSignal.Text = "Include least one uppercase charactor";
            }
            else if(!isNumber==true)
            {//check isNumber
                lblNewPasswordSignal.Text = "Include least one number";
            }
            else if(!isSpecialChar==true)
            {//check isSpecial charactor
                lblNewPasswordSignal.Text = "Include least one special charactor";
            }
            else if (txtbxNewPassowrd.Text.Length< 8)
            {//check is lenght >8
                lblNewPasswordSignal.Text = "Password must 8 characters long";
            }
            else
            {
                isPassword = false;
            }

        }

        private void txtbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtbxConfirmPassword.Text == txtbxNewPassowrd.Text)
            {
               isPasswordConfirm=false;
                lblConfirmPasswordSignal.Text = " ";
            }
            else
            {
                lblConfirmPasswordSignal.Text = "Password is not matched";
            }
        }

        private void txtbxCNIC_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char num in txtbxCNIC.Text)
            {
                count++;
            }
            Int64 i;
            if (txtbxCNIC.Text == string.Empty)
            {// check is empty
                lblCNICSignal.Text = "Enter the contact number";
                isCNIC = true;
            }
            else if (!Int64.TryParse(txtbxCNIC.Text, out i))
            {//Check isnumber
                lblCNICSignal.Text = "Allowed characters: 0-9";
                isCNIC = true;
            }
            else if (!(count== 13))
            {//check count
                lblCNICSignal.Text = "Lenght must be 13 characters";
                isCNIC = true;
            }
            else
            {//ready for storage
                lblCNICSignal.Text = " ";
                isCNIC = false;
            }
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
            bool isSpecialChar = false;
            foreach (char c in txtbxEmailAddress.Text)
            {//is special charactor
                if (c == '@')
                {
                    isSpecialChar = true;
                    lblEmailAddressSignal.Text = " ";
                }
            }
            if (txtbxEmailAddress.Text == string.Empty)
            {// check is empty
                lblEmailAddressSignal.Text = "Enter the email-address";
            }
            else if (isSpecialChar == false)
            {// check is has @ sign
                lblEmailAddressSignal.Text = "Enter the correct address";
            }
            else
            {//ready for storage
                lblEmailAddressSignal.Text = " ";
                isEmail = false;
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(isName==false && isUsername==false && isPassword==false && isPasswordConfirm==false && 
             isCNIC==false&& isPhone==false && isAddress==false && isEmail == false)
            {//Store Record into file and open login form
                string designation=cmbxDesignation.Text;
                string name=txtbxName.Text;
                string gender;
                if (rdbtnFemale.Checked == true)
                {
                     gender = rdbtnFemale.Text;
                }
                else
                {
                    gender = rdbtnMale.Text;
                }
                double cnic=Convert.ToInt64(txtbxCNIC.Text);
                string emailAddress=txtbxEmailAddress.Text;
                int contactNumber=Convert.ToInt32(txtbxContactNumber.Text);
                string homeAddress=rtxtbxHomeAddress.Text;
                string username = txtbxUsername.Text;
                string password = txtbxNewPassowrd.Text;
                Crediationals crediational = new Crediationals(username, password);
                Users user = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress,crediational);
                UsersDL.UsersList.Add(user);
                //UsersDL.storeRecordIntoFile(user, FilePath.Users);
                
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("All field must be filled correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clearField()
        {
            txtbxName.Clear();
            txtbxNewPassowrd.Clear();
            txtbxConfirmPassword.Clear();
            txtbxCNIC.Clear();
            txtbxContactNumber.Clear();
            txtbxEmailAddress.Clear();
            rtxtbxHomeAddress.Clear();
            txtbxCNIC.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (previousObj != null)
            {
                clearField();
            }
            else
            {
                clearField();
                txtbxUsername.Clear();
            }
            
            
        }
        private void btnShowPassword_MouseHover(object sender, EventArgs e)
        {
            txtbxNewPassowrd.UseSystemPasswordChar = false;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtbxNewPassowrd.UseSystemPasswordChar = true;
        }

        private void btnShowPasswrd2_MouseHover(object sender, EventArgs e)
        {
            txtbxConfirmPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPasswrd2_MouseLeave(object sender, EventArgs e)
        {
            txtbxConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}
