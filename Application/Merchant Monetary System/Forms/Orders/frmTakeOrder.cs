using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using Merchant_Monetary_System.Forms.Dashboards;
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
        public string name;


        
        public static DoublyLinkedList<Product> cartlist=new DoublyLinkedList<Product>();
        public frmTakeOrder(string name)
        {
            InitializeComponent();
            this.Name = name;

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
                Product product;
                int rowInd = datagvProductDetails.CurrentCell.RowIndex;
                string Name = datagvProductDetails.Rows[rowInd].Cells[0].Value.ToString();
                int SKU_Number = int.Parse(datagvProductDetails.Rows[rowInd].Cells[2].Value.ToString());
                product = ProductDL.FoundProduct(Name, SKU_Number);

                try
                {
                    if (index == 3 && txtbxName.Text != String.Empty && cmbxShopNames.Text != String.Empty)
                    {
                        //if (cartlist.Contains(S)){ S.Quantity++; } 
                        cartlist.Add(product);
                        MessageBox.Show("Product Added To Cart");

                    }
                    else { MessageBox.Show("Select Shop and Select Shopkeeper First"); }
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }

            }
            else
            {
                if (ProductDL.ProductList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }
        private void DataBind()
        {
            datagvProductDetails.Columns.Clear();
            datagvProductDetails.DataSource = null;
            datagvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addIntoGrid(ProductDL.ProductList);

            DataGridViewButtonColumn Add = new DataGridViewButtonColumn();
            Add.HeaderText = "Add To Cart";
            Add.Text = "Add To Cart";
            Add.UseColumnTextForButtonValue = true;
            datagvProductDetails.Columns.Add(Add);
            datagvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addIntoGrid(DoublyLinkedList<Product> productLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("SKU Number");

            DoublyLinkedListNode<Product> Head = productLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.Name, Head.Data.Category, Head.Data.SKU_Number);
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

        private void txtbxName_SelectedIndexChanged(object sender, EventArgs e)
        { 
            List<string> names =ShopKeeperDL.Shop_names(txtbxName.Text);
            for (int i = 0; i < names.Count; i++) 
            {
                cmbxShopNames.Items.Add(names[i]);
            }
        }

        private void frmTakeOrder_Load(object sender, EventArgs e)
        {
            ShopKeeperDL.Shopkeepers_names(ShopKeeperDL.ShopkeeperList.Head);
            List<string> names = ShopKeeperDL.names;
            for (int i = 0; i < names.Count; i++)
                txtbxName.Items.Add(names[i]);
        }

        private void btnEdit_Click(object sender, EventArgs e) 
        {
            Form form = new frmCartOrders(txtbxName.Text,this.  Name,cartlist,cmbxShopNames.Text);
            form.Show();
            this.Hide();
        }

        private void lblShhopkeekper_Click(object sender, EventArgs e)
        {

        }

        private void cmbxShopNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
