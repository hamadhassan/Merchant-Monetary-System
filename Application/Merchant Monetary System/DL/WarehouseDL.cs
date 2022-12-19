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
        private static DoublyLinkedList<Warehouse> warehousesList = new DoublyLinkedList<Warehouse>();

        public static DoublyLinkedList<Warehouse> WarehousesList { get => warehousesList; set => warehousesList = value; }

        public static bool updateRecord(Warehouse updatedWarehouse)
        {
            DoublyLinkedListNode<Warehouse> Head = WarehousesList.Head;
            while(Head != null)
            {
                if (updatedWarehouse.Id == Head.Data.Id)
                {
                    Head.Data.Name = updatedWarehouse.Name;
                    Head.Data.TotalSpace = updatedWarehouse.TotalSpace;
                    Head.Data.Location = updatedWarehouse.Location;
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }
        public static bool deleteRecord(Warehouse deleteWarehouse)
        {
            DoublyLinkedListNode<Warehouse> Head = WarehousesList.Head;
            while (Head != null)
            {
                if(deleteWarehouse.Id == Head.Data.Id)
                {
                    WarehousesList.RemoveNode(Head);
                    return true;
                }
                Head = Head.Next;
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
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                DoublyLinkedListNode<Warehouse> Head = WarehousesList.Head;
                while (Head != null)
                {
                    file.WriteLine(Head.Data.Id + "," + Head.Data.Name + "," + Head.Data.TotalSpace + "," + Head.Data.CurrentSpace
                    + "," + Head.Data.OccupiedSpace + "," + Head.Data.Location.Latitude + "," + Head.Data.Location.Longitude + "," +
                    Head.Data.Location.Area + "," + Head.Data.Location.City + "," + Head.Data.Location.State);
                    Head = Head.Next;

                }
                file.Flush();
                file.Close();
            }
        }
        public static bool loadRecordFromFile(string path)
        {
            
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
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
                    WarehousesList.Add(warehouse);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Warehouse returnWarehouse(int id)
        {
            DoublyLinkedListNode<Warehouse> Head = WarehousesList.Head;
            while(Head!=null)
            {
                if(Head.Data.Id == id)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;
        }

    }
}
