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
    public partial class frmIntroduction : Form
    {
        public frmIntroduction()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            if (CompanyDL.loadRecordFromFile(FilePath.Company)==false)
            {
                frmAddCompnay frmAddCompnay = new frmAddCompnay();
                frmAddCompnay.Show();
                this.Hide();
            }
            else
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
          
        }

        private void frmIntroduction_Load(object sender, EventArgs e)
        {
            
        }
    }
}
