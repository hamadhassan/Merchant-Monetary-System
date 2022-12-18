using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System.Forms.Users
{
    public partial class frmUpdateVendor : Form
    {
        Vendor vendor;
        public frmUpdateVendor(Vendor p_vendor)
        {
            InitializeComponent();
            vendor = p_vendor;
        }

        bool isName = true;
        bool isContactNumber = true;
        bool isLandLineNumber = true;
        bool isPerson = true;


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxName.Clear();
            txtbxContactNumber.Clear();
            txtbxLandLineNumber.Clear();
            txtbxPerson.Clear();
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



        private void txtbxName_TextChanged_1(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {// check is empty
                lblNameMessage.Text = "Enter the name";
                isName = true;
            }
            else if (int.TryParse(txtbxName.Text, out i))
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

        private void txtbxLandLineNumber_TextChanged_1(object sender, EventArgs e)
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

        private void frmUpdateVendor_Load(object sender, EventArgs e)
        {
            txtbxName.Text = vendor.VendorName;
            txtbxContactNumber.Text = vendor.ContactNumber.ToString();
            txtbxLandLineNumber.Text = vendor.LandlineNumber.ToString();
            txtbxPerson.Text=vendor.ConcernedPerson.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isName && !isPerson && !isLandLineNumber && !isContactNumber)
            {
               string name= txtbxName.Text;
               double contact= Convert.ToInt64(txtbxContactNumber.Text) ;
               double landline= Convert.ToInt64(txtbxLandLineNumber.Text) ;
               string person= txtbxPerson.Text;
                Vendor updated_vendor = new Vendor(name, landline, person, contact);
                VendorDL.updateVendorMatch(updated_vendor);
                VendorDL.storeAllRecordIntoFile(FilePath.Vendors);
                MessageBox.Show("Stock Updated Successfully", "Information Message", MessageBoxButtons.OK);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill all fields correctly", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
