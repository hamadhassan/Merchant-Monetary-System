using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Merchant_Monetary_System
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }
        private void clearField()
        {
            txtbxName.Clear();
            txtbxSKU_ID.Clear();
            txtbxWeight.Clear();
            txtbxVolume.Clear();
        }
        //--------------Check is field is filled and user this information for action--------
        bool isName = true;
        bool isSKU_Number = true;
        bool isWeight = true;
        bool isVolume = true;

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }
        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {
                // check is empty
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

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Hide();
        }
    }
}
