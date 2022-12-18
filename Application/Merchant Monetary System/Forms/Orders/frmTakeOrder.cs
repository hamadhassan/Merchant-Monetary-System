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
        public static string name;
        
        public static List<Product> cartlist=new List<Product>();
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
                Product S = (Product)datagvProductDetails.CurrentRow.DataBoundItem;

                try
                {
                    if (index == 7 && txtbxName.Text!=String.Empty)
                    {
                        cartlist.Add(S);
                        MessageBox.Show("Product Added To Cart");

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
        private void DataBind()
        {
            try
            {
                datagvProductDetails.Columns.Clear();

                datagvProductDetails.DataSource = null;
                datagvProductDetails.DataSource = ProductDL.ProductList1;
                DataGridViewButtonColumn Add = new DataGridViewButtonColumn();
                Add.HeaderText = "Add To Cart";
                Add.Text = "Add To Cart";
                Add.UseColumnTextForButtonValue = true;
                datagvProductDetails.Columns.Add(Add);
            
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvProductDetails.Visible = true;
            ProductDL.loadRecordFromFile(FilePath.Products);
            DataBind();
        }

        private void txtbxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTakeOrder_Load(object sender, EventArgs e)
        {
            txtbxName.DataSource = ShopKeeperDL.Shopkeepers_names();
        }
    }
}
