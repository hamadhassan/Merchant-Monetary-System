using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.Data_Structure.HashTable;
using Merchant_Monetary_System.DL;
using Merchant_Monetary_System.Forms.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Merchant_Monetary_System.Forms.Payment
{
    public partial class frmViewLedger : Form
    {
        public frmViewLedger()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void DataBind()
        {
            datagvLedgerDetails.Columns.Clear();
            datagvLedgerDetails.DataSource = null;
            addIntoGrid(LedgerDL.Ledgers);
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.Text = "Update";
            Update.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            datagvLedgerDetails.Columns.Add(Update);
            datagvLedgerDetails.Columns.Add(Delete);
            datagvLedgerDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addIntoGrid(HashTable ledgerTable)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Mode");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date");
            dt.Columns.Add("Payment By");
            dt.Columns.Add("Payment Received");

            for (int i = 0; i < ledgerTable.Size; i++)
            {
                if (ledgerTable.HashTableData[i] != null)
                {
                    DoublyLinkedListNode<Ledger> Head = ledgerTable.HashTableData[i].Head;
                    while (Head != null)
                    {
                        DataRow dr = dt.NewRow();
                        dt.Rows.Add(Head.Data.Id, Head.Data.PaymentMode, Head.Data.Amount,Head.Data.CurrentDate, Head.Data.PaymentByName, Head.Data.PaymentRecievedByName);
                        Head = Head.Next;
                    }
                }
            }
            datagvLedgerDetails.DataSource = dt;
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Visible = false;
            datagvLedgerDetails.Visible = true;
            Ledger L = new Ledger("cash", "Card", DateTime.Parse("12/12/2022"), 10000, "CEO", "Kabir", "Employee", "Hashir", "Desc");
            LedgerDL.Ledgers.Add(L);
            DataBind();
        }

        private void datagvLedgerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagvLedgerDetails.SelectedRows.Count == 1)
            {
                int index = datagvLedgerDetails.CurrentCell.ColumnIndex;
                int rowInd = datagvLedgerDetails.CurrentCell.RowIndex;
                string ID = datagvLedgerDetails.Rows[rowInd].Cells[0].Value.ToString();
                Ledger L = LedgerDL.Ledgers.SearchKey(ID);
                if (index == 6)
                {
                    Form form = new frmEditPayment(L);
                    MessageBox.Show("Clicked");
                    form.ShowDialog();
                    
                }
                else if (index == 7)
                {
                    bool done = LedgerDL.deleteOnlyLedgerDetails(L);
                    if (done)
                    {
                        MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                LedgerDL.StoreDataIntoFiles(FilePath.Ledger);
                DataBind();
            }
            else
            {
                if (LedgerDL.Ledgers.Count != 0)
                    lblRowSignal.Text = "Select a row from the list";
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagvLedgerDetails.SelectedRows.Count == 1)
            {
                Ledger L = (Ledger)datagvLedgerDetails.CurrentRow.DataBoundItem;
                if (L != null)
                {
                    LedgerDL.deleteOnlyLedgerDetails(L);
                    MessageBox.Show("Deleted Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    LedgerDL.StoreDataIntoFiles(FilePath.Ledger);
                }
            }
            else
            {
                if (LedgerDL.Ledgers.Count != 0)
                    lblRowSignal.Text = "Select a row from the list";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagvLedgerDetails.SelectedRows.Count == 1)
            {
                Ledger S = (Ledger)datagvLedgerDetails.CurrentRow.DataBoundItem;
                if (S != null)
                {
                    Form f = new frmEditPayment(S);
                    f.ShowDialog();
                    DataBind();
                    LedgerDL.StoreDataIntoFiles(FilePath.Ledger);
                }
                else
                {
                    if (LedgerDL.Ledgers.Count != 0)
                        lblRowSignal.Text = "Select a row from the list";
                }
            }
        }
    }
}
