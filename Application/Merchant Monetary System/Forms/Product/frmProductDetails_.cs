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
            datagvProductDetails.Columns.Clear();
            datagvProductDetails.DataSource = null;
            datagvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addIntoGrid(ProductDL.ProductList);
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
            datagvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addIntoGrid(DoublyLinkedList<Product> productLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("SKU Number");
            dt.Columns.Add("Weight");
            dt.Columns.Add("Volume");
            dt.Columns.Add("Manufacturer");
            dt.Columns.Add("Sensitivity");

            DoublyLinkedListNode<Product> Head = productLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.Name, Head.Data.Category, Head.Data.SKU_Number, Head.Data.Weight, Head.Data.Volume, Head.Data.Manufacturer, Head.Data.SensitivityType);
                Head = Head.Next;
            }
            datagvProductDetails.DataSource = dt;
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
                if (index == 7 || index == 8)
                {
                    Product product;
                    int rowInd = datagvProductDetails.CurrentCell.RowIndex;
                    string Name = datagvProductDetails.Rows[rowInd].Cells[0].Value.ToString();
                    int SKU_Number = int.Parse(datagvProductDetails.Rows[rowInd].Cells[2].Value.ToString());
                    product = ProductDL.FoundProduct(Name, SKU_Number);
                    if (index == 7)
                    {
                        Form form = new frmUpdateProduct(product);
                        form.ShowDialog();

                    }
                    else if (index == 8)
                    {
                        bool done = ProductDL.deleteRecord(product);
                        if (done)
                        {
                            MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    ProductDL.storeAllRecordIntoFile(FilePath.Products);
                    DataBind();
                }
            }
            else
            {
                if (ProductDL.ProductList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                Product product;
                int rowInd = datagvProductDetails.CurrentCell.RowIndex;
                string Name = datagvProductDetails.Rows[rowInd].Cells[0].Value.ToString();
                int SKU_Number = int.Parse(datagvProductDetails.Rows[rowInd].Cells[2].Value.ToString());
                product = ProductDL.FoundProduct(Name, SKU_Number);
                if (product != null)
                {
                    ProductDL.deleteRecord(product);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    ProductDL.storeAllRecordIntoFile(FilePath.Products);

                }
            }
            else
            {
                if (ProductDL.ProductList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                Product product;
                int rowInd = datagvProductDetails.CurrentCell.RowIndex;
                string Name = datagvProductDetails.Rows[rowInd].Cells[0].Value.ToString();
                int SKU_Number = int.Parse(datagvProductDetails.Rows[rowInd].Cells[2].Value.ToString());
                product = ProductDL.FoundProduct(Name, SKU_Number);
                if (product != null)
                {
                    Form f = new frmUpdateProduct(product);
                    f.ShowDialog();
                    DataBind();
                    ProductDL.storeAllRecordIntoFile(FilePath.Products);
                }
                else
                {
                    if (ProductDL.ProductList.Count != 0)
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
