using Merchant_Monetary_System.BL;
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

namespace Merchant_Monetary_System
{
    public partial class frmCartOrders : Form
    {
        private  string shopkeeper;
        private string rider;
        private string shopname;
        private DoublyLinkedList<Product> cart;


        public frmCartOrders(string shopkeeper, string rider,DoublyLinkedList<Product> cart, string shopname)
        {
            InitializeComponent();
            this.shopkeeper = shopkeeper;
            this.rider = rider;
            this.cart = cart;
            this.shopname = shopname; 
        }
        public frmCartOrders(string rider)
        {
            InitializeComponent();
            this.rider = rider;

        }
        public frmCartOrders()
        {
            InitializeComponent();

        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void DataBind()
        {
            try
            {

                datagvProductDetails.Columns.Clear();
                datagvProductDetails.DataSource = null;
                datagvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                addIntoGrid(cart);
                NumericUpDown quantity = new NumericUpDown();
                quantity.Minimum = 0;
                DataGridViewButtonColumn Add = new DataGridViewButtonColumn();
                Add.HeaderText = "Delete";
                Add.Text = "Delete";
                Add.UseColumnTextForButtonValue = true;
                datagvProductDetails.Columns.Add(Add);
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
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

        private void btnLoadRecords_Click_1(object sender, EventArgs e)
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
                Product product;
                int rowInd = datagvProductDetails.CurrentCell.RowIndex;
                string Name = datagvProductDetails.Rows[rowInd].Cells[0].Value.ToString();
                int SKU_Number = int.Parse(datagvProductDetails.Rows[rowInd].Cells[2].Value.ToString());
                product = ProductDL.FoundProduct(Name, SKU_Number);

                try
                {
                    if (index == 7 )
                    {
                        DoublyLinkedListNode<Product> P = cart.Find(product);
                        cart.RemoveNode(P);
                        DataBind();
                        MessageBox.Show("Product excluded from Cart");

                    }
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }

            }
            else
            {
                if (cart.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnonfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order(shopkeeper, rider, shopname, cart);
                OrderDL.ordersList.Add(order);
                OrderDL.storeRecordIntoFile(order,FilePath.Orders);
                MessageBox.Show("Order Added");

            }
            catch (Exception exp) 
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            cart.Head = null;
            DataBind();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
