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
        Users previousObj= null;//this is used for edit button
        bool isCEO=false;//if isCEO true then all task of CEO implemented else Employee
        int roleId = 0; //0 for First time create account, 1 for CEO and 2 for Employee 
        int createAccountFor = 0;//3 for warehouse manger and 4 for rider
        bool isForWarehouseManager=false; // if it is true it means user come for create account for warehouse manager and from the given list delete all other option from cmbxdesignation
        public frmSignUp()
        {
            InitializeComponent();
        }
        public frmSignUp(Users previousObj,bool isCEO)
        {//This is used check whose is user and perform action according to it.(This is only for CEO and Employee to access all or particular data
            InitializeComponent();
            this.previousObj= previousObj;
            this.isCEO= isCEO;
        }
        public frmSignUp(int roleId)
        {// id 1 and 2.This is used in dashboards for check open login form or not only fot CEO and Employee
            InitializeComponent();
            this.roleId = roleId;
        }
        public frmSignUp(bool isForWarehouseManager)
        {
            InitializeComponent();
            this.isForWarehouseManager = isForWarehouseManager;
        }
        //--------------Check is field is filled and user this information for action--------
        bool isName=true; 
        bool isUsername = true;
        bool isPassword = true;
        bool isPasswordConfirm=true;
        bool isCNIC = true;
        bool isEmail = true;
        bool isPhone = true;
        bool isAddress = true;
        //------------------------------------------------------------------------------------
        
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (isName == false && isUsername == false && isPassword == false && isPasswordConfirm == false &&
             isCNIC == false && isPhone == false && isAddress == false && isEmail == false)
            {//Store Record into file and open login form
                string designation = cmbxDesignation.Text;
                string name = txtbxName.Text;
                string gender;
                if (rdbtnFemale.Checked == true)
                {
                    gender = rdbtnFemale.Text;
                }
                else
                {
                    gender = rdbtnMale.Text;
                }
                double cnic = Convert.ToInt64(txtbxCNIC.Text);
                string emailAddress = txtbxEmailAddress.Text;
                int contactNumber = Convert.ToInt32(txtbxContactNumber.Text);
                string homeAddress = rtxtbxHomeAddress.Text;
                string username = txtbxUsername.Text;
                string password = txtbxNewPassowrd.Text;
                Users user=null;
                if (roleId==0 || roleId==1 || roleId == 2)
                {//for ceo and employee
                     user = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress, username, password);
                }
                else if (createAccountFor == 3)
                {//for warehouse manager
                    int warehouseID = cmbxWarehouse.SelectedIndex;
                    user = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress, username, password, warehouseID);
                }
                else if (createAccountFor == 4)
                {//for rider
                    float vehicelID = cmbxVehicle.SelectedIndex;
                    user = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress, username, password, vehicelID);
                }
                if (previousObj != null)
                {//for updating of account
                    if (UsersDL.updateRecord(user))
                    {
                        UsersDL.storeAllRecordIntoFile(FilePath.Users);
                        UsersDL.loadRecordFromFile(FilePath.Users);
                        lblRecordSignal.Text = "Account successfully updated";

                    }
                    else
                    {
                        lblRecordSignal.Text = "There is an error while updating the data";
                    }
                }
                else
                {//for new creation of account
                    UsersDL.UsersList.Add(user);
                    UsersDL.storeRecordIntoFile(user, FilePath.Users);
                    if (roleId == 0)
                    {//open form login form as it it is first time login
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                        this.Hide();
                    }
                    else if (roleId == 1 || roleId == 2)
                    {// close the form as it is open when the dashboard of ceo or rider
                        clearField();
                        txtbxUsername.Clear();
                        lblRecordSignal.Text = "Account successfully created";
                        this.Hide();
                    }
                    else if (createAccountFor == 3)
                    {
                        clearField();
                        txtbxUsername.Clear();
                        lblRecordSignal.Text = "Account successfully created";
                        this.Hide();
                    }
                }
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
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            if (previousObj != null)
            {
                cmbxDesignation.Text = previousObj.Designation;
                txtbxName.Text = previousObj.Name;
                txtbxUsername.Text = previousObj.Username;
                txtbxNewPassowrd.Text = previousObj.Password;
                txtbxConfirmPassword.Text = previousObj.Password;
                txtbxCNIC.Text = previousObj.Cnic.ToString();
                if (previousObj.Gender == "Male")
                    rdbtnMale.Checked = true;
                else
                    rdbtnFemale.Checked = true;
                txtbxEmailAddress.Text = previousObj.EmailAddress;
                txtbxContactNumber.Text = previousObj.ContactNumber.ToString();
                rtxtbxHomeAddress.Text = previousObj.HomeAddress;
                lblSignUp.Text = "Update Account Information";
                lblSignUp.Left -= 130;
                btnCreateAccount.Text = "Update";
                txtbxUsername.Enabled = false;
                if (isCEO == false)
                {//Employee is enter into the sytem then it not able to change the the assign role of worker
                    cmbxDesignation.Enabled = false;
                }
                if (roleId == 2)
                {
                    cmbxDesignation.Items.RemoveAt(0);
                }
                cmbxDesignation.SelectedIndex = 0;
            }
            if (isForWarehouseManager)
            {
                cmbxDesignation.SelectedIndex = 3;
                cmbxDesignation.Enabled = false;
                cmbxWarehouse.SelectedIndex = 0;
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
            {//match the password
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
            {//rider is selected
                lblVehicle.Visible = true;
                cmbxVehicle.Visible = true;
                lblWarehouse.Visible = false;
                cmbxWarehouse.Visible = false;
                createAccountFor = 4;
            }
            else if(cmbxDesignation.SelectedIndex==3)
            {//warehouse is selected
                lblWarehouse.Visible = true;
                cmbxWarehouse.Visible = true;
                lblVehicle.Visible = false;
                cmbxVehicle.Visible = false;
                createAccountFor = 3;
                //add all warehouse 
                foreach (Warehouse w in WarehouseDL.WarehousesList)
                {
                    cmbxWarehouse.Items.Add(w.Name);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void btnShowPassword_MouseHover(object sender, EventArgs e)
        { //hide password
            txtbxNewPassowrd.UseSystemPasswordChar = false;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {//show password
            txtbxNewPassowrd.UseSystemPasswordChar = true;
        }

        private void btnShowPasswrd2_MouseHover(object sender, EventArgs e)
        {//hide password
            txtbxConfirmPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPasswrd2_MouseLeave(object sender, EventArgs e)
        {//show password
            txtbxConfirmPassword.UseSystemPasswordChar = true;
        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e)
        {//remove signals
            lblRecordSignal.Text = " ";
        }
    }
}
