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

namespace Merchant_Monetary_System.Forms.Product
{
    public partial class frmViewCategory : Form
    {
        public frmViewCategory()
        {
            InitializeComponent();
        }
        
        private void addIntoGrid(DoublyLinkedList<string> categories)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Category");
            DoublyLinkedListNode<string> Head = categories.Head;
            while(Head != null)
            {
                DataRow dr = dt.NewRow();
                dr["Category"] = Head.Data;
                dt.Rows.Add(dr);
                Head = Head.Next;
            }
            datagvCategory.DataSource = dt;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //Cearing combobox not work
            txtbxSearch.Clear();
            cmbxFiliter.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmViewCategory_Load(object sender, EventArgs e)
        {
            datagvCategory.Columns.Clear();
            datagvCategory.DataSource = null;
            datagvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addIntoGrid(categoryDL.Categories);
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvCategory.Columns.Add(Update);
            datagvCategory.Columns.Add(Delete);

        }

        private void datagvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvCategory.SelectedRows.Count == 1)
            {
                int index = datagvCategory.CurrentCell.ColumnIndex;
                if (index == 1)
                {
                    int rowInd = datagvCategory.CurrentCell.RowIndex;
                    DataGridViewRow category = datagvCategory.Rows[rowInd];
                    string categoryT = category.Cells[0].Value.ToString();
                    //string category = datagvCategory.SelectedCells[datagvCategory.CurrentCell.ColumnIndex].ColumnIndex.Da;
                    MessageBox.Show(categoryT);
                    //Form f = new frmUpdateCategory(category);
                    //f.ShowDialog();
                }
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the grid first";
            }

        }
    }
}
