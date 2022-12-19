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
using Merchant_Monetary_System.BL;
namespace Merchant_Monetary_System
{
    public partial class OrDerDetailsForm : Form
    {
        string role;
        public OrDerDetailsForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvProductDetails.Visible = true;
            OrderDL.loadRecordFromFile(FilePath.Orders);
            DataBind();
        }
        private void DataBind()
        {
            try
            {
                datagvProductDetails.Columns.Clear();

                datagvProductDetails.DataSource = null;
                datagvProductDetails.DataSource = OrderDL.OrdersList;
                DataGridViewButtonColumn VeiwProductList = new DataGridViewButtonColumn();
                VeiwProductList.HeaderText = "Veiw Product List";
                VeiwProductList.Text = "Veiw Product List";
                VeiwProductList.UseColumnTextForButtonValue = true;
                datagvProductDetails.Columns.Add(VeiwProductList);
                if (role == "CEO" || role == "Employee" || role == "WareHouse Manager")
                {

                    DataGridViewButtonColumn Add = new DataGridViewButtonColumn();
                    Add.HeaderText = "Update Status";
                    Add.Text = "Update Status";
                    Add.UseColumnTextForButtonValue = true;
                    datagvProductDetails.Columns.Add(Add);

                }


            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void DataBind2(Order order)
        {
            try
            {
                dataGridView1.Columns.Clear();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = order.Order_products;

            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void datagvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                int index = datagvProductDetails.CurrentCell.ColumnIndex;
                Order S = (Order)datagvProductDetails.CurrentRow.DataBoundItem;

                try
                {
                    if (role == "CEO" || role == "Employee" || role == "WareHouse Manager")
                    {
                        if (index == 5)
                        {
                            Form updateform=new frmUpdateStatus(S);
                            updateform.ShowDialog();
                            DataBind();
                        }
                    }
                    if (index == 4)
                    {
                        DataBind2(S);
                        dataGridView1.Visible = true;


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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void OrDerDetailsForm_Load(object sender, EventArgs e)
        {
           // OrderDL.loadRecordFromFile(FilePath.Orders);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}