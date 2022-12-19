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
            datagvVendorsDetails.Columns.Clear();
            datagvVendorsDetails.DataSource = null;
            datagvVendorsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addIntoGrid(VendorDL.VendorLinkedList);
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
            datagvVendorsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addIntoGrid(DoublyLinkedList<Vendor> vendorLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("LandLine Number");
            dt.Columns.Add("Concerned Person");
            dt.Columns.Add("Contact No.");
            dt.Columns.Add("Amount");

            DoublyLinkedListNode<Vendor> Head = vendorLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.VendorName, Head.Data.LandlineNumber, Head.Data.ConcernedPerson, Head.Data.ContactNumber, Head.Data.Amount);
                Head = Head.Next;
            }
            datagvVendorsDetails.DataSource = dt;
        }

        private void datagvVendorsDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvVendorsDetails.SelectedRows.Count == 1)
            {
                int index = datagvVendorsDetails.CurrentCell.ColumnIndex;
                if(index == 5 || index == 6)
                {
                    Vendor vendor;
                    int rowInd = datagvVendorsDetails.CurrentCell.RowIndex;
                    string Name = datagvVendorsDetails.Rows[rowInd].Cells[0].Value.ToString();
                    double LandlineNumber = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[1].Value.ToString());
                    string concernedPerson = datagvVendorsDetails.Rows[rowInd].Cells[2].Value.ToString();
                    double contactNumber = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[3].Value.ToString());
                    double amount = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[4].Value.ToString());
                    vendor = VendorDL.returnVendor(Name, LandlineNumber, concernedPerson, contactNumber, amount);
                    if (index == 5)
                    {
                        Form form = new frmUpdateVendor(vendor);
                        form.ShowDialog();
                    }
                    else if (index == 6)
                    {
                        bool done = VendorDL.deleteVendor(vendor);
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
                    VendorDL.storeAllRecordIntoFile(FilePath.Vendors);
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
                Vendor vendor;
                int rowInd = datagvVendorsDetails.CurrentCell.RowIndex;
                string Name = datagvVendorsDetails.Rows[rowInd].Cells[0].Value.ToString();
                double LandlineNumber = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[1].Value.ToString());
                string concernedPerson = datagvVendorsDetails.Rows[rowInd].Cells[2].Value.ToString();
                double contactNumber = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[3].Value.ToString());
                double amount = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[4].Value.ToString());
                vendor = VendorDL.returnVendor(Name, LandlineNumber, concernedPerson, contactNumber, amount);
                if (vendor != null)
                {
                    Form f = new frmUpdateVendor(vendor);
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
                Vendor vendor;
                int rowInd = datagvVendorsDetails.CurrentCell.RowIndex;
                string Name = datagvVendorsDetails.Rows[rowInd].Cells[0].Value.ToString();
                double LandlineNumber = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[1].Value.ToString());
                string concernedPerson = datagvVendorsDetails.Rows[rowInd].Cells[2].Value.ToString();
                double contactNumber = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[3].Value.ToString());
                double amount = Double.Parse(datagvVendorsDetails.Rows[rowInd].Cells[4].Value.ToString());
                vendor = VendorDL.returnVendor(Name, LandlineNumber, concernedPerson, contactNumber, amount);
                if (vendor != null)
                {
                    VendorDL.deleteVendor(vendor);
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
