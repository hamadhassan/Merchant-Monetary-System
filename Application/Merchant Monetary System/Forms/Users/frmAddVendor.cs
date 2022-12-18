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
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;

namespace Merchant_Monetary_System
{
    public partial class frmADDvendor : Form
    {
        public frmADDvendor()
        {
            InitializeComponent();
        }


        bool isName = true;
        bool isContactNumber = true;
        bool isLandLineNumber = true;
        bool isPerson = true;


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
                lblNameMessage.Text = "Enter the name";
                isName = true;
            }
            else if (isValidString(txtbxName.Text)==false)
            {//Check isnumberic
                lblNameMessage.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else if (txtbxName.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblNameMessage.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else
            {//ready for storage or action
                lblNameMessage.Text = " ";
                isName = false;
            }
        }

        private void txtbxLandLineNumber_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxLandLineNumber.Text == string.Empty)
            {// check is empty
                lblLandLineNumber.Text = "Enter the contact number";
                isLandLineNumber = true;
            }
            else if (!int.TryParse(txtbxLandLineNumber.Text, out i))
            {//Check isalphabetic
                lblLandLineNumber.Text = "Allowed characters: 0-9";
                isLandLineNumber = true;
            }
            else if (txtbxLandLineNumber.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblLandLineNumber.Text = "Allowed characters: 0-9";
                isLandLineNumber = true;
            }
            else
            {//ready for storage
                lblLandLineNumber.Text = " ";
                isLandLineNumber = false;
            }
        }

        private void txtbxContactNumber_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxContactNumber.Text == string.Empty)
            {
                // check is empty
                lblContactNumber.Text = "Enter the contact number";
                isContactNumber = true;
            }
            else if (!int.TryParse(txtbxContactNumber.Text, out i))
            {
                //Check isalphabetic
                lblContactNumber.Text = "Allowed characters: 0-9";
                isContactNumber = true;
            }
            else if (txtbxContactNumber.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                //check isSpecialCharactor
                lblContactNumber.Text = "Allowed characters: 0-9";
                isContactNumber = true;
            }
            else
            {
                //ready for storage
                lblContactNumber.Text = " ";
                isContactNumber = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

           txtbxName.Clear();
           txtbxContactNumber.Clear();
           txtbxLandLineNumber.Clear();
           txtbxPerson.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (!isName && !isContactNumber && !isLandLineNumber && !isPerson )
                {
                    Vendor vendor = new Vendor(txtbxName.Text, Convert.ToInt64(txtbxLandLineNumber.Text), txtbxPerson.Text, Convert.ToInt64(txtbxContactNumber.Text));
                    VendorDL.addVendorIntoList(vendor);
                    Vendor.storeRecordIntoFile(vendor, FilePath.Vendors);
                    MessageBox.Show("Vendor successfully added");
                }
                else
                {
                    MessageBox.Show("Vendor not added");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPerson_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxPerson.Text == string.Empty)
            {// check is empty
                lblPerson.Text = "Enter the name";
                isPerson = true;
            }
            else if (int.TryParse(txtbxPerson.Text, out i))
            {//Check isnumberic
                lblPerson.Text = "Allowed characters: a-z, A-Z";
                isPerson = true;
            }
            else if (txtbxPerson.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblPerson.Text = "Allowed characters: a-z, A-Z";
                isPerson = true;
            }
            else
            {//ready for storage or action
                lblPerson.Text = " ";
                isPerson = false;
            }
        }
    }
}