using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class WarehouseDL
    {
        private static List<Warehouse> warehousesList = new List<Warehouse>();

        public static List<Warehouse> WarehousesList { get => warehousesList; set => warehousesList = value; }

       
    }
}
