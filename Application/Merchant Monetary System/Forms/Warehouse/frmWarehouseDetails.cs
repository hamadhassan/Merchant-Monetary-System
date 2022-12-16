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
    public partial class frmWarehouseDetails : Form
    {
        public frmWarehouseDetails()
        {
            InitializeComponent();
        }
        public void DataBind()
        {//it will display the data into the data gride view

            datagvWarehouseDetails.DataSource = null;
            datagvWarehouseDetails.DataSource = WarehouseDL.WarehousesList;
            datagvWarehouseDetails.Refresh();
        }
        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
           // UsersDL.loadRecordFromFile(FilePath.Users);
            DataBind();
            btnLoadRecords.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //edit the record
            if (datagvWarehouseDetails.SelectedRows.Count == 1)
            {
                Warehouse currentObj = (Warehouse)datagvWarehouseDetails.CurrentRow.DataBoundItem;
                frmAddWarehouse frmAddWarehouse = new frmAddWarehouse(currentObj);
                frmAddWarehouse.ShowDialog();
                DataBind();
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }
        private void btnEdit_MouseLeave_1(object sender, EventArgs e)
        {
            //remove the signal
            lblDatagvSignal.Text = " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the record
            if (datagvWarehouseDetails.SelectedRows.Count == 1)
            {
                Warehouse currentObj = (Warehouse)datagvWarehouseDetails.CurrentRow.DataBoundItem;
                WarehouseDL.deleteRecord(currentObj);
                DataBind();
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }

        private void frmViewWarehouses_Load(object sender, EventArgs e)
        {

        }
    }
}
