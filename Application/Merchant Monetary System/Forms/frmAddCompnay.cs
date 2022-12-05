using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Merchant_Monetary_System
{
    public partial class frmAddCompnay : Form
    {
        public frmAddCompnay()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxName.Clear();
            txtbxContactNumber.Clear();
            rtxtbxAddress.Clear();
            
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(txtbxName_TextChanged(sender, e))
            {
                MessageBox.Show("store data");
            }
            else
            {
                frmSignUp frmSignUp = new frmSignUp();
                frmSignUp.Show();
                this.Hide();
            }
           
        }

        private bool txtbxName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {
                lblNameSignal.Text = "Enter the name";
                return true;
            }
            else if (int.TryParse(txtbxName.Text, out i))
            {
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                return true;
            }
            else if(txtbxName.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                return true;
            }
            else
            {
                lblNameSignal.Text = " ";
                return false;
            }
            return false;
        }
    }
}
