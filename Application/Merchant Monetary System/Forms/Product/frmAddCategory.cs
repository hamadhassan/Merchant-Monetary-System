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
using System.Xml.Linq;
using Merchant_Monetary_System;
using System.Text.RegularExpressions;
using Merchant_Monetary_System.BL;

namespace Merchant_Monetary_System.Forms.Product
{
    public partial class frmAddCategory : Form
    {
        bool isName = true;
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "" && !isName)
            {
                Category category = new Category(txtCategory.Text);
                categoryDL.addIntoCategoryList(category);
                categoryDL.StoreDataIntoFiles(FilePath.Category);
                MessageBox.Show("Category Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill the field correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblCategoryValid_Click(object sender, EventArgs e)
        {

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
        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtCategory.Text == string.Empty)
            {// check is empty
                lblCategoryValid.Text = "Enter the category";
                isName = true;
            }
            else if (isValidString(txtCategory.Text)==false)
            {//Check isnumberic
                lblCategoryValid.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else if (txtCategory.Text.Any(ch => !char.IsLetter(ch)))
            {//check isSpecialCharactor
                lblCategoryValid.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else
            {//ready for storage or action
                lblCategoryValid.Text = " ";
                isName = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblCategoryTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
