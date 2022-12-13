using System;
using System.Collections.Generic;
using System.IO;
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
        public static void storeRecordIntoFile(Warehouse record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Id + "," + record.Name + "," + record.TotalSpace + "," + record.CurrentSpace
               + "," + record.OccupiedSpace + "," + record.Location.Latitude + "," + record.Location.Longitude + "," +
               record.Location.Area + "," + record.Location.City+ "," + record.Location.State);
            file.Flush();
            file.Close();
        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Warehouse record in warehousesList)
            {
                file.WriteLine(record.Id + "," + record.Name + "," + record.TotalSpace + "," + record.CurrentSpace
              + "," + record.OccupiedSpace + "," + record.Location.Latitude + "," + record.Location.Longitude + "," +
              record.Location.Area + "," + record.Location.City + "," + record.Location.State);
            }
            file.Flush();
            file.Close();
        }
        public static bool loadRecordFromFile(string path)
        {
            clearList();
            StreamReader fileVariable = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spilitedRecord = record.Split(',');
                    int id =Convert.ToInt32(spilitedRecord[0]);
                    string name= spilitedRecord[1]; 
                    double totalSpace=Convert.ToDouble(spilitedRecord[2]);
                    double currentSpace = Convert.ToDouble(spilitedRecord[3]);
                    double occupiedSpace = Convert.ToDouble(spilitedRecord[4]);
                    double latitude = Convert.ToDouble(spilitedRecord[5]);
                    double longitude = Convert.ToDouble(spilitedRecord[6]);
                    string area= spilitedRecord[7];
                    string city = spilitedRecord[8];
                    string state = spilitedRecord[9];

                    Location location=new Location(latitude,longitude,area, city, state);
                    Warehouse warehouse = new Warehouse(id, name, totalSpace, currentSpace, occupiedSpace,location);
                    warehousesList.Add(warehouse);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
