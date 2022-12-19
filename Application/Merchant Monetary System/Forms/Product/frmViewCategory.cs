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
        
        private void addIntoGrid(DoublyLinkedList<Category> categories)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Category");
            DoublyLinkedListNode<Category> Head = categories.Head;
            while(Head != null)
            {
                DataRow dr = dt.NewRow();
                dr["Category"] = Head.Data.CategoryName;
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
            DataBind();
        }

        private void DataBind()
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
                    DataGridViewRow categoryRow = datagvCategory.Rows[rowInd];
                    string categoryT = categoryRow.Cells[0].Value.ToString();
                    Category category = categoryDL.returnCategory(categoryT);
                    Form f = new frmUpdateCategory(category);
                    f.ShowDialog();
                }
                else if(index == 2)
                {
                    int rowInd = datagvCategory.CurrentCell.RowIndex;
                    DataGridViewRow categoryRow = datagvCategory.Rows[rowInd];
                    string categoryT = categoryRow.Cells[0].Value.ToString();
                    bool done = categoryDL.deleteCategory(categoryT);
                    if(done)
                    {
                        MessageBox.Show("Deleted Successfully", "Deleteing...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Deleteing...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                DataBind();
                categoryDL.StoreDataIntoFiles(FilePath.Category);
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the grid first";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvCategory.SelectedRows.Count == 1)
            {
                int rowInd = datagvCategory.CurrentCell.RowIndex;
                DataGridViewRow categoryRow = datagvCategory.Rows[rowInd];
                string categoryT = categoryRow.Cells[0].Value.ToString();
                Category category = categoryDL.returnCategory(categoryT);
                Form f = new frmUpdateCategory(category);
                f.ShowDialog();
                DataBind();
                categoryDL.StoreDataIntoFiles(FilePath.Category);
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the grid first";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvCategory.SelectedRows.Count == 1)
            {
                int rowInd = datagvCategory.CurrentCell.RowIndex;
                DataGridViewRow categoryRow = datagvCategory.Rows[rowInd];
                string categoryT = categoryRow.Cells[0].Value.ToString();
                bool done = categoryDL.deleteCategory(categoryT);
                if (done)
                {
                    MessageBox.Show("Deleted Successfully", "Deleteing...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    categoryDL.StoreDataIntoFiles(FilePath.Category);
                }
                else
                {
                    MessageBox.Show("Not Found", "Deleteing...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the grid first";
            }
        }
    }
}
