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
using Merchant_Monetary_System.DL;
using Merchant_Monetary_System.Forms.Vehicle;
using Merchant_Monetary_System.Reports;

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
            categoryDL.loadDataFromFiles(FilePath.Category);
            ShopKeeperDL.LoadDataFromFiles(FilePath.Shopkeeper);
            Misc.LoadCitiesOfPunjabFromFile(FilePath.City);
            VehicleDL.LoadDataFromFiles(FilePath.Vehcile);
            LedgerDL.LoadDataFromFiles(FilePath.Ledger);
            UsersDL.loadRecordFromFile(FilePath.Users);
            WarehouseDL.loadRecordFromFile(FilePath.Warehouse);
            VendorDL.loadRecordFromFile(FilePath.Vendors);
            ProductDL.loadRecordFromFile(FilePath.Products);
            OrderDL.loadRecordFromFile(FilePath.Orders);
            StockDL.LoadDataFromFile(FilePath.Stock);

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmIntroduction());
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }

        }
    }
}
