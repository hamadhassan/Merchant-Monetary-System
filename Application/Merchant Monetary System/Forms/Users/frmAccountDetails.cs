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
        bool isCEO=false; //check which user enter into the system
        public frmAccountDetails()
        {
            InitializeComponent();
        }
        public frmAccountDetails(bool isCEO)
        {
            InitializeComponent();
            this.isCEO = isCEO;
        }
        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            if (isCEO ==false)
            {//employee is login into the system
                cmbxDesignation.Items.RemoveAt(0);
            }
            cmbxDesignation.SelectedIndex = 0;
            cmbxAttributes.SelectedIndex = 0;
            cmbxFiliter.SelectedIndex = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DataBind()
        {//it will display the data into the data gride view

            datagvAccountDetails.DataSource = null;
            if (isCEO==true)
            {//CEO is login into the system
                datagvAccountDetails.DataSource = UsersDL.UsersList;
            }
            else if(isCEO==false)
            {//employee is login into the system
                datagvAccountDetails.DataSource = UsersDL.getUsersListExceptCEO();
            }
            datagvAccountDetails.Refresh();
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            UsersDL.loadRecordFromFile(FilePath.Users);
            DataBind();
            btnLoadRecords.Visible = false;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {//edit the record
           
            if (datagvAccountDetails.SelectedRows.Count == 1)
            {
                Users currentObj = (Users)datagvAccountDetails.CurrentRow.DataBoundItem;
                frmSignUp frmSignUp;
                if (isCEO)
                    frmSignUp = new frmSignUp(currentObj, true);  
                else
                   frmSignUp = new frmSignUp(currentObj, false);
                frmSignUp.ShowDialog();
                DataBind();
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {//remove the signal
            lblDatagvSignal.Text = " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {//delete the record
            if (datagvAccountDetails.SelectedRows.Count == 1)
            {
                Users currentObj = (Users)datagvAccountDetails.CurrentRow.DataBoundItem;
                UsersDL.deleteRecord(currentObj);
                DataBind();
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }
    }
}
