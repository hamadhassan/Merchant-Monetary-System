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
        public static void clearList()
        {
            WarehousesList.Clear();
        }
        public static bool updateRecord(Warehouse updatedWarehouse)
        {
            foreach (Warehouse w in warehousesList)
            {
                if (updatedWarehouse.Id == w.Id)
                {
                    w.Name = updatedWarehouse.Name;
                    w.TotalSpace = updatedWarehouse.TotalSpace;
                    w.Location= updatedWarehouse.Location;
                    return true;
                }
            }
            return false;
        }
        public static bool deleteRecord(Warehouse deleteWarehouse)
        {
            foreach (Warehouse w in warehousesList)
            {
                if (deleteWarehouse.Id == w.Id)
                {
                    WarehousesList.Remove(w);
                    return true;
                }
            }
            return false;
        }

    }
}
