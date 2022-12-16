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
using System.Xml.Linq;

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

        bool isName = true;
        bool isSKU_Number = true;
        bool isWeight = true;
        bool isVolume = true;
        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            txtbxName.Text = product.Name;
            txtbxSKU_ID.Text = product.SKU_Number.ToString();
            txtbxWeight.Text = product.Weight.ToString();
            txtbxVolume.Text = product.Volume.ToString();
            comboCategory.Text=product.Category.ToString();
            cmbxManufacture.Text = product.Manufacturer.ToString();
            cmbxSenstivity.Text = product.SensitivityType.ToString();

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
            try
            {
                if (!isName && !isSKU_Number && !isWeight && !isVolume && comboCategory.Text != "" && cmbxManufacture.Text != "" && cmbxSenstivity.Text != "")
                {
                    string name = txtbxName.Text;
                    int sku_number = Convert.ToInt16(txtbxSKU_ID.Text);
                    double weight = Convert.ToInt64(txtbxWeight.Text);
                    double Volume = Convert.ToInt64(txtbxVolume.Text);
                    string manufacturer = cmbxManufacture.Text;
                    string category = comboCategory.Text;
                    string sensitivity = cmbxSenstivity.Text;
                    BL.Product product = new BL. Product(name, sku_number, weight, Volume, manufacturer, sensitivity, category);
                    ProductDL.updateRecord(product);
                    BL.Product.storeRecordIntoFile(product, FilePath.Products);
                    MessageBox.Show("Product successfully updated");
                }
                else
                {
                    MessageBox.Show("Product not updated");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

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

        private void gbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxSKU_ID_TextChanged(object sender, EventArgs e)
        {
            {
                int i;
                if (txtbxSKU_ID.Text == string.Empty)
                {// check is empty
                    lblS_Number.Text = "Enter the SKU number";
                    isSKU_Number = true;
                }
                else if (!int.TryParse(txtbxSKU_ID.Text, out i))
                {//Check isalphabetic
                    lblS_Number.Text = "Allowed characters: 0-9";
                    isSKU_Number = true;
                }
                else if (txtbxSKU_ID.Text.Any(ch => !char.IsLetterOrDigit(ch)))
                {//check isSpecialCharactor
                    lblS_Number.Text = "Allowed characters: 0-9";
                    isSKU_Number = true;
                }
                else
                {//ready for storage
                    lblS_Number.Text = " ";
                    isSKU_Number = false;
                }
            }
        }

        private void txtbxWeight_TextChanged(object sender, EventArgs e)
        {
            {
                int i;
                if (txtbxWeight.Text == string.Empty)
                {// check is empty
                    lbl_Weight.Text = "Enter the Weight";
                    isWeight = true;
                }
                else if (txtbxWeight.Text.Any(ch => !char.IsDigit(ch)))
                {//check isSpecialCharactor
                    lbl_Weight.Text = "Allowed characters: 0-9";
                    isWeight = true;
                }
                else
                {//ready for storage
                    lbl_Weight.Text = " ";
                    isWeight = false;
                }
            }
        }

        private void txtbxVolume_TextChanged(object sender, EventArgs e)
        {
            {
                int i;
                if (txtbxVolume.Text == string.Empty)
                {// check is empty
                    lbl_Volume.Text = "Enter the Volume";
                    isVolume = true;
                }
                //else if (!int.TryParse(txtbxSKU_ID.Text, out i))
                //{//Check isalphabetic
                //    lbl_Volume.Text = "Allowed characters: 0-9";
                //    isVolume = true;
                //}
                else if (txtbxVolume.Text.Any(ch => !char.IsDigit(ch)))
                {//check isSpecialCharactor
                    lbl_Volume.Text = "Allowed characters: 0-9";
                    isVolume = true;
                }
                else
                {//ready for storage
                    lbl_Volume.Text = " ";
                    isVolume = false;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
