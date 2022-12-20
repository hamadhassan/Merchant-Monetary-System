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

namespace Merchant_Monetary_System.Forms.Payment
{
    public partial class frmAddPayment : Form
    {
        bool isAmount = true;
        bool isConfirmAmount = true;
        public frmAddPayment()
        {
            InitializeComponent();
        }


        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == string.Empty)
            {// check is empty
                lblAmountSingal.Text = "Enter the Amount";
                isAmount = true;
            }
            else if (txtAmount.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblAmountSingal.Text = "Allowed characters: 0-9";
                isAmount = true;
            }
            else
            {//ready for storage or action
                lblAmountSingal.Text = " ";
                isAmount = false;
            }
        }

        private void txtConfirmAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmAmount.Text == string.Empty)
            {// check is empty
                lblConfirmAmountSignal.Text = "Enter the Amount";
                isConfirmAmount = true;
            }
            else if (txtConfirmAmount.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblConfirmAmountSignal.Text = "Allowed characters: 0-9";
                isConfirmAmount = true;
            }
            else if(txtConfirmAmount.Text != txtAmount.Text)
            {
                lblConfirmAmountSignal.Text = "Not Matched";
                isConfirmAmount = true;
            }
            else
            {//ready for storage or action
                lblConfirmAmountSignal.Text = " ";
                isConfirmAmount = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtConfirmAmount.Clear();
            txtDesription.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!isAmount && !isConfirmAmount && comboBoxpaymentType.Text != null &&
                comboBoxPaymenyByName.Text != null && comboBoxPaymentBy.Text != null &&
                comboBoxPaymentReceivedBy.Text != null && comboBoxPaymentReceivedByName.Text != null &&
                (rdbtnDeposit.Checked || rdbtnWithdraw.Checked))
            {
                Ledger ledger = new Ledger();
                ledger.PaymentType = comboBoxpaymentType.Text;
                ledger.Amount = Double.Parse(txtAmount.Text);
                if (rdbtnDeposit.Checked) ledger.PaymentMode = rdbtnDeposit.Text;
                else ledger.PaymentMode = rdbtnWithdraw.Text;
                ledger.CurrentDate = DateTime.Parse (DateCurrent.Text);
                ledger.PaymentByDesignation = comboBoxPaymentBy.Text;
                ledger.PaymentByName = comboBoxPaymenyByName.Text;
                ledger.PaymentRecievedByDesignation = comboBoxPaymentReceivedBy.Text;
                ledger.PaymentRecievedByName = comboBoxPaymentReceivedByName.Text;
                if(comboBoxPaymentBy.Text == "Vendor") {
                  Compnay c= new Compnay();
                  
                    c=CompanyDL.loadRecordFromFile2(FilePath.Company);
                    c.Revenue = c.Revenue - ledger.Amount;
                }
                LedgerDL.addintoList(ledger);
                
                LedgerDL.StoreDataIntoFiles(FilePath.Ledger);

                MessageBox.Show("Payment Added Successfully", "Adding Payment...", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                MessageBox.Show("Fill All fields correctly", "Alert Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void comboBoxPaymentReceivedByName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPaymentBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPaymentBy.Text == "Vendor")
            {
                DoublyLinkedListNode<Vendor> Head = VendorDL.VendorLinkedList.Head;
                while (Head != null)
                {
                    comboBoxPaymenyByName.Items.Add(Head.Data.VendorName);
                    Head = Head.Next;
                }


            }
            else
            {
                //DoublyLinkedListNode<Shopkeeper> Head = ShopKeeperDL.ShopkeeperList.Head;
                //while (Head != null)
                //{
                //    comboBoxPaymenyByName.Items.Add(Head.Data.ShopkeeperName);
                //    Head = Head.Next;
                //}

                // COMMNENT THIS ONE WHEN LINKED liST applied on Shoppkeper Dl AND uNCOMMENT THE ABOVE ONE

                List<string> names = new List<string>();
                ShopKeeperDL.Shopkeepers_names(ShopKeeperDL.ShopkeeperList.Head);
                for (int i = 0; i < names.Count; i++)
                    comboBoxPaymenyByName.Items.Add(names[i]);

            }
        }

        private void comboBoxPaymentReceivedBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxPaymentReceivedBy.Text == "CEO")
            {
                List<string> names;
                names = UsersDL.GetCEO_Names();
                for (int i = 0; i < names.Count; i++)
                    comboBoxPaymentReceivedByName.Items.Add(names[i]);

            }
            else if (comboBoxPaymentReceivedBy.Text == "Employee")
            {

                {
                    List<string> names;
                    names = UsersDL.GetEmployee_Names();
                    for (int i = 0; i < names.Count; i++)
                        comboBoxPaymentReceivedByName.Items.Add(names[i]);

                }

            }
            else if (comboBoxPaymentReceivedBy.Text == "Vendor")
            {

                DoublyLinkedListNode<Vendor> Head = VendorDL.VendorLinkedList.Head;
                while (Head != null)
                {
                    comboBoxPaymentReceivedByName.Items.Add(Head.Data.VendorName);
                    Head = Head.Next;
                }

            }
        }
    }
}
