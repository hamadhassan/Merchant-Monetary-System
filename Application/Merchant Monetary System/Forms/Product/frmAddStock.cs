using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System;
using Merchant_Monetary_System.Forms.Product;

namespace Merchant_Monetary_System
{
    public partial class frmAddStock : Form
    {
        bool isQuantity = true;
        bool isRetailPrice = true;
        bool isCostPrice = true;
        private List<Stock> newStock = new List<Stock>();

        public frmAddStock()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            comboBoxProduct.DataSource = ProductDL.ProductList1;
            comboBoxVendor.DataSource = VendorDL.VendorList;
            DGVStock.DataSource = newStock;
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            DGVStock.Columns.Add(Update);
            DGVStock.Columns.Add(Delete);
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

        private void btnAddTStock_Click(object sender, EventArgs e)
        {
            if(!isQuantity && !isRetailPrice && !isCostPrice && comboBoxProduct.Text != "" && comboBoxVendor.Text != "")
            {
                string product = (comboBoxProduct.Text);
                int quantity = int.Parse(txtbxQuantity.Text);
                double retailPrice = double.Parse(txtbxRetailPrice.Text);
                double costPrice = double.Parse(txtbxCostPrice.Text);
                DateTime manufacturingDate = DateTime.Parse(DateMFG.Text);
                DateTime expiryDate = DateTime.Parse(DateExpiry.Text);
                DateTime receivedDate = DateTime.Parse(DateReceived.Text);
                string vendor = comboBoxVendor.Text;
                Stock stock = new Stock(product, quantity, retailPrice, costPrice, manufacturingDate, expiryDate, receivedDate, vendor);
                Stock S = StockDL.AlreadyStockAdded(newStock, stock);
                if(S == null)
                {
                    StockDL.addStockIntoList(newStock, stock);
                }
                else
                {
                    S.addQuantity(quantity);
                }
                StockDL.StoreDataIntoFile(FilePath.Stock);
                DataBind();
            }
        }
        private void DataBind()
        {
            DGVStock.Columns.Clear();
            DGVStock.DataSource = null;
            DGVStock.DataSource = newStock;
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            DGVStock.Columns.Add(Update);
            DGVStock.Columns.Add(Delete);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxCostPrice.Clear();
            txtbxQuantity.Clear();
            txtbxRetailPrice.Clear();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(newStock.Count !=0)
            {
                StockDL.MergeStock(newStock, StockDL.StockList);
            }
            else
            {
                MessageBox.Show("Please Add Some Stock First");
            }
        }

        private void DGVStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVStock.SelectedRows.Count == 1)
            {
                int index = DGVStock.CurrentCell.ColumnIndex;
                Stock S = (Stock)DGVStock.CurrentRow.DataBoundItem;
                if (index == 8)
                {
                    Form form = new UpdatStock(S);
                    form.ShowDialog();
                    StockDL.StoreDataIntoFile(FilePath.Stock);
                }
                else if (index == 9)
                {
                    bool done = StockDL.deleteStock(StockDL.StockList, S);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if(newStock.Count != 0)
                lblRowSignal.Text = "Select a row from the list";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
