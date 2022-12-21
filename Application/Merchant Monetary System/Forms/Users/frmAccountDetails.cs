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


        private void DataBind()
        {
            datagvAccountDetails.Columns.Clear();
            datagvAccountDetails.DataSource = null;

            if (isCEO == true)
            {//CEO is login into the system
                addIntoGrid(UsersDL.UsersLinkedList);
            }
            else if (isCEO == false)
            {//employee is login into the system
                addIntoGrid(UsersDL.getUsersListExceptCEO());
            }

            datagvAccountDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addIntoGrid(UsersDL.UsersLinkedList);
            datagvAccountDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addIntoGrid(DoublyLinkedList<Users> userLinkedList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Designation");
            dt.Columns.Add("Username");
            dt.Columns.Add("Name");
            dt.Columns.Add("CNIC");
            dt.Columns.Add("Email Address");
            dt.Columns.Add("Contact No.");

            DoublyLinkedListNode<Users> Head = userLinkedList.Head;
            while (Head != null)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(Head.Data.Designation,Head.Data.Username, Head.Data.Name, Head.Data.Cnic, Head.Data.EmailAddress, Head.Data.ContactNumber);
                Head = Head.Next;
            }
            datagvAccountDetails.DataSource = dt;
        }


        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            DataBind();
            btnLoadRecords.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {//edit the record
           
            if (datagvAccountDetails.SelectedRows.Count == 1)
            {
                int index = datagvAccountDetails.CurrentCell.ColumnIndex;
                Users currentObj;
                int rowInd = datagvAccountDetails.CurrentCell.RowIndex;
                string userName = datagvAccountDetails.Rows[rowInd].Cells[1].Value.ToString();
                currentObj = UsersDL.returnUser(userName);
                frmSignUp frmSignUp;
                if (isCEO)
                    frmSignUp = new frmSignUp(currentObj, true);  
                else
                   frmSignUp = new frmSignUp(currentObj, false);
                frmSignUp.ShowDialog();
                DataBind();
                UsersDL.storeAllRecordIntoFile(FilePath.Users);
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
                Users currentObj;
                int rowInd = datagvAccountDetails.CurrentCell.RowIndex;
                string userName = datagvAccountDetails.Rows[rowInd].Cells[1].Value.ToString();
                currentObj = UsersDL.returnUser(userName);
                UsersDL.deleteRecord(currentObj);
                DataBind();
                UsersDL.storeAllRecordIntoFile(FilePath.Users);
            }
            else
            {
                lblDatagvSignal.Text = "Select a row from the above table";
            }
        }
    }
}
