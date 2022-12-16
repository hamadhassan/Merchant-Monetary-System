using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.DL;
using Merchant_Monetary_System.BL;

namespace Merchant_Monetary_System.Forms.Product
{
    public partial class frmUpdateProduct : Form
    {
        BL.Product product; 
        public frmUpdateProduct(BL.Product previous_product)
        {
            InitializeComponent();
            product = previous_product;
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblManufacture_Click(object sender, EventArgs e)
        {

        }

        private void cmbxSenstivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Weight_Click(object sender, EventArgs e)
        {

        }

        private void lblS_Number_Click(object sender, EventArgs e)
        {

        }

        private void lblNameSignal_Click(object sender, EventArgs e)
        {

        }

        private void txtbxVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxSKU_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void lblSKU_Number_Click(object sender, EventArgs e)
        {

        }

        private void lblVolume_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblSensitivity_Type_Click(object sender, EventArgs e)
        {

        }

        private void cmbxManufacture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
        }
        private void clearField()
        {
            txtbxName.Clear();
            txtbxSKU_ID.Clear();
            txtbxWeight.Clear();
            txtbxVolume.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl_Volume_Click(object sender, EventArgs e)
        {

        }
    }
}
