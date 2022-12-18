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
    public partial class frmOrderDetails : Form
    {
        public string role;
        public frmOrderDetails(string Role)
        {

            InitializeComponent();
            this.role = Role;       
        }
        private void DataBind()
        {
            try
            {
                datagvProductDetails.Columns.Clear();

                datagvProductDetails.DataSource = null;
                datagvProductDetails.DataSource = OrderDL.OrdersList;
                DataGridViewButtonColumn Add = new DataGridViewButtonColumn();


            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
        private void DataBind2()
        {

                try
                {
                    datagvProductDetails.Columns.Clear();

                    datagvProductDetails.DataSource = null;
                    datagvProductDetails.DataSource = OrderDL.OrdersList;
                    DataGridViewButtonColumn Update_Status = new DataGridViewButtonColumn();
                    Update_Status.HeaderText = "Update Status";
                    Update_Status.Text = "Update Status";
                    Update_Status.UseColumnTextForButtonValue = true;
                    datagvProductDetails.Columns.Add(Update_Status);

                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
        
        

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvProductDetails.Visible = true;
            OrderDL.loadRecordFromFile(FilePath.Orders);
            if (role == "Rider")
            {
                DataBind();
            }
            else
            {
                DataBind2();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void datagvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                int index = datagvProductDetails.CurrentCell.ColumnIndex;
                Order S = (Order)datagvProductDetails.CurrentRow.DataBoundItem;

                try
                {
                    if (index == 11 )
                    {
                        //if (cartlist.Contains(S)){ S.Quantity++; } 

                        MessageBox.Show("status Updated");

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
    }
}
