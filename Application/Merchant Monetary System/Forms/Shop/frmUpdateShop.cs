using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    public partial class frmUpdateShop : Form
    {
        private BL.Shop shop;
        bool isShop = true;
        public frmUpdateShop(Shop UpdateShop)
        {
            InitializeComponent();
            this.shop = UpdateShop;
        }

        private void frmUpdateShop_Load(object sender, EventArgs e)
        {
            txtbxShopName.Text = shop.ShopName;
            cmbxCity.SelectedItem = cmbxCity.Items.IndexOf(shop.City);
            cmbxState.SelectedItem = cmbxState.Items.IndexOf(shop.State);
            comboboxArea.SelectedItem = comboboxArea.Items.IndexOf(shop.Area);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxShopName.Clear();
        }

        private void btnUpdateShop_Click(object sender, EventArgs e)
        {
            if(!isShop && cmbxCity.Text!="" && cmbxState.Text != "" && comboboxArea.Text != null)
            {
                shop.ShopName = txtbxShopName.Text;
                shop.City = cmbxCity.Text;
                shop.Area = comboboxArea.Text;
                shop.State = cmbxState.Text;
                MessageBox.Show("Shop Details Updated");
            }
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
        private void txtbxShopName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxShopName.Text == string.Empty)
            {// check is empty
                lblShopSignal.Text = "Enter the name";
                isShop = true;
            }
            else if (isValidString(txtbxShopName.Text)==false)
            {//check isSpecialCharactor
                lblShopSignal.Text = "Allowed characters: a-z, A-Z";
                isShop = true;
            }
            else
            {//ready for storage or action
                lblShopSignal.Text = " ";
                isShop = false;
            }
        }
    }
}
