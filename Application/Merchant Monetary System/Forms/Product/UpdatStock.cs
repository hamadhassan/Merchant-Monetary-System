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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Merchant_Monetary_System.Forms.Product
{
    public partial class UpdatStock : Form
    {
        Stock stock;
        bool isQuantity = true;
        bool isRetailPrice = true;
        bool isCostPrice = true;
        public UpdatStock(Stock incomingStock)
        {
            InitializeComponent();
            stock = incomingStock;
        }

        private void UpdatStock_Load(object sender, EventArgs e)
        {
            comboBoxProduct.SelectedIndex = comboBoxProduct.Items.IndexOf(stock.Product);
            comboBoxVendor.SelectedIndex = comboBoxVendor.Items.IndexOf(stock.Vendor);
            txtbxQuantity.Text = stock.Quantity.ToString();
            txtbxRetailPrice.Text = stock.RetailPrice.ToString();
            txtbxCostPrice.Text = stock.CostPrice.ToString();
            DateMFG.Text = stock.ManufacturingDate.ToString();
            DateExpiry.Text = stock.ExpiryDate.ToString();
            DateReceived.Text = stock.RecievedDate.ToString();
        }

        private void txtbxCostPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtbxCostPrice.Text == string.Empty)
            {// check is empty
                lblCostPriceValid.Text = "Enter the Price";
                isCostPrice = true;
            }
            else if (txtbxCostPrice.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblCostPriceValid.Text = "Allowed characters: 0-9";
                isCostPrice = true;
            }
            else
            {//ready for storage or action
                lblCostPriceValid.Text = " ";
                isCostPrice = false;
            }
        }

        private void txtbxRetailPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtbxRetailPrice.Text == string.Empty)
            {// check is empty
                lblRetailPriceValid.Text = "Enter the Price";
                isRetailPrice = true;
            }
            else if (txtbxRetailPrice.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblRetailPriceValid.Text = "Allowed characters: 0-9";
                isRetailPrice = true;
            }
            else
            {//ready for storage or action
                lblRetailPriceValid.Text = " ";
                isRetailPrice = false;
            }
        }

        private void txtbxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtbxQuantity.Text == string.Empty)
            {// check is empty
                lblQuantityValid.Text = "Enter the Quantity";
                isQuantity = true;
            }
            else if (txtbxQuantity.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblQuantityValid.Text = "Allowed characters: 0-9";
                isQuantity = true;
            }
            else
            {//ready for storage or action
                lblQuantityValid.Text = " ";
                isQuantity = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtbxQuantity.Text != string.Empty && txtbxCostPrice.Text != string.Empty && txtbxRetailPrice.Text != string.Empty
                && comboBoxProduct.Text != "" && comboBoxVendor.Text != "" && !isQuantity && !isCostPrice && !isRetailPrice)
            {
                stock.Product = comboBoxProduct.Text;
                stock.Quantity = int.Parse(txtbxQuantity.Text);
                stock.CostPrice = double.Parse(txtbxCostPrice.Text);
                stock.RetailPrice = double.Parse(txtbxRetailPrice.Text);
                stock.ManufacturingDate = DateTime.Parse(DateMFG.ToString());
                stock.ExpiryDate = DateTime.Parse(DateExpiry.ToString());
                stock.RecievedDate = DateTime.Parse(DateReceived.ToString());
                stock.Vendor = comboBoxVendor.Text;
                MessageBox.Show("Stock Updated Successfully", "Information Message", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxCostPrice.Clear();
            txtbxQuantity.Clear();
            txtbxRetailPrice.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
