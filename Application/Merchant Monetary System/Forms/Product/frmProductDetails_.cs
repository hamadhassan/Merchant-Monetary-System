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
    public partial class frmProductDetails_ : Form
    {
        public frmProductDetails_()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void DataBind()
        {
            try
            {
                datagvProductDetails.Columns.Clear();

                datagvProductDetails.DataSource = null;
                ProductDL.loadRecordFromFile(FilePath.Products);
                datagvProductDetails.DataSource = ProductDL.ProductList1;
                DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
                Update.HeaderText = "Update";
                Update.Text = "Update";
                Update.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
                Delete.HeaderText = "Delete";
                Delete.Text = "Delete";

                Delete.UseColumnTextForButtonValue = true;
                datagvProductDetails.Columns.Add(Update);
                datagvProductDetails.Columns.Add(Delete);


            }
            catch(Exception exp) { MessageBox.Show(exp.Message); }
        }
        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvProductDetails.Visible = true;
            DataBind();
        }

        private void datagvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                int index = datagvProductDetails.CurrentCell.ColumnIndex;
                Product  S = (Product)datagvProductDetails.CurrentRow.DataBoundItem;
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
                        ProductDL.storeAllRecordIntoFile(FilePath.Products);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                DataBind();
            }
            else
            {
                if (ProductDL.ProductList1.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }




        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                Product S = (Product)datagvProductDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    ProductDL.deleteRecord(S);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    ProductDL.storeAllRecordIntoFile(FilePath.Products);

                }
            }
            else
            {
                if (ProductDL.ProductList1.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                Product S = (Product)datagvProductDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    Form f = new frmUpdateProduct(S);
                    f.ShowDialog();
                    DataBind();
                    ProductDL.storeAllRecordIntoFile(FilePath.Products);
                }
                else
                {
                    if (ProductDL.ProductList1.Count != 0)
                        lblDatagvSignal.Text = "Select a row from the list";
                }
            }
        }

        private void lblDatagvSignal_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }

        private void cmbxFiliter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFiliter_Click(object sender, EventArgs e)
        {

        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbxAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAttributes_Click(object sender, EventArgs e)
        {

        }

        private void lblProductDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
