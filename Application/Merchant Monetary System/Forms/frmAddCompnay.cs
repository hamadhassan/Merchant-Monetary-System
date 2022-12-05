using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Merchant_Monetary_System
{
    public partial class frmAddCompnay : Form
    {
        public frmAddCompnay()
        {
            InitializeComponent();
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
                frmSignUp frmSignUp = new frmSignUp();
                frmSignUp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("All field must be filled correctly","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {// check is empty
                lblNameSignal.Text = "Enter the name";
                isNameCorrect= true;
            }
            else if (int.TryParse(txtbxName.Text, out i))
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
    }
}
