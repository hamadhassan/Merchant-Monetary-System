using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using Merchant_Monetary_System.Forms.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    public partial class frmTakeOrder : Form
    {
        public frmTakeOrder()
        {
            InitializeComponent();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbxRatings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void datagvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                int index = datagvProductDetails.CurrentCell.ColumnIndex;
                Product S = (Product)datagvProductDetails.CurrentRow.DataBoundItem;
                if (index == 7)
                {
                    // ADDD Product to Temprory Order List

                    //ProductDL.storeAllRecordIntoFile(FilePath.Products);
                }
                
            }
            else
            {
                if (ProductDL
                    .ProductList1.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {

        }
        private void DataBind()
        {
            try
            {
                datagvProductDetails.Columns.Clear();

                datagvProductDetails.DataSource = null;
                ProductDL.loadRecordFromFile(FilePath.Products);
                datagvProductDetails.DataSource = ProductDL.ProductList1;
                DataGridViewButtonColumn AddToCart = new DataGridViewButtonColumn();
                AddToCart.HeaderText = "Add To Cart";
                AddToCart.Text = "Add To Cart";
                AddToCart.UseColumnTextForButtonValue = true;
                datagvProductDetails.Columns.Add(AddToCart);



            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
    }
}
