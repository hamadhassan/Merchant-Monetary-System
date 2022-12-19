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
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using Merchant_Monetary_System.Forms.Product;

namespace Merchant_Monetary_System
{
    public partial class frmViewStockDetails : Form
    {
        public frmViewStockDetails()
        {
            InitializeComponent();
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvStockDetails.Visible = true;
            DataBind();
        }
        private void DataBind()
        {
            datagvStockDetails.Columns.Clear();
            datagvStockDetails.DataSource = null;
            datagvStockDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addIntoGrid(StockDL.StockList);
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvStockDetails.Columns.Add(Update);
            datagvStockDetails.Columns.Add(Delete);
            datagvStockDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addIntoGrid(DoublyLinkedList<Stock> stockLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Retail Price");
            dt.Columns.Add("Cost Price");
            dt.Columns.Add("MFG date");
            dt.Columns.Add("Expiry date");
            dt.Columns.Add("Received date");
            dt.Columns.Add("Vendor");

            DoublyLinkedListNode<Stock> Head = stockLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.Product, Head.Data.Quantity, Head.Data.RetailPrice, Head.Data.CostPrice, Head.Data.ManufacturingDate, Head.Data.ExpiryDate, Head.Data.RecievedDate);
                Head = Head.Next;
            }
            datagvStockDetails.DataSource = dt;
        }

        private void datagvStockDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvStockDetails.SelectedRows.Count == 1)
            {
                int index = datagvStockDetails.CurrentCell.ColumnIndex;
                if (index == 8 || index == 9)
                {
                    Stock stock;
                    int rowInd = datagvStockDetails.CurrentCell.RowIndex;
                    string product = datagvStockDetails.Rows[rowInd].Cells[0].Value.ToString();
                    int quantity = int.Parse(datagvStockDetails.Rows[rowInd].Cells[1].Value.ToString());
                    double retailPrice = Double.Parse(datagvStockDetails.Rows[rowInd].Cells[2].Value.ToString());
                    double costPrice = Double.Parse(datagvStockDetails.Rows[rowInd].Cells[3].Value.ToString());
                    DateTime MFGDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[4].Value.ToString());
                    DateTime ExpiryDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[5].Value.ToString());
                    DateTime recievedDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[6].Value.ToString());
                    string vendor = datagvStockDetails.Rows[rowInd].Cells[7].Value.ToString();
                    Stock S = new Stock(product, quantity, retailPrice, costPrice, MFGDate, ExpiryDate, recievedDate, vendor);
                    stock = StockDL.returnStock(S);
                    if (index == 8)
                    {
                        Form form = new UpdatStock(S);
                        form.ShowDialog();
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
                    DataBind();
                    StockDL.StoreDataIntoFile(FilePath.Stock);
                }
            }
            else
            {
                if (StockDL.StockList.Count != 0)
                    lblRowSignal.Text = "Select a row from the list";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvStockDetails.SelectedRows.Count == 1)
            {
                Stock stock;
                int rowInd = datagvStockDetails.CurrentCell.RowIndex;
                string product = datagvStockDetails.Rows[rowInd].Cells[0].Value.ToString();
                int quantity = int.Parse(datagvStockDetails.Rows[rowInd].Cells[1].Value.ToString());
                double retailPrice = Double.Parse(datagvStockDetails.Rows[rowInd].Cells[2].Value.ToString());
                double costPrice = Double.Parse(datagvStockDetails.Rows[rowInd].Cells[3].Value.ToString());
                DateTime MFGDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[4].Value.ToString());
                DateTime ExpiryDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[5].Value.ToString());
                DateTime recievedDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[6].Value.ToString());
                string vendor = datagvStockDetails.Rows[rowInd].Cells[7].Value.ToString();
                Stock S = new Stock(product, quantity, retailPrice, costPrice, MFGDate, ExpiryDate, recievedDate, vendor);
                stock = StockDL.returnStock(S);
                if (stock != null)
                {
                    StockDL.deleteStock(StockDL.StockList, S);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    StockDL.StoreDataIntoFile(FilePath.Stock);

                }
            }
            else
            {
                if (StockDL.StockList.Count != 0)
                    lblRowSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvStockDetails.SelectedRows.Count == 1)
            {
                Stock stock;
                int rowInd = datagvStockDetails.CurrentCell.RowIndex;
                string product = datagvStockDetails.Rows[rowInd].Cells[0].Value.ToString();
                int quantity = int.Parse(datagvStockDetails.Rows[rowInd].Cells[1].Value.ToString());
                double retailPrice = Double.Parse(datagvStockDetails.Rows[rowInd].Cells[2].Value.ToString());
                double costPrice = Double.Parse(datagvStockDetails.Rows[rowInd].Cells[3].Value.ToString());
                DateTime MFGDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[4].Value.ToString());
                DateTime ExpiryDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[5].Value.ToString());
                DateTime recievedDate = DateTime.Parse(datagvStockDetails.Rows[rowInd].Cells[6].Value.ToString());
                string vendor = datagvStockDetails.Rows[rowInd].Cells[7].Value.ToString();
                Stock S = new Stock(product, quantity, retailPrice, costPrice, MFGDate, ExpiryDate, recievedDate, vendor);
                stock = StockDL.returnStock(S);
                if (stock != null)
                {
                    Form f = new UpdatStock(S);
                    f.ShowDialog();
                    DataBind();
                    StockDL.StoreDataIntoFile(FilePath.Stock);
                }
                else
                {
                    if (StockDL.StockList.Count != 0)
                        lblRowSignal.Text = "Select a row from the list";
                }
            }
        }
    }
}
