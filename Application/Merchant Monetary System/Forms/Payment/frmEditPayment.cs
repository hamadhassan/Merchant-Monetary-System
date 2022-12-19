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
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.Forms;

namespace Merchant_Monetary_System.Forms.Payment
{
    public partial class frmEditPayment : Form
    {
        bool isAmount = true;
        bool isConfirmAmount = true;
        Ledger ledger;
        public frmEditPayment(Ledger ledger)
        {
            InitializeComponent();
            this.ledger = ledger;
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
            else if (txtConfirmAmount.Text != txtAmount.Text)
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

        private void frmEditPayment_Load(object sender, EventArgs e)
        {
            comboBoxpaymentType.SelectedIndex = comboBoxpaymentType.Items.IndexOf(ledger.PaymentType);
            DateCurrent.Value = ledger.CurrentDate;
            txtAmount.Text = ledger.Amount.ToString();
            txtConfirmAmount.Text = ledger.Amount.ToString();
            if (ledger.PaymentMode == "Deposit") rdbtnDeposit.Checked = true;
            else rdbtnWithdraw.Checked = true;
            txtDesription.Text = ledger.Description;
            comboBoxPaymentBy.SelectedIndex = comboBoxPaymentBy.Items.IndexOf(ledger.PaymentByDesignation);
            comboBoxPaymentReceivedBy.SelectedIndex = comboBoxPaymentReceivedBy.Items.IndexOf(ledger.PaymentRecievedByDesignation);  
            comboBoxPaymenyByName.SelectedIndex = comboBoxPaymenyByName.Items.IndexOf(ledger.PaymentByName);
            comboBoxPaymentReceivedByName.SelectedIndex = comboBoxPaymentReceivedByName.Items.IndexOf(ledger.PaymentRecievedByName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isAmount && !isConfirmAmount && comboBoxpaymentType.Text != null &&
                comboBoxPaymenyByName.Text != null && comboBoxPaymentBy.Text != null &&
                comboBoxPaymentReceivedBy.Text != null && comboBoxPaymentReceivedByName.Text != null &&
                (rdbtnDeposit.Checked || rdbtnWithdraw.Checked))
            {
                ledger.PaymentType = comboBoxpaymentType.Text;
                ledger.Amount = Double.Parse(txtAmount.Text);
                if (rdbtnDeposit.Checked) ledger.PaymentMode = rdbtnDeposit.Text;
                else ledger.PaymentMode = rdbtnWithdraw.Text;
                ledger.CurrentDate = DateTime.Parse(DateCurrent.Text);
                ledger.PaymentByDesignation = comboBoxPaymentBy.Text;
                ledger.PaymentByName = comboBoxPaymenyByName.Text;
                ledger.PaymentRecievedByDesignation = comboBoxPaymentReceivedBy.Text;
                ledger.PaymentRecievedByName = comboBoxPaymentReceivedByName.Text;
                MessageBox.Show("Payment Updated Successfully", "Updating Payment...", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                MessageBox.Show("Fill All fields correctly", "Alert Message!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            else {
                //DoublyLinkedListNode<Shopkeeper> Head = ShopKeeperDL.ShopkeeperList.Head;
                //while (Head != null)
                //{
                //    comboBoxPaymenyByName.Items.Add(Head.Data.ShopkeeperName);
                //    Head = Head.Next;
                //}

                // COMMNENT THIS ONE WHEN LINKED liST applied on Shoppkeper Dl AND uNCOMMENT THE ABOVE ONE

                List<string> names;
                names = ShopKeeperDL.Shopkeepers_names();
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
