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
using Merchant_Monetary_System.Forms.Orders;

namespace Merchant_Monetary_System
{
    public partial class frmOrderDetail : Form
    {
        string role;
        string name;
        DoublyLinkedList<Order> specificRider_orders;

        public frmOrderDetail()
        {
            InitializeComponent();
        }
        public frmOrderDetail(string role, string name)
        {
            InitializeComponent();
            this.role = role;
            this.name = name;
        }
        public frmOrderDetail(string role)
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
            DataBind(); 

        }
        private void DataBind()
        {
            try
            {
                datagvProductDetails.Columns.Clear();
                datagvProductDetails.DataSource = null;
                datagvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                if(role=="Rider") 
                {
                    specificRider_orders = OrderDL.getOrders_withrespectiveRider(name);
                    addIntoGrid(specificRider_orders); 
                }
                else { 
                    addIntoGrid(OrderDL.OrdersList);
                }
                DataGridViewButtonColumn VeiwProductList = new DataGridViewButtonColumn();
                VeiwProductList.HeaderText = "Veiw Product List";
                VeiwProductList.Text = "Veiw Product List";
                VeiwProductList.UseColumnTextForButtonValue = true;
                datagvProductDetails.Columns.Add(VeiwProductList);
                if (role == "CEO" || role == "Employee" || role == "WareHouse Manager")
                {

                    DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
                    Update.HeaderText = "Update Status";
                    Update.Text = "Update Status";
                    Update.UseColumnTextForButtonValue = true;
                    datagvProductDetails.Columns.Add(Update);

                }
                if (role == "CEO" || role == "Employee") 
                {
                    DataGridViewButtonColumn AssignRider = new DataGridViewButtonColumn();
                    AssignRider.HeaderText = "Assign Rider";
                    AssignRider.Text = "Assign Rider";
                    AssignRider.UseColumnTextForButtonValue = true;
                    datagvProductDetails.Columns.Add(AssignRider);
                }

            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
         private void addIntoGrid(DoublyLinkedList<Order> orderLinkedList)
         {
            DataTable dt = new DataTable();
            dt.Columns.Add("OrderID");
            dt.Columns.Add("Shopkeeper");
            dt.Columns.Add("Rider");
            dt.Columns.Add("Status");
            dt.Columns.Add("Shop Name");
            dt.Columns.Add("Assigned Rider");

            DoublyLinkedListNode<Order> Head = orderLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.OrderID, Head.Data.ShopKeeperName, Head.Data.RiderName, Head.Data.Status,Head.Data.ShopName, Head.Data.AsssignedRiderName);
                Head = Head.Next;
            }
            datagvProductDetails.DataSource = dt;
         }

        private void DataBind2(Order order)
        {
            try
            {
                datagvProductDetails.Columns.Clear();
                datagvProductDetails.DataSource = null;
                datagvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                if (role == "Rider") 
                { addProductsIntoGrid(specificRider_orders.Head.Data.Order_products); } else 
                {
                    addProductsIntoGrid(order.Order_products);
                }

            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void addProductsIntoGrid(DoublyLinkedList<Product> productLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("SKU Number");

            DoublyLinkedListNode<Product> Head = productLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.Name, Head.Data.Category, Head.Data.SKU_Number);
                Head = Head.Next;
            }
            dataGridView1.DataSource = dt;
        }

        private void datagvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvProductDetails.SelectedRows.Count == 1)
            {
                int index = datagvProductDetails.CurrentCell.ColumnIndex;
                Order order;
                int rowInd = datagvProductDetails.CurrentCell.RowIndex;
                string ID = datagvProductDetails.Rows[rowInd].Cells[0].Value.ToString();
                order = OrderDL.FoundOrder(ID);

                try
                {
                    if (role == "CEO" || role == "Employee" )
                    {
                        if (index == 7)
                        {
                            Form updateform=new frmUpdateStatus(order,role);
                            updateform.ShowDialog();
                            DataBind();
                          
                        }
                        if (index == 8) 
                        {
                            Form frmAssginRider = new frmAssignRider(order);
                            frmAssginRider.ShowDialog();

                            DataBind();
                        }

                    }
                    else if (role == "WareHouse Manager")
                    {
                        if (index == 7)
                        {
                            Form updateform = new frmUpdateStatus(order, role);
                            updateform.ShowDialog();
                            DataBind();
                        }
                    }
                    if (index == 6)
                    {
                        DataBind2(order);
                        DataBind();
                        dataGridView1.Visible = true;


                    }

                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }

            }
            else
            {
                if (OrderDL.OrdersList.Count != 0)
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