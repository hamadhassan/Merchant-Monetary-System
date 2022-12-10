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
    public partial class frmAccountDetails : Form
    {
        public frmAccountDetails()
        {
            InitializeComponent();
        }

        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            cmbxDesignation.SelectedIndex = 0;
            cmbxAttributes.SelectedIndex = 0;
            cmbxFiliter.SelectedIndex = 0;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DataBind()
        {
            datagvAccountDetails.DataSource = null;
            datagvAccountDetails.DataSource = UsersDL.UsersList;
            datagvAccountDetails.Refresh();
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            DataBind();
            btnLoadRecords.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            if (datagvAccountDetails.SelectedRows.Count == 1)
            {
                Users currentObj = (Users)datagvAccountDetails.CurrentRow.DataBoundItem;
                frmSignUp frmSignUp=new frmSignUp(currentObj);
                frmSignUp.ShowDialog();
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            lblDatagvSignal.Text = " ";
        }
    }
}
