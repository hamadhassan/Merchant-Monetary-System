﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class FilePath
    {
        private static string users = "Users.csv";
        private static string warehouse = "Warehouse.csv";
        private static string company = "Company.txt";
        private static string category = "Category.csv";
        private static string products = "Products.csv";
        private static string vendors = "Vendors.csv";
        private static string stock = "Stocks.csv";
        private static string shopkeeper = "Shopkeepers.csv";
        private static string city = "City.csv";
        private static string orders = "Orders.csv";
        private static string vehcile = "vehicles.csv";
        private static string ledger = "Ledgers.csv";
        private static string routes = "Routes.txt";


        public static string Users { get => users; set => users = value; }
        public static string Warehouse { get => warehouse; set => warehouse = value; }
        public static string Company { get => company; set => company = value; }
        public static string Category { get => category; set => category = value; }
        public static string Products { get => products; set => products = value; }
        public static string Vendors { get => vendors; set => vendors = value; }
        public static string Stock { get => stock; set => stock = value; }
        public static string Shopkeeper { get => shopkeeper; set => shopkeeper = value; }
        public static string City { get => city; set => city = value; }
        public static string Orders { get => orders; set => orders = value; }
        public static string Vehcile { get => vehcile; set => vehcile = value; }
        public static string Ledger { get => ledger; set => ledger = value; }
        public static string Routes { get => routes; set => routes = value; }
    }
}
