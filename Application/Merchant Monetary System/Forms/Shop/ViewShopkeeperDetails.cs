using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.Data_Structure.BST;
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
            addIntoGrid(ShopKeeperDL.ShopkeeperList);
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvShopkeeperDetails.Columns.Add(Update);
            datagvShopkeeperDetails.Columns.Add(Delete);
            datagvShopkeeperDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewButtonColumn Shops = new DataGridViewButtonColumn();
            Shops.HeaderText = "Shops";
            Shops.Text = "Shops";
            Shops.UseColumnTextForButtonValue = true;
            datagvShopkeeperDetails.Columns.Add(Shops);
        }

        private void addEachIntoGrid(DataTable dt, BSTNode shopkeeper)
        {
            if(shopkeeper!=null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(shopkeeper.Data.ShopkeeperName, shopkeeper.Data.Cnic, shopkeeper.Data.Email, shopkeeper.Data.ContactNumber);
                addEachIntoGrid(dt, shopkeeper.Left);
                addEachIntoGrid(dt, shopkeeper.Right);
            }
        }

        private void addIntoGrid(BST shopkeeperLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("CNIC");
            dt.Columns.Add("Email");
            dt.Columns.Add("Contact No.");
            BSTNode Head = shopkeeperLinkedList.Head;
            addEachIntoGrid(dt, Head);
            datagvShopkeeperDetails.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void datagvShopkeeperDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvShopkeeperDetails.SelectedRows.Count == 1)
            {
                Shopkeeper S;
                int index = datagvShopkeeperDetails.CurrentCell.ColumnIndex;
                int rowInd = datagvShopkeeperDetails.CurrentCell.RowIndex;
                double cnic = Double.Parse(datagvShopkeeperDetails.Rows[rowInd].Cells[1].Value.ToString());
                S = ShopKeeperDL.returnShopkeeperDetails(cnic);
                if (index == 4)
                {
                    Form form = new UpdateShopKeeper(S);
                    form.ShowDialog();
                }
                else if (index == 5)
                {
                    bool done = ShopKeeperDL.deleteShopkeeper(S);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper, ShopKeeperDL.ShopkeeperList);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(index == 6)
                {
                    Form f = new ViewShops(S.ShopList);
                    f.ShowDialog();
                }
                ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper, ShopKeeperDL.ShopkeeperList);
                DataBind();
            }
            else
            {
                if (ShopKeeperDL.ShopkeeperList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvShopkeeperDetails.SelectedRows.Count == 1)
            {
                Shopkeeper S;
                int index = datagvShopkeeperDetails.CurrentCell.ColumnIndex;
                int rowInd = datagvShopkeeperDetails.CurrentCell.RowIndex;
                double cnic = Double.Parse(datagvShopkeeperDetails.Rows[rowInd].Cells[1].Value.ToString());
                S = ShopKeeperDL.returnShopkeeperDetails(cnic);
                if (S != null)
                {
                    Form f = new UpdateShopKeeper(S);
                    f.ShowDialog();
                    DataBind();
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper, ShopKeeperDL.ShopkeeperList);
                }
                else
                {
                    if (ShopKeeperDL.ShopkeeperList.Count != 0)
                        lblDatagvSignal.Text = "Select a row from the list";
                }
            }
            else
            {
                if (ShopKeeperDL.ShopkeeperList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvShopkeeperDetails.SelectedRows.Count == 1)
            {
                Shopkeeper S;
                int index = datagvShopkeeperDetails.CurrentCell.ColumnIndex;
                int rowInd = datagvShopkeeperDetails.CurrentCell.RowIndex;
                double cnic = Double.Parse(datagvShopkeeperDetails.Rows[rowInd].Cells[1].Value.ToString());
                S = ShopKeeperDL.returnShopkeeperDetails(cnic);
                if (S != null)
                {
                    ShopKeeperDL.deleteShopkeeper(S);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper, ShopKeeperDL.ShopkeeperList);
                }
            }
            else
            {
                if (ShopKeeperDL.ShopkeeperList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }
    }
}
