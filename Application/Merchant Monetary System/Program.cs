﻿using Merchant_Monetary_System.Forms.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.Forms;
using Merchant_Monetary_System.Forms.Dashboards;
using Merchant_Monetary_System.Forms.Payment;
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.Forms.Emails;

namespace Merchant_Monetary_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmCEODashboard());
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAddShopkeeper());


        }
    }
}
