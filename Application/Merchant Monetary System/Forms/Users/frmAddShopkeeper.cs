using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Merchant_Monetary_System
{
    public partial class frmAddShopkeeper : Form
    {
        public event EventHandler isBtnFoundClicked;
        bool isCNIC = true;
        bool isName = true;
        bool isEmail = true;
        bool isPhone = true;
        bool isShop = true;
        Shopkeeper shopkeeperFound;
        public frmAddShopkeeper()
        {
            InitializeComponent();
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxShopName.Text == string.Empty)
            {// check is empty
                lblShopSignal.Text = "Enter the name";
                isShop = true;
            }
            else if (txtbxShopName.Text.Any(ch => !char.IsLetter(ch)))
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

        private void lblShopName_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char num in txtCNIC.Text)
            {
                count++;
            }
            Int64 i;
            if (txtCNIC.Text == string.Empty)
            {// check is empty
                lblCNICSignal.Text = "Enter the CNIC number";
                isCNIC = true;
            }
            else if (!Int64.TryParse(txtCNIC.Text, out i))
            {//Check isnumber
                lblCNICSignal.Text = "Allowed characters: 0-9";
                isCNIC = true;
            }
            else if (!(count == 13))
            {//check count
                lblCNICSignal.Text = "Lenght must be 13 characters";
                isCNIC = true;
            }
            else
            {//ready for storage
                lblCNICSignal.Text = " ";
                isCNIC = false;
                shopkeeperFound = ShopKeeperDL.returnShopkeeperDetails(Double.Parse(txtCNIC.Text));
                if(shopkeeperFound != null)
                {
                    btnFound.Enabled = true;
                    btnFound.Visible = true;
                }
            }
            if(isCNIC)
            {
                btnFound.Enabled = false;
                btnFound.Visible = false;
            }
        }

        private void txtbxShopkeeperName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxShopkeeperName.Text == string.Empty)
            {// check is empty
                lblNameSignal.Text = "Enter the name";
                isName = true;
            }
            else if (txtbxShopkeeperName.Text.Any(ch => !char.IsLetter(ch)))
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

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {
            bool isSpecialChar = false;
            foreach (char c in txtbxEmail.Text)
            {//is special charactor
                if (c == '@')
                {
                    isSpecialChar = true;
                    lblEmailSignal.Text = " ";
                }
            }
            if (txtbxEmail.Text == string.Empty)
            {// check is empty
                lblEmailSignal.Text = "Enter the email-address";
            }
            else if (isSpecialChar == false)
            {// check is has @ sign
                lblEmailSignal.Text = "Enter the correct address";
            }
            else
            {//ready for storage
                lblEmailSignal.Text = " ";
                isEmail = false;
            }
        }

        private void txtbxShopkeeperNumber_TextChanged(object sender, EventArgs e)
        {
            long i;
            int count = 0;
            foreach (char num in txtbxShopkeeperNumber.Text)
            {
                count++;
            }
            if (txtbxShopkeeperNumber.Text == string.Empty)
            {// check is empty
                lblContactSignal.Text = "Enter the contact number";
                isPhone = true;
            }
            else if (!Int64.TryParse(txtbxShopkeeperNumber.Text, out i))
            {//Check isnumber
                lblContactSignal.Text = "Allowed characters: 0-9";
                isPhone = true;
            }
            else if (!(count == 11))
            {//check count
                lblContactSignal.Text = "Lenght must be 11 characters";
                isPhone = true;
            }
            else
            {//ready for storage
                lblContactSignal.Text = " ";
                isPhone = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxShopName.Clear();
            txtbxShopkeeperName.Clear();
            txtbxEmail.Clear();
            txtbxShopkeeperNumber.Clear();
            txtCNIC.Clear();
            comboboxArea.Text = "";
            cmbxCity.Text = "";
            cmbxState.Text = "";
        }

        private void btnAddShopKeeper_Click(object sender, EventArgs e)
        {
            if(!isCNIC && !isEmail && !isName && !isPhone && !isShop && cmbxCity.Text != "" && cmbxState.Text != "" && comboboxArea.Text !="")
            {
                string shopkeeperName = txtbxShopkeeperName.Text;
                double cnic = double.Parse(txtCNIC.Text);
                string email = txtbxEmail.Text;
                double contact = double.Parse(txtbxShopkeeperNumber.Text);
                Shopkeeper shopkeeper = new Shopkeeper();
                if (!ShopKeeperDL.MatchShopkeeper(cnic, shopkeeperName))
                {
                    MessageBox.Show("Already Registered with given CNIC", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                }
                else
                {
                    if (ShopKeeperDL.returnShopkeeperDetails(cnic) != null)
                    {
                        shopkeeper = ShopKeeperDL.returnShopkeeperDetails(cnic);
                    }
                    else
                    {
                        shopkeeper = new Shopkeeper(shopkeeperName, cnic, email, contact);
                    }
                    string shopName = txtbxShopName.Text;
                    string city = cmbxCity.Text;
                    string area = comboboxArea.Text;
                    string state = cmbxState.Text;
                    string ID = shopDL.generateUniqueID();
                    Shop shop = new Shop(ID, shopName, city, area, state);
                    shopDL.addDataIntoList(shop);
                    shopkeeper.ShopList.Add(shop);
                    ShopKeeperDL.StoreDataIntoFiles(FilePath.Shopkeeper);
                    MessageBox.Show("Shopkeeper Along with the Shop Added", "Adding...");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddShopkeeper_Load(object sender, EventArgs e)
        {
            this.isBtnFoundClicked += new System.EventHandler(this.FillAllFieldsforShopkeeper);
        }

        private void FillAllFieldsforShopkeeper(object sender, EventArgs e)
        {
            Shopkeeper shopkeeper = (Shopkeeper)sender; 
            txtbxEmail.Text = shopkeeper.Email;
            txtbxShopkeeperName.Text = shopkeeper.ShopkeeperName;
            txtbxShopkeeperNumber.Text = shopkeeper.ContactNumber.ToString();
        }

        private void btnFound_Click(object sender, EventArgs e)
        {
            isBtnFoundClicked?.Invoke(shopkeeperFound, EventArgs.Empty);
        }
    }
}
