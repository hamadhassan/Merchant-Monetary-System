using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System.Forms.Orders
{
    public partial class frmAssignRider : Form
    {
       public  BL.Order order = new BL.Order();
        public frmAssignRider(BL.Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void frmAssignRider_Load(object sender, EventArgs e)
        {
            List<string> names = UsersDL.GetRider_Names();
            for (int i = 0; i < names.Count; i++)
            {
                cmbxRiders.Items.Add(names[i]);
            }
        }

        private void cmbxRiders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.order.AsssignedRiderName = cmbxRiders.Text;
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
