using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IronPython.Modules._ast;

namespace Merchant_Monetary_System.Reports
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaperSize a = new PaperSize("A4",8,11);
            printDocument1.DefaultPageSettings.PaperSize = a;
            int col1 = 40, col2 = 170, col3 = 230, col4 = 400, col5=580, col6 = 670;
            int y = 120;

            Font F = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            e.Graphics.DrawString("Merchant Monetary System", new Font("Microsoft Sans Serif", 40, FontStyle.Bold), Brushes.Blue, new Point(60, 50));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------", F, Brushes.DarkSlateGray, new Point(col1, y));
            y += 30;
            if (comboBox1.SelectedIndex == 1)
            {
                e.Graphics.DrawString("Date: " + DateTime.Now, F, Brushes.DarkSlateGray, new Point(0, 0));
                e.Graphics.DrawString("ProductName", F, Brushes.DarkSlateGray, new Point(col1, y));
                e.Graphics.DrawString("Quantity", F, Brushes.DarkSlateGray, new Point(col2, y));
                e.Graphics.DrawString("Receive", F, Brushes.DarkSlateGray, new Point(col3 + 10, y));
                e.Graphics.DrawString("Expiry", F, Brushes.DarkSlateGray, new Point(col4 + 10, y));
                e.Graphics.DrawString("Vendor", F, Brushes.DarkSlateGray, new Point(col5, y));
                e.Graphics.DrawString("Total Amount", F, Brushes.DarkSlateGray, new Point(col6, y));
                y += 30;
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------", F, Brushes.DarkSlateGray, new Point(col1, y));
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                e.Graphics.DrawString("Date: " + DateTime.Now, F, Brushes.DarkSlateGray, new Point(0, 0));
                e.Graphics.DrawString("Type", F, Brushes.DarkSlateGray, new Point(col1, y));
                e.Graphics.DrawString("Amount", F, Brushes.DarkSlateGray, new Point(col2, y));
                e.Graphics.DrawString("Mode", F, Brushes.DarkSlateGray, new Point(col3 + 10, y));
                e.Graphics.DrawString("Date", F, Brushes.DarkSlateGray, new Point(col4 + 10, y));
                e.Graphics.DrawString("Payment By", F, Brushes.DarkSlateGray, new Point(col5, y));
                e.Graphics.DrawString("Payment Received", F, Brushes.DarkSlateGray, new Point(col6, y));
                y += 30;
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------", F, Brushes.DarkSlateGray, new Point(col1, y));

            }
            DoublyLinkedListNode<Stock> Head = StockDL.StockList.Head;
            if (cmbxChoose.SelectedIndex == 1 && comboBox1.SelectedIndex == 1)
            {
                string product = cmbxRelatedtoChoose.Text;
                while (Head != null)
                {
                    if (Head.Data.Product == product)
                    {
                        y += 30;
                        e.Graphics.DrawString(Head.Data.Product, F, Brushes.Black, new Point(col1, y));
                        e.Graphics.DrawString(Head.Data.Quantity.ToString(), F, Brushes.Black, new Point(col2, y));
                        e.Graphics.DrawString(Head.Data.RecievedDate.ToString(), F, Brushes.Black, new Point(col3, y));
                        e.Graphics.DrawString(Head.Data.ExpiryDate.ToString(), F, Brushes.Black, new Point(col4, y));
                        e.Graphics.DrawString(Head.Data.Vendor, F, Brushes.Black, new Point(col5, y));
                        e.Graphics.DrawString((Head.Data.CostPrice * Head.Data.Quantity).ToString(), F, Brushes.Black, new Point(col6, y));
                    }
                    Head = Head.Next;
                }
            }
            else if (cmbxChoose.SelectedIndex == 2 && comboBox1.SelectedIndex == 1)
            {
                DateTime dt = dateTimePicker1.Value;
                while (Head != null)
                {
                    if (Head.Data.RecievedDate.Date == dt.Date && Head.Data.RecievedDate.Day == dt.Day && Head.Data.RecievedDate.Month == dt.Month)
                    {
                        y += 30;
                        e.Graphics.DrawString(Head.Data.Product, F, Brushes.Black, new Point(col1, y));
                        e.Graphics.DrawString(Head.Data.Quantity.ToString(), F, Brushes.Black, new Point(col2, y));
                        e.Graphics.DrawString(Head.Data.RecievedDate.ToString(), F, Brushes.Black, new Point(col3, y));
                        e.Graphics.DrawString(Head.Data.ExpiryDate.ToString(), F, Brushes.Black, new Point(col4, y));
                        e.Graphics.DrawString(Head.Data.Vendor, F, Brushes.Black, new Point(col5, y));
                        e.Graphics.DrawString((Head.Data.CostPrice * Head.Data.Quantity).ToString(), F, Brushes.Black, new Point(col6, y));
                    }
                    Head = Head.Next;
                }
            }
            else if(cmbxChoose.SelectedIndex == 3 && comboBox1.SelectedIndex == 1)
            {
                string vendor = cmbxRelatedtoChoose.Text;
                while (Head != null)
                {
                    if (Head.Data.Vendor == vendor)
                    {
                        y += 30;
                        e.Graphics.DrawString(Head.Data.Product, F, Brushes.Black, new Point(col1, y));
                        e.Graphics.DrawString(Head.Data.Quantity.ToString(), F, Brushes.Black, new Point(col2, y));
                        e.Graphics.DrawString(Head.Data.RecievedDate.ToString(), F, Brushes.Black, new Point(col3, y));
                        e.Graphics.DrawString(Head.Data.ExpiryDate.ToString(), F, Brushes.Black, new Point(col4, y));
                        e.Graphics.DrawString(Head.Data.Vendor, F, Brushes.Black, new Point(col5, y));
                        e.Graphics.DrawString((Head.Data.CostPrice * Head.Data.Quantity).ToString(), F, Brushes.Black, new Point(col6, y));
                    }
                    Head = Head.Next;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                while (Head != null)
                {
                    y += 30;
                    e.Graphics.DrawString(Head.Data.Product, F, Brushes.Black, new Point(col1, y));
                    e.Graphics.DrawString(Head.Data.Quantity.ToString(), F, Brushes.Black, new Point(col2, y));
                    e.Graphics.DrawString(Head.Data.RecievedDate.ToString(), F, Brushes.Black, new Point(col3, y));
                    e.Graphics.DrawString(Head.Data.ExpiryDate.ToString(), F, Brushes.Black, new Point(col4, y));
                    e.Graphics.DrawString(Head.Data.Vendor, F, Brushes.Black, new Point(col5, y));
                    e.Graphics.DrawString((Head.Data.CostPrice * Head.Data.Quantity).ToString(), F, Brushes.Black, new Point(col6, y));
                    Head = Head.Next;
                }
            }
            //Ledger Reports Code
            
            if (cmbxChoose.SelectedIndex == 1 && comboBox1.SelectedIndex == 0)
            {
                DateTime dt = dateTimePicker1.Value;
                for (int i=0; i< LedgerDL.Ledgers.Count; i++)
                {
                    if (LedgerDL.Ledgers.HashTableData[i] != null)
                    {
                        DoublyLinkedListNode<Ledger> ledgerHead = LedgerDL.Ledgers.HashTableData[i].Head;
                        while(ledgerHead!=null)
                        {
                            if (ledgerHead.Data.CurrentDate.Date == dt.Date && ledgerHead.Data.CurrentDate.Day == dt.Day && ledgerHead.Data.CurrentDate.Month == dt.Month)
                            {
                                y += 30;
                                e.Graphics.DrawString(ledgerHead.Data.PaymentType, F, Brushes.Black, new Point(col1, y));
                                e.Graphics.DrawString(ledgerHead.Data.Amount.ToString(), F, Brushes.Black, new Point(col2, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentMode.ToString(), F, Brushes.Black, new Point(col3, y));
                                e.Graphics.DrawString(ledgerHead.Data.CurrentDate.ToString(), F, Brushes.Black, new Point(col4, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentByDesignation, F, Brushes.Black, new Point(col5, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentRecievedByDesignation, F, Brushes.Black, new Point(col6, y));
                            }
                            ledgerHead = ledgerHead.Next;
                        }

                    }
                }
            }
            else if(cmbxChoose.SelectedIndex == 2 && comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < LedgerDL.Ledgers.Count; i++)
                {
                    if (LedgerDL.Ledgers.HashTableData[i] != null)
                    {
                        DoublyLinkedListNode<Ledger> ledgerHead = LedgerDL.Ledgers.HashTableData[i].Head;
                        while (ledgerHead != null)
                        {
                            if (ledgerHead.Data.PaymentMode == cmbxRelatedtoChoose.Text)
                            {
                                y += 30;
                                e.Graphics.DrawString(ledgerHead.Data.PaymentType, F, Brushes.Black, new Point(col1, y));
                                e.Graphics.DrawString(ledgerHead.Data.Amount.ToString(), F, Brushes.Black, new Point(col2, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentMode.ToString(), F, Brushes.Black, new Point(col3, y));
                                e.Graphics.DrawString(ledgerHead.Data.CurrentDate.ToString(), F, Brushes.Black, new Point(col4, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentByDesignation, F, Brushes.Black, new Point(col5, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentRecievedByDesignation, F, Brushes.Black, new Point(col6, y));
                            }
                            ledgerHead = ledgerHead.Next;
                        }

                    }
                }
            }
            else if (cmbxChoose.SelectedIndex == 4 && comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < LedgerDL.Ledgers.Count; i++)
                {
                    if (LedgerDL.Ledgers.HashTableData[i] != null)
                    {
                        DoublyLinkedListNode<Ledger> ledgerHead = LedgerDL.Ledgers.HashTableData[i].Head;
                        while (ledgerHead != null)
                        {
                            if (ledgerHead.Data.PaymentType == cmbxRelatedtoChoose.Text)
                            {
                                y += 30;
                                e.Graphics.DrawString(ledgerHead.Data.PaymentType, F, Brushes.Black, new Point(col1, y));
                                e.Graphics.DrawString(ledgerHead.Data.Amount.ToString(), F, Brushes.Black, new Point(col2, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentMode.ToString(), F, Brushes.Black, new Point(col3, y));
                                e.Graphics.DrawString(ledgerHead.Data.CurrentDate.ToString(), F, Brushes.Black, new Point(col4, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentByDesignation, F, Brushes.Black, new Point(col5, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentRecievedByDesignation, F, Brushes.Black, new Point(col6, y));
                            }
                            ledgerHead = ledgerHead.Next;
                        }

                    }
                }
            }
            else if (cmbxChoose.SelectedIndex == 3 && comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < LedgerDL.Ledgers.Count; i++)
                {
                    if (LedgerDL.Ledgers.HashTableData[i] != null)
                    {
                        DoublyLinkedListNode<Ledger> ledgerHead = LedgerDL.Ledgers.HashTableData[i].Head;
                        while (ledgerHead != null)
                        {
                            if (ledgerHead.Data.PaymentRecievedByDesignation == cmbxRelatedtoChoose.Text)
                            {
                                y += 30;
                                e.Graphics.DrawString(ledgerHead.Data.PaymentType, F, Brushes.Black, new Point(col1, y));
                                e.Graphics.DrawString(ledgerHead.Data.Amount.ToString(), F, Brushes.Black, new Point(col2, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentMode.ToString(), F, Brushes.Black, new Point(col3, y));
                                e.Graphics.DrawString(ledgerHead.Data.CurrentDate.ToString(), F, Brushes.Black, new Point(col4, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentByDesignation, F, Brushes.Black, new Point(col5, y));
                                e.Graphics.DrawString(ledgerHead.Data.PaymentRecievedByDesignation, F, Brushes.Black, new Point(col6, y));
                            }
                            ledgerHead = ledgerHead.Next;
                        }

                    }
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < LedgerDL.Ledgers.Count; i++)
                {
                    if (LedgerDL.Ledgers.HashTableData[i] != null)
                    {
                        DoublyLinkedListNode<Ledger> ledgerHead = LedgerDL.Ledgers.HashTableData[i].Head;
                        while (ledgerHead != null)
                        {
                            y += 30;
                            e.Graphics.DrawString(ledgerHead.Data.PaymentType, F, Brushes.Black, new Point(col1, y));
                            e.Graphics.DrawString(ledgerHead.Data.Amount.ToString(), F, Brushes.Black, new Point(col2, y));
                            e.Graphics.DrawString(ledgerHead.Data.PaymentMode.ToString(), F, Brushes.Black, new Point(col3, y));
                            e.Graphics.DrawString(ledgerHead.Data.CurrentDate.ToString(), F, Brushes.Black, new Point(col4, y));
                            e.Graphics.DrawString(ledgerHead.Data.PaymentByDesignation, F, Brushes.Black, new Point(col5, y));
                            e.Graphics.DrawString(ledgerHead.Data.PaymentRecievedByDesignation, F, Brushes.Black, new Point(col6, y));
                            ledgerHead = ledgerHead.Next;
                        }

                    }
                }
            }



        }

        private void cmbxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxChoose.SelectedIndex == 0 && comboBox1.SelectedIndex == 1)
            {
                cmbxRelatedtoChoose.Enabled = false;
            }
            else if(cmbxChoose.SelectedIndex == 3 && comboBox1.SelectedIndex == 1)
            {
                cmbxRelatedtoChoose.Enabled = true;
                cmbxRelatedtoChoose.Items.Clear();
                DoublyLinkedListNode<Vendor> Head = VendorDL.VendorLinkedList.Head;
                while(Head != null)
                {
                    cmbxRelatedtoChoose.Items.Add(Head.Data.VendorName);
                    Head = Head.Next;
                }
            }
            else if(cmbxChoose.SelectedIndex == 2 && comboBox1.SelectedIndex == 1)
            {
                cmbxRelatedtoChoose.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                cmbxRelatedtoChoose.Enabled = true;
                cmbxRelatedtoChoose.Items.Clear();
                DoublyLinkedListNode<Product> Head = ProductDL.ProductList.Head;
                while (Head != null)
                {
                    cmbxRelatedtoChoose.Items.Add(Head.Data.Name);
                    Head = Head.Next;
                }
            }

            if(cmbxChoose.SelectedIndex == 0 && comboBox1.SelectedIndex == 0)
            {
                cmbxRelatedtoChoose.Enabled = false;
            }
            else if(cmbxChoose.SelectedIndex == 4 && comboBox1.SelectedIndex == 0)
            {
                cmbxRelatedtoChoose.Enabled = true;
                cmbxRelatedtoChoose.Items.Clear();
                cmbxRelatedtoChoose.Items.Add("Cash");
                cmbxRelatedtoChoose.Items.Add("Card");

            }
            else if(cmbxChoose.SelectedIndex == 2 && comboBox1.SelectedIndex == 0)
            {
                cmbxRelatedtoChoose.Enabled = true;
                cmbxRelatedtoChoose.Items.Clear();
                cmbxRelatedtoChoose.Items.Add("Deposit");
                cmbxRelatedtoChoose.Items.Add("Withdraw");
            }
            else if(cmbxChoose.SelectedIndex == 3 && comboBox1.SelectedIndex == 0)
            {
                cmbxRelatedtoChoose.Enabled = true;
                cmbxRelatedtoChoose.Items.Clear();
                cmbxRelatedtoChoose.Items.Add("CEO");
                cmbxRelatedtoChoose.Items.Add("Employee");
                cmbxRelatedtoChoose.Items.Add("Rider");
            }
            else if(cmbxChoose.SelectedIndex == 1 && comboBox1.SelectedIndex == 0)
            {
                cmbxRelatedtoChoose.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                cmbxChoose.Items.Clear();
                cmbxRelatedtoChoose.Items.Clear();
                cmbxChoose.Items.Add("All");
                cmbxChoose.Items.Add("Date");
                cmbxChoose.Items.Add("Payment Mode");
                cmbxChoose.Items.Add("Payment Received");
                cmbxChoose.Items.Add("Payment Type");
            }
            else
            {
                cmbxChoose.Items.Clear();
                cmbxRelatedtoChoose.Items.Clear();
                cmbxChoose.Items.Add("All");
                cmbxChoose.Items.Add("Product");
                cmbxChoose.Items.Add("Received Date");
                cmbxChoose.Items.Add("Vendor");
            }
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            cmbxChoose.SelectionStart = 0;

        }
    }
}
