using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Merchant_Monetary_System
{
    public partial class frmAddCompnay : Form
    {
        bool isForUpdate;
        public frmAddCompnay()
        {
            InitializeComponent();
        }
        public frmAddCompnay(bool isForUpdate)
        {
            InitializeComponent();
            this.isForUpdate = isForUpdate;
        }
        bool isNameCorrect=true;
        bool isContactNumberCorrect=true;
        bool isAddressCorrect=true;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxName.Clear();
            txtbxContactNumber.Clear();
            rtxtbxAddress.Clear();
            
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (isNameCorrect == false && isContactNumberCorrect==false && isAddressCorrect==false)
            {
                
                string name = txtbxName.Text;
                string address = rtxtbxAddress.Text;
                int phone = int.Parse(txtbxContactNumber.Text);
                Compnay compnay =new Compnay(name, address, phone);
                if (isForUpdate == false)
                {
                    UsersDL.loadRecordFromFile(FilePath.Users);
                    CompanyDL.storeRecordIntoFile(compnay, FilePath.Company);
                    frmSignUp frmSignUp = new frmSignUp();
                    frmSignUp.Show();
                    this.Hide();
                }
                else
                {
                    compnay.updateRecord(compnay);
                    CompanyDL.storeRecordIntoFile(compnay, FilePath.Company);
                    this.Hide();
                }
                


            }
            else
            {
                MessageBox.Show("All field must be filled correctly","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
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
                isNameCorrect= true;
            }
            else if (isValidString(txtbxName.Text) == false)
            {//Check isnumberic
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isNameCorrect = true;
            }
            else if(txtbxName.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isNameCorrect = true;
            }
            else
            {//ready for storage
                lblNameSignal.Text = " ";
                isNameCorrect = false;
            }
        }

        private void txtbxContactNumber_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxContactNumber.Text == string.Empty)
            {// check is empty
                lblContactNumberSignal.Text = "Enter the contact number";
                isContactNumberCorrect = true;
            }
            else if (!int.TryParse(txtbxContactNumber.Text, out i))
            {//Check isalphabetic
                lblContactNumberSignal.Text = "Allowed characters: 0-9";
                isContactNumberCorrect = true;
            }
            else if (txtbxContactNumber.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblContactNumberSignal.Text = "Allowed characters: 0-9";
                isContactNumberCorrect = true;
            }
            else
            {//ready for storage
                lblContactNumberSignal.Text = " ";
                isContactNumberCorrect = false;
            }
        }

        private void rtxtbxAddress_TextChanged(object sender, EventArgs e)
        {
            if (rtxtbxAddress.Text == string.Empty)
            {// check is empty
                lblAddressSignal.Text = "Enter the address";
                isAddressCorrect = true;
            }
            else
            {//ready for storage
                lblAddressSignal.Text = " ";
                isAddressCorrect = false;
            }
        }

        private void frmAddCompnay_Load(object sender, EventArgs e)
        {
            if (isForUpdate)
            {
                CompanyDL.loadRecordFromFile(FilePath.Company);
                Compnay compnay  = Compnay.GetInstance();
                txtbxName.Text=compnay.Name;
                rtxtbxAddress.Text= compnay.Address;
                txtbxContactNumber.Text=compnay.Phone.ToString();
                lblAddCompany.Text = "Update Compnay";
                btnNext.Text = "Update";
            }
        }
    }
}
