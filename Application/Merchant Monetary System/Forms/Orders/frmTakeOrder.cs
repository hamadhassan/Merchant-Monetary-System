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
                    Form form = new frmUpdateProduct(S);
                    form.ShowDialog();
                    ProductDL.storeAllRecordIntoFile(FilePath.Products);
                }
                else if (index == 8)
                {
                    bool done = ProductDL.deleteRecord(S);
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
                if (ProductDL.ProductList1.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }
    }
}
