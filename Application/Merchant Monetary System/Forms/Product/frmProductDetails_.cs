using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.DL;

namespace Merchant_Monetary_System
{
    public partial class frmProductDetails_ : Form
    {
        public frmProductDetails_()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        public void DataBind()
        {//it will display the data into the data gride view

            datagvProductsDetails.DataSource = null;

            datagvProductsDetails.DataSource = ProductDL.ProductList1;

        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            ProductDL.loadRecordFromFile(FilePath.Products);
            DataBind();
        }

        private void datagvAccountDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
