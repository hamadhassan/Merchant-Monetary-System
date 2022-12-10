﻿using System;
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
    public partial class frmCEODashboard : Form
    {
        public frmCEODashboard()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddWarehouseManager_Click(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.pParent.Controls.Count > 0)
                this.pParent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pParent.Controls.Add(f);
            this.pParent.Tag = f;
            f.Show();
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            loadform(new frmForgetPassword());

        }

        private void frmCEODashboard_Load(object sender, EventArgs e)
        {
            ////The following block will be deleted after testing
            ////---------------------------------
            //loadform(new frmAccountDetails());
            //Crediationals crediational = new Crediationals("123", "1");
            //Users user = new Users("CEO", "abc", "male", 1234567891111, "mhhjutt@gmail.com", 123456789, "23232323", crediational);
            //UsersDL.UsersList.Add(user);
            //Crediationals crediational2 = new Crediationals("abc", "1");
            //Users user2 = new Users("CEO", "abc", "Female", 1234567891111, "mhhjutt@gmail.com", 123456789, "23232323", crediational2);
            //UsersDL.UsersList.Add(user2);
            ////--------------------------------
        }

        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmAccountDetails(true));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStriplblDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            toolStriplblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmSignUp(1));
        }
    }
}