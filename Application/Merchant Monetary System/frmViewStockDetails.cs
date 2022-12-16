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
    public partial class frmViewStockDetails : Form
    {
        public frmViewStockDetails()
        {
            InitializeComponent();
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvStockDetails.DataSource = StockDL.StockList;
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvStockDetails.Columns.Add(Update);
            datagvStockDetails.Columns.Add(Delete);
        }
    }
}
