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
    public partial class ViewShops : Form
    {
        DoublyLinkedList<Shop> Shops;
        public ViewShops(DoublyLinkedList<Shop> Shops)
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
            addIntoGrid(Shops);
            datagvShopDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void addIntoGrid(DoublyLinkedList<Shop> shopLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("City");
            dt.Columns.Add("Area");
            dt.Columns.Add("State");
            DoublyLinkedListNode<Shop> Head = shopLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.Id, Head.Data.ShopName, Head.Data.City, Head.Data.Area, Head.Data.Area);
                Head = Head.Next;
            }
            datagvShopDetails.DataSource = dt;
        }

        private void datagvShopDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvShopDetails.SelectedRows.Count == 1)
            {
                int index = datagvShopDetails.CurrentCell.ColumnIndex;
                int rowInd = datagvShopDetails.CurrentCell.RowIndex;
                string ID = datagvShopDetails.Rows[rowInd].Cells[0].Value.ToString();
                Shop S = shopDL.returnShop(ID);
                if (index == 4)
                {
                    Form form = new frmUpdateShop(S);
                    form.ShowDialog();
                }
                else if (index == 5)
                {
                    bool done = shopDL.deleteShop(Shops,S);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper,ShopKeeperDL.ShopkeeperList);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                DataBind();
                ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper,ShopKeeperDL.ShopkeeperList);
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
                int rowInd = datagvShopDetails.CurrentCell.RowIndex;
                string ID = datagvShopDetails.Rows[rowInd].Cells[0].Value.ToString();
                Shop S = shopDL.returnShop(ID);
                if (S != null)
                {
                    shopDL.deleteShop(Shops, S);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper, ShopKeeperDL.ShopkeeperList);
                }
            }
            else
            {
                if (Shops.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvShopDetails.SelectedRows.Count == 1)
            {
                int rowInd = datagvShopDetails.CurrentCell.RowIndex;
                string ID = datagvShopDetails.Rows[rowInd].Cells[0].Value.ToString();
                Shop S = shopDL.returnShop(ID);
                if (S != null)
                {
                    Form f = new frmUpdateShop(S);
                    f.ShowDialog();
                    DataBind();
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper, ShopKeeperDL.ShopkeeperList);
                }
                else
                {
                    if (Shops.Count != 0)
                        lblDatagvSignal.Text = "Select a row from the list";
                }
            }
        }
    }
}
