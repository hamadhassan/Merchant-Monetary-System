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
            Stock s = new Stock("Cake", 12, 13, 14, DateTime.Parse("12/12/2022"), DateTime.Parse("12 / 12 / 2022"), DateTime.Parse("12 / 12 / 2022"), "Kabir");
            StockDL.addStockIntoList(StockDL.StockList,s);
            datagvStockDetails.DataSource = StockDL.StockList;
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
        }
        private void DataBind()
        {
<<<<<<< Updated upstream
=======
            datagvStockDetails.Columns.Clear();
>>>>>>> Stashed changes
            datagvStockDetails.DataSource = null;
            datagvStockDetails.DataSource = StockDL.StockList;
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
        }

        private void datagvStockDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvStockDetails.SelectedRows.Count == 1)
            {
                int index = datagvStockDetails.CurrentCell.ColumnIndex;
                Stock S = (Stock)datagvStockDetails.CurrentRow.DataBoundItem;
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
                Stock S = (Stock)datagvStockDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    StockDL.deleteStock(StockDL.StockList, S);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
<<<<<<< Updated upstream
=======
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
                Stock S = (Stock)datagvStockDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    Form f = new UpdatStock(S);
                    f.ShowDialog();
                    DataBind();
                    StockDL.StoreDataIntoFile(FilePath.Stock);
>>>>>>> Stashed changes
                }
            }
            else
            {
                if (StockDL.StockList.Count != 0)
                    lblRowSignal.Text = "Select a row from the list";
            }
        }
    }
}
