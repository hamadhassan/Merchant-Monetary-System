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
        private List<Product> cart;


        public frmCartOrders(string shopkeeper, string rider,List<Product>cart)
        {
            InitializeComponent();
            this.shopkeeper=shopkeeper;
            this.rider=rider;
            this.cart = cart;
        
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
                datagvProductDetails.DataSource = cart;
                DataGridViewButtonColumn Add = new DataGridViewButtonColumn();
                Add.HeaderText = "Delete";
                Add.Text = "Delete";
                Add.UseColumnTextForButtonValue = true;
                datagvProductDetails.Columns.Add(Add);
 

            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
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
                Product S = (Product)datagvProductDetails.CurrentRow.DataBoundItem;

                try
                {
                    if (index == 7 )
                    {
                        cart.Remove(S);
                        DataBind();
                        MessageBox.Show("Product excluded from Cart");

                    }
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }

            }
            else
            {
                if (ProductDL.ProductList1.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnonfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order(shopkeeper, rider, cart);
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
            for (int i = 0; i < cart.Count; i++) { cart.Remove(cart[i]); }
            DataBind();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
