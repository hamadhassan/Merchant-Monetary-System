using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using Merchant_Monetary_System.Forms.Product;
using Merchant_Monetary_System.Forms.Users;
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
    public partial class frmVendorDetails : Form
    {
        public frmVendorDetails()
        {
            InitializeComponent();
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvVendorsDetails.Visible = true;

            DataBind();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DataBind()
        {
            try
            {
                datagvVendorsDetails.Columns.Clear();

                datagvVendorsDetails.DataSource = null;
                VendorDL.loadRecordFromFile(FilePath.Vendors);
                datagvVendorsDetails.DataSource = VendorDL.VendorList;
                DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
                Update.HeaderText = "Update";
                Update.Text = "Update";
                Update.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
                Delete.HeaderText = "Delete";
                Delete.Text = "Delete";
                Delete.UseColumnTextForButtonValue = true;
                datagvVendorsDetails.Columns.Add(Update);
                datagvVendorsDetails.Columns.Add(Delete);
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void datagvVendorsDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvVendorsDetails.SelectedRows.Count == 1)
            {
                int index = datagvVendorsDetails.CurrentCell.ColumnIndex;
                Vendor S = (Vendor)datagvVendorsDetails.CurrentRow.DataBoundItem;
                if (index == 5)
                {
                    Form form = new frmUpdateVendor(S);
                    form.ShowDialog();
                   VendorDL.storeAllRecordIntoFile(FilePath.Vendors);
                }
                else if (index == 6)
                {
                    bool done = VendorDL.deleteVendor(S);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (VendorDL.VendorList.Count != 0)
                    lblDatagvSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvVendorsDetails.SelectedRows.Count == 1)
            {
                Vendor S = (Vendor)datagvVendorsDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    Form f = new frmUpdateVendor(S);
                    f.ShowDialog();
                    DataBind();
                    VendorDL.storeAllRecordIntoFile(FilePath.Vendors);
                }
                else
                {
                    if (VendorDL.VendorList.Count != 0)
                        lblDatagvSignal.Text = "Select a row from the list";
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

                if (datagvVendorsDetails.SelectedRows.Count == 1)
                {
                    Vendor S = (Vendor)datagvVendorsDetails.CurrentRow.DataBoundItem;
                    if (S != null)
                    {
                        VendorDL.deleteVendor(S);
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBind();
                        VendorDL.storeAllRecordIntoFile(FilePath.Vendors);

                    }
                }
                else
                {
                    if (VendorDL.VendorList.Count != 0)
                        lblDatagvSignal.Text = "Select a row from the list";
                }
            
        }
    }
}
