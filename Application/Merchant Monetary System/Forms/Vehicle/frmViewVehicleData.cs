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
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.Forms.Product;

namespace Merchant_Monetary_System.Forms.Vehicle
{
    public partial class frmViewVehicleData : Form
    {
        public frmViewVehicleData()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            datagvVehicleDetails.Columns.Clear();
            datagvVehicleDetails.DataSource = null;
            datagvVehicleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagvVehicleDetails.DataSource = VehicleDL.VehicleList;
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvVehicleDetails.Columns.Add(Update);
            datagvVehicleDetails.Columns.Add(Delete);
            datagvVehicleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Enabled = false;
            btnLoadRecords.Visible = false;
            datagvVehicleDetails.Visible = true;
            DataBind();
        }

        private void datagvVehicleDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvVehicleDetails.SelectedRows.Count == 1)
            {
                int index = datagvVehicleDetails.CurrentCell.ColumnIndex;
                BL.Vehicle V = (BL.Vehicle)datagvVehicleDetails.CurrentRow.DataBoundItem;
                if (index == 5)
                {
                    Form form = new frmUpdateVehicle(V);
                    form.ShowDialog();
                    VehicleDL.StoreVehicleDataIntoFiles(FilePath.Vehcile);
                }
                else if (index == 6)
                {
                    bool done = VehicleDL.deleteVehicle(V);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBind();
                        ShopKeeperDL.StoreDataIntoFiles(FilePath.Vehcile);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (VehicleDL.VehicleList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvVehicleDetails.SelectedRows.Count == 1)
            {
                BL.Vehicle V = (BL.Vehicle)datagvVehicleDetails.CurrentRow.DataBoundItem;
                if (V != null)
                {
                    VehicleDL.deleteVehicle(V);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    VehicleDL.StoreVehicleDataIntoFiles(FilePath.Vehcile);
                }
            }
            else
            {
                if (VehicleDL.VehicleList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvVehicleDetails.SelectedRows.Count == 1)
            {
                BL.Vehicle V = (BL.Vehicle)datagvVehicleDetails.CurrentRow.DataBoundItem;
                if (V != null)
                {
                    Form f = new frmUpdateVehicle(V);
                    f.ShowDialog();
                    DataBind();
                    VehicleDL.StoreVehicleDataIntoFiles(FilePath.Vehcile);
                }
                else
                {
                    if (VehicleDL.VehicleList.Count != 0)
                        lblDatagvSignal.Text = "Select a row from the list";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
