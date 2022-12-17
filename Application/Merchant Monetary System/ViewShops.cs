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

namespace Merchant_Monetary_System
{
    public partial class ViewShops : Form
    {
        List<Shop> Shops;
        public ViewShops(List<Shop> Shops)
        {
            InitializeComponent();
            this.Shops = Shops;
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Enabled = false;
            btnLoadRecords.Visible = false;
            datagvShopDetails.Visible = true;
            DataBind();
        }
        
        private void DataBind()
        {
            datagvShopDetails.Columns.Clear();
            datagvShopDetails.DataSource = null;
            datagvShopDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagvShopDetails.DataSource = Shops;
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvShopDetails.Columns.Add(Update);
            datagvShopDetails.Columns.Add(Delete);
            datagvShopDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void datagvShopDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvShopDetails.SelectedRows.Count == 1)
            {
                int index = datagvShopDetails.CurrentCell.ColumnIndex;
                Shop S = (Shop)datagvShopDetails.CurrentRow.DataBoundItem;
                if (index == 4)
                {
                    Form form = new frmUpdateShop(S);
                    form.ShowDialog();
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper);
                }
                else if (index == 5)
                {
                    bool done = shopDL.deleteShop(Shops,S);
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
                if (Shops.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvShopDetails.SelectedRows.Count == 1)
            {
                Shop S = (Shop)datagvShopDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    shopDL.deleteShop(Shops, S);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper);
                }
            }
            else
            {
                if (Shops.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }
    }
}
