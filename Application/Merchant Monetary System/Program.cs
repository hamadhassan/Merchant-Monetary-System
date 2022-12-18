using Merchant_Monetary_System.Forms.Product;
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
            ShopKeeperDL.LoadDataFromFiles(FilePath.Shopkeeper);
            Misc.LoadCitiesOfPunjabFromFile(FilePath.City);
            VehicleDL.LoadDataFromFiles(FilePath.Vehcile);
            LedgerDL.LoadDataFromFiles(FilePath.Ledger);
            UsersDL.loadRecordFromFile(FilePath.Users);
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
                Application.Run(new frmReports());
=======
<<<<<<< Updated upstream
                Application.Run(new ViewShopkeeperDetails());
=======
                Application.Run(new frmCEODashboard());
>>>>>>> Stashed changes
>>>>>>> c38768b471d3f8a37d93a92ef975f054ef1bf107
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAddShopkeeper());
        }
    }
}
