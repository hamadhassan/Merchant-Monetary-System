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

        public static string Users { get => users; set => users = value; }
        public static string Warehouse { get => warehouse; set => warehouse = value; }
        public static string Company { get => company; set => company = value; }
    }
}
