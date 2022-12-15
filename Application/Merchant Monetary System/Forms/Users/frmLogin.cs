using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Merchant_Monetary_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {//respective dashboard will be open 
            string designation = cmbxDesignation.Text;
            string username = txtbxUsername.Text;
            string password = txtbxPassowrd.Text;
            UsersDL.loadRecordFromFile(FilePath.Users);
            if (UsersDL.isUserCrediationalMatch(designation, username, password))
            {//authorize to enter into the system 
                if (cmbxDesignation.SelectedIndex == 1)
                {
                    frmCEODashboard frmCEODashboard = new frmCEODashboard();
                    frmCEODashboard.Show();
                    this.Hide();
                }
                else if (cmbxDesignation.SelectedIndex == 2)
                {
                    frmEmployeeDashboard frmEmployeeDashboard = new frmEmployeeDashboard();
                    frmEmployeeDashboard.Show();
                    this.Hide();
                   
                }

            }
            else
            {
                lblUsernameSignal.Text = "Invalid Username";
                lblPasswordSignal.Text = "Invalid Password";
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgetPassword frmForgetPassword = new frmForgetPassword();
            frmForgetPassword.Show();
            this.Hide();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbxDesignation.SelectedIndex = 0;
            //The following block will be deleted after testing
            //--------------------------------
            Users user = new Users("CEO", "abc", "male", 1234567891111, "mhhjutt@gmail.com", 123456789, "23232323", "abc","1");
            UsersDL.UsersList.Add(user);
            Users user2 = new Users("Employee", "abc", "Female", 1234567891111, "mhhjutt@gmail.com", 123456789, "23232323", "abc","1");
            UsersDL.UsersList.Add(user2);
            //--------------------------------

        }

        private void cmbxDesignation_Leave(object sender, EventArgs e)
        {
            if (cmbxDesignation.SelectedIndex == 0)
            {
                lblDesignationSingal.Text = "Select a Designation";
            }
            else
            {
                lblDesignationSingal.Text = " ";
            }
        }

        private void btnShowPassword_MouseHover(object sender, EventArgs e)
        {
            txtbxPassowrd.UseSystemPasswordChar=false;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtbxPassowrd.UseSystemPasswordChar = true;
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsernameSignal.Text = " ";
        }

        private void txtbxUsername_Leave(object sender, EventArgs e)
        {//Username must be enter 
            if (txtbxUsername.Text.Length <= 2)
            {
                lblUsernameSignal.Text = "Enter Correct Username";
            }
            else
            {
                lblUsernameSignal.Text = " ";
            }
        }

        private void txtbxPassowrd_Leave(object sender, EventArgs e)
        {
            //Password must be enter 
            if (txtbxPassowrd.Text.Length < 8)
            {
                lblPasswordSignal.Text = "Enter Correct Password";
            }
            else
            {
                lblPasswordSignal.Text = " ";
            }
        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }

        private void lblDesignationSingal_Click(object sender, EventArgs e)
        {

        }

        private void lblUsernameSignal_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
