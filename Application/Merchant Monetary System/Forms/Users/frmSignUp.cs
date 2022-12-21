using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    public partial class frmSignUp : Form
    {
        Users previousObj= null;//this is used for edit button
        bool isCEO=false;//if isCEO true then all task of CEO implemented else Employee
        int roleId = 0; //0 for First time create account, 1 for CEO and 2 for Employee 3 for just sigup not for account update
        int createAccountFor = 0;//3 for warehouse manger and 4 for rider to call relivent object 
        bool isForWarehouseManager=false; // It true means it come for add warehouue manager 
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
                double contactNumber = Convert.ToInt64(txtbxContactNumber.Text);
                string homeAddress = rtxtbxHomeAddress.Text;
                string username = txtbxUsername.Text;
                string password = txtbxNewPassowrd.Text;
                string assigned = cmbxAssigned.Text;
                Users user = new Users(designation, name, gender, cnic, emailAddress, contactNumber, homeAddress, username, password, assigned);
                if (previousObj != null)
                {//for updating of account
                    if (UsersDL.updateRecord(user))
                    {
                        UsersDL.storeAllRecordIntoFile(FilePath.Users);
                        lblRecordSignal.Text = "Account successfully updated";
                        this.Hide();
                    }
                    else
                    {
                        lblRecordSignal.Text = "There is an error while updating the data";
                    }
                }
                else
                {//for new creation of account
                    UsersDL.UsersLinkedList.Add(user);
                    UsersDL.storeAllRecordIntoFile(FilePath.Users);
                    if (roleId == 0)
                    {//open form login form as it it is first time login
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                        this.Hide();
                    }
                    else if (roleId == 1 || roleId == 2 || createAccountFor==3 || createAccountFor==4)
                    {// close the form as it is open when the dashboard of ceo or rider
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
                cmbxDesignation.SelectedIndex = 0;
                cmbxAssigned.Text = previousObj.Assigned;
                if (isCEO == true)
                {//Employee is enter into the sytem then it not able to change the the assign role of worker
                    cmbxDesignation.Enabled = false;
                    cmbxDesignation.SelectedIndex = 0;
                }
                if (roleId == 2)
                {
                    cmbxDesignation.Items.RemoveAt(0);
                    cmbxDesignation.SelectedIndex = 0;
                }
            }
            else
            {
                cmbxDesignation.SelectedIndex = 0;
            }
            if (isForWarehouseManager)
            {
                cmbxDesignation.SelectedIndex = 3;
                cmbxDesignation.Enabled = false;
                cmbxAssigned.SelectedIndex = 0;
            }
            


        }
         private bool isValidEmail(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        public bool isValidString(string input)
        {
            bool isValid = true;
            isValid = Regex.IsMatch(input, @"^[a-zA-Z]+$");
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                    isValid = false;
            }
            return isValid;
        }
        
        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {// check is empty
                lblNameSignal.Text = "Enter the name";
                isName = true;
            }
            else if (isValidString(txtbxName.Text)==false)
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
            try
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
                else if (txtbxUsername.Text.Length <= 2)
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
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void txtbxNewPassowrd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newPassword = txtbxNewPassowrd.Text;
                bool isLowercase = false;
                bool isUppercase = false;
                bool isNumber = false;
                bool isSpecialChar = false;
                int i;
                char[] specialCharactor = { '@', '#', '$', '%', '^', '&', '+', '=', '_', '!' };


                foreach (char c in newPassword)
                {//islowercase
                    if (c >= 'a' && c <= 'z')
                    {
                        isLowercase = true;
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
                        isNumber = true;
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
                else if (!isNumber == true)
                {//check isNumber
                    lblNewPasswordSignal.Text = "Include least one number";
                }
                else if (!isSpecialChar == true)
                {//check isSpecial charactor
                    lblNewPasswordSignal.Text = "Include least one special charactor";
                }
                else if (txtbxNewPassowrd.Text.Length < 8)
                {//check is lenght >8
                    lblNewPasswordSignal.Text = "Password must 8 characters long";
                }
                else
                {
                    isPassword = false;
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
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
            Int64 i;
            if (txtbxContactNumber.Text == string.Empty)
            {// check is empty
                lblContactNumberSignal.Text = "Enter the contact number";
                isPhone = true;
            }
            else if (!Int64.TryParse(txtbxContactNumber.Text, out i))
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
            bool isCorrect = false;
            if (isValidEmail(txtbxEmailAddress.Text))
            {
                isCorrect = true;
                lblEmailAddressSignal.Text = " ";
            }
            if (txtbxEmailAddress.Text == string.Empty)
            {// check is empty
                lblEmailAddressSignal.Text = "Enter the email-address";
            }
            else if (isCorrect == false)
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
           
            if (cmbxDesignation.SelectedIndex == 2)
            {//rider is selected
                lbAssigned.Text = "Vehicle";
                lbAssigned.Visible = true;
                cmbxAssigned.Visible = true;
                createAccountFor = 4;
                //add all vehichle for rider
                //VehicleDL.LoadDataFromFiles(FilePath.Vehcile);
                cmbxAssigned.Items.Clear();
                DoublyLinkedListNode<Vehicle> Head = VehicleDL.VehicleLinkedList.Head;
                while (Head != null)
                {
                    cmbxAssigned.Items.Add(Head.Data.RegistrationNumber);
                    Head = Head.Next;
                }
                cmbxAssigned.SelectedIndex = 0;
            }
            else if(cmbxDesignation.SelectedIndex==3)
            {//warehouse is selected
                lbAssigned.Text = "Warehouse";
                lbAssigned.Visible = true;
                cmbxAssigned.Visible = true;
                createAccountFor = 3;
                //add all warehouse 
                //WarehouseDL.loadRecordFromFile(FilePath.Warehouse);
                cmbxAssigned.Items.Clear();
                DoublyLinkedListNode<Warehouse> Head = WarehouseDL.WarehousesList.Head;
                while(Head!=null)
                {
                    cmbxAssigned.Items.Add(Head.Data.Name);
                    Head = Head.Next;
                }
                cmbxAssigned.SelectedIndex = 0;
            }
            else
            {
                lbAssigned.Visible = false;
                cmbxAssigned.Visible = false;
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

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e)
        {//remove signals
            lblRecordSignal.Text = " ";
        }

        private void txtbxUsername_Leave(object sender, EventArgs e)
        {
            UsersDL.loadRecordFromFile(FilePath.Users);
            if (UsersDL.isUsernameExit(cmbxDesignation.Text, txtbxUsername.Text))
            {
                lblUsernameSignal.Text = "Enter unique username";
            }
            else
            {
                lblUsernameSignal.Text = " ";
                isUsername = false;
            }
        }
    }
}
