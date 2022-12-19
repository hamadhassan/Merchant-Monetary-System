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
    public partial class frmWarehouseDetails : Form
    {
        public frmWarehouseDetails()
        {
            InitializeComponent();
        }
        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            WarehouseDL.loadRecordFromFile(FilePath.Warehouse);
            DataBind();
            btnLoadRecords.Visible = false;
        }

        private void DataBind()
        {
            datagvWarehouseDetails.Columns.Clear();
            datagvWarehouseDetails.DataSource = null;
            datagvWarehouseDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addIntoGrid(WarehouseDL.WarehousesList);
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvWarehouseDetails.Columns.Add(Update);
            datagvWarehouseDetails.Columns.Add(Delete);
            datagvWarehouseDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addIntoGrid(DoublyLinkedList<Warehouse> warehouseLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Total Space");
            dt.Columns.Add("Occupied");
            dt.Columns.Add("Area");

            DoublyLinkedListNode<Warehouse> Head = warehouseLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.Id, Head.Data.Name, Head.Data.TotalSpace, Head.Data.OccupiedSpace, Head.Data.Location.Area);
                Head = Head.Next;
            }
            datagvWarehouseDetails.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //edit the record
            if (datagvWarehouseDetails.SelectedRows.Count == 1)
            {
                int index = datagvWarehouseDetails.CurrentCell.ColumnIndex;
                Warehouse warehouse;
                int rowInd = datagvWarehouseDetails.CurrentCell.RowIndex;
                int ID = int.Parse(datagvWarehouseDetails.Rows[rowInd].Cells[0].Value.ToString());
                warehouse = WarehouseDL.returnWarehouse(ID);
                frmAddWarehouse frmAddWarehouse = new frmAddWarehouse(warehouse);
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
                Warehouse warehouse;
                int rowInd = datagvWarehouseDetails.CurrentCell.RowIndex;
                int ID = int.Parse(datagvWarehouseDetails.Rows[rowInd].Cells[0].Value.ToString());
                warehouse = WarehouseDL.returnWarehouse(ID);
                WarehouseDL.deleteRecord(warehouse);
                DataBind();
                WarehouseDL.storeAllRecordIntoFile(FilePath.Warehouse);
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }

        private void frmViewWarehouses_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void datagvWarehouseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvWarehouseDetails.SelectedRows.Count == 1)
            {
                int index = datagvWarehouseDetails.CurrentCell.ColumnIndex;
                Warehouse warehouse;
                int rowInd = datagvWarehouseDetails.CurrentCell.RowIndex;
                int ID = int.Parse(datagvWarehouseDetails.Rows[rowInd].Cells[0].Value.ToString());
                warehouse = WarehouseDL.returnWarehouse(ID);
                if (index == 5)
                {
                    frmAddWarehouse frmAddWarehouse = new frmAddWarehouse(warehouse);
                    frmAddWarehouse.ShowDialog();
                }
                if (index == 6)
                {
                    bool done = WarehouseDL.deleteRecord(warehouse);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                DataBind();
                WarehouseDL.storeAllRecordIntoFile(FilePath.Warehouse);
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }
    }
}
