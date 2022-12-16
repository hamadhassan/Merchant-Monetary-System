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

namespace Merchant_Monetary_System.Forms.Product
{
    public partial class frmViewCategory : Form
    {
        public frmViewCategory()
        {
            InitializeComponent();
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
            categoryDL.loadDataFromFiles(FilePath.Category);
            datagvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagvCategory.DataSource = categoryDL.CategoryList;
        }

        private void datagvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
