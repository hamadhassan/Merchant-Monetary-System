﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using static Microsoft.Scripting.PerfTrack;

namespace Merchant_Monetary_System
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }
        private void clearField()
        {
            txtbxName.Clear();
            txtbxSKU_ID.Clear();
            txtbxWeight.Clear();
            txtbxVolume.Clear();
        }
        //--------------Check is field is filled and user this information for action--------
        bool isName = true;
        bool isSKU_Number = true;
        bool isWeight = true;
        bool isVolume = true;

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public bool isValidString(string input)
        {
            bool isValid = true;
            isValid = Regex.IsMatch(input, @"^[a-zA-Z]+$");
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                    isValid = false;
            }
            return isValid;
        }
        private void txtbxName_TextChanged_1(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {// check is empty
                lblNameSignal.Text = "Enter the name";
                isName = true;
            }
            else if (isValidString(txtbxName.Text)==false)
            {//Check isnumberic
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else if (txtbxName.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else
            {//ready for storage or action
                lblNameSignal.Text = " ";
                isName = false;
            }
        }

        private void gbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxSKU_ID_TextChanged(object sender, EventArgs e)
        {
            {
                int i;
                if (txtbxSKU_ID.Text == string.Empty)
                {// check is empty
                    lblS_Number.Text = "Enter the SKU number";
                    isSKU_Number = true;
                }
                else if (!int.TryParse(txtbxSKU_ID.Text, out i))
                {//Check isalphabetic
                    lblS_Number.Text = "Allowed characters: 0-9";
                    isSKU_Number = true;
                }
                else if (txtbxSKU_ID.Text.Any(ch => !char.IsLetterOrDigit(ch)))
                {//check isSpecialCharactor
                    lblS_Number.Text = "Allowed characters: 0-9";
                    isSKU_Number = true;
                }
                else
                {//ready for storage
                    lblS_Number.Text = " ";
                    isSKU_Number = false;
                }
            }
        }

        private void txtbxWeight_TextChanged(object sender, EventArgs e)
        {
            {
                int i;
                if (txtbxWeight.Text == string.Empty)
                {// check is empty
                    lbl_Weight.Text = "Enter the Weight";
                    isWeight = true;
                }
                else if (txtbxWeight.Text.Any(ch => !char.IsDigit(ch)))
                {//check isSpecialCharactor
                    lbl_Weight.Text = "Allowed characters: 0-9";
                    isWeight = true;
                }
                else
                {//ready for storage
                    lbl_Weight.Text = " ";
                    isWeight = false;
                }
            }
        }

        private void txtbxVolume_TextChanged(object sender, EventArgs e)
        {
            {
                int i;
                if (txtbxVolume.Text == string.Empty)
                {// check is empty
                    lbl_Volume.Text = "Enter the Volume";
                    isVolume = true;
                }
                //else if (!int.TryParse(txtbxSKU_ID.Text, out i))
                //{//Check isalphabetic
                //    lbl_Volume.Text = "Allowed characters: 0-9";
                //    isVolume = true;
                //}
                else if (txtbxVolume.Text.Any(ch => !char.IsDigit(ch)))
                {//check isSpecialCharactor
                    lbl_Volume.Text = "Allowed characters: 0-9";
                    isVolume = true;
                }
                else
                {//ready for storage
                    lbl_Volume.Text = " ";
                    isVolume = false;
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isName && !isSKU_Number && !isWeight && !isVolume && cmbxCategory.Text != "" && cmbxManufacture.Text != "" && cmbxSenstivity.Text != "")
                {
                    string name = txtbxName.Text;
                    int sku_number = Convert.ToInt16(txtbxSKU_ID.Text);
                    double weight = Convert.ToInt64(txtbxWeight.Text);
                    double Volume = Convert.ToInt64(txtbxVolume.Text);
                    string manufacturer = cmbxManufacture.Text;
                    string category = cmbxCategory.Text;
                    string sensitivity = cmbxSenstivity.Text;
                    Product product = new Product(name, sku_number, weight, Volume, manufacturer, sensitivity, category);
                    ProductDL.ProductList.Add(product);
                    Product.storeRecordIntoFile(product, FilePath.Products);
                    MessageBox.Show("Product successfully added");
                }
                else
                {
                    MessageBox.Show("Fill All fields correctly");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

            DoublyLinkedListNode<Category> Head = categoryDL.Categories.Head;
            while (Head != null) {
                cmbxCategory.Items.Add(Head.Data.CategoryName);
                Head = Head.Next;
            }
            DoublyLinkedListNode<Vendor> Header = VendorDL.VendorLinkedList.Head;
            while (Header != null)
            {
                cmbxManufacture.Items.Add(Header.Data.VendorName);
                Header = Header.Next;
            }

        }
    }
}
