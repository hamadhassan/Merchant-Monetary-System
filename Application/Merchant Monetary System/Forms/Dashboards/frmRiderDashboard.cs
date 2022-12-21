using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.Forms.Payment;
using Merchant_Monetary_System.Forms.Emails;
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;

namespace Merchant_Monetary_System.Forms.Dashboards
{
    public partial class frmRiderDashboard : Form
    {
        public string name;
        public string role;
        private  List<Shop> ShopList = new List<Shop>();
        public frmRiderDashboard(string name,string role)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
            DoublyLinkedList<Order> orders = OrderDL.getOrders_withrespectiveRider(name);
            DoublyLinkedListNode<Order> Head = orders.Head;
            while(Head!= null)
            {
                Shop s = shopDL.returnShopByName(Head.Data.ShopName);
                if (!isAlreadyAdded(s))
                {
                    ShopList.Add(s);
                }
                Head = Head.Next;
            }
        }
        public frmRiderDashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.tblForm.Controls.Count > 0)
                this.tblForm.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.tblForm.Controls.Add(f);
            this.tblForm.Tag = f;
            f.Show();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            loadform(new frmAddPayment());
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            loadform(new frmOrderDetail(role,name));

        }

        private void btnAddShopkeeper_Click(object sender, EventArgs e)
        {
            loadform(new frmAddShopkeeper());
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            loadform(new frmEmail());
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            loadform(new frmTakeOrder(name));

        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword());
        }

        private void tblForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRiderDashboard_Load(object sender, EventArgs e)
        {
            loadform(new frmAbout());
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmEmail());
        }
        private void forgotPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword(true));
        }

        private void takeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmTakeOrder(name));
        }

        private void addShopAndShopKeeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddShopkeeper());
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmOrderDetail(role, name));
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAddPayment());
        }

        private bool isAlreadyAdded(Shop s)
        {
            foreach(Shop S in ShopList)
            {
                if(S.Id == s.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
