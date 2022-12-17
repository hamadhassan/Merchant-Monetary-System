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
    public partial class ViewShopkeeperDetails : Form
    {
        public ViewShopkeeperDetails()
        {
            InitializeComponent();
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Enabled = false;
            btnLoadRecords.Visible = false;
            datagvShopkeeperDetails.Visible = true;
            DataBind();
        }
        
        private void DataBind()
        {
            datagvShopkeeperDetails.Columns.Clear();
            datagvShopkeeperDetails.DataSource = null;
            datagvShopkeeperDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagvShopkeeperDetails.DataSource = ShopKeeperDL.shopkeeperList;
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "    Update    ";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "    Delete    ";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvShopkeeperDetails.Columns.Add(Update);
            datagvShopkeeperDetails.Columns.Add(Delete);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void datagvShopkeeperDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvShopkeeperDetails.SelectedRows.Count == 1)
            {
                int index = datagvShopkeeperDetails.CurrentCell.ColumnIndex;
                Shopkeeper S = (Shopkeeper)datagvShopkeeperDetails.CurrentRow.DataBoundItem;
                if (index == 4)
                {
                    Form form = new UpdateShopKeeper(S);
                    form.ShowDialog();
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper);
                }
                else if (index == 5)
                {
                    bool done = ShopKeeperDL.deleteShopkeeper(S);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBind();
                        ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (ShopKeeperDL.shopkeeperList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvShopkeeperDetails.SelectedRows.Count == 1)
            {
                Shopkeeper S = (Shopkeeper)datagvShopkeeperDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    Form f = new UpdateShopKeeper(S);
                    f.ShowDialog();
                    DataBind();
                    StockDL.StoreDataIntoFile(FilePath.Stock);
                }
                else
                {
                    if (ShopKeeperDL.shopkeeperList.Count != 0)
                        lblDatagvSignal.Text = "Select a row from the list";
                }
            }
            else
            {
                if (ShopKeeperDL.shopkeeperList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvShopkeeperDetails.SelectedRows.Count == 1)
            {
                Shopkeeper S = (Shopkeeper)datagvShopkeeperDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    ShopKeeperDL.deleteShopkeeper(S);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    StockDL.StoreDataIntoFile(FilePath.Shopkeeper);
                }
            }
            else
            {
                if (ShopKeeperDL.shopkeeperList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }
    }
}
