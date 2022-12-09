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
        public frmAccountDetails()
        {
            InitializeComponent();
        }

        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            cmbxDesignation.SelectedIndex = 0;
            cmbxAttributes.SelectedIndex = 0;
            cmbxFiliter.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
