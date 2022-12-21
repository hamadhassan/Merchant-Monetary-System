using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchant_Monetary_System.BL;
using System.IO;
using System.Windows.Forms;

namespace Merchant_Monetary_System.DL
{
    public class VehicleDL
    {
        private static List<Vehicle> vehicleList = new List<Vehicle>();
        private static DoublyLinkedList<Vehicle> vehicleLinkedList = new DoublyLinkedList<Vehicle>();

        public static List<Vehicle> VehicleList { get => vehicleList; set => vehicleList = value; }
        public static DoublyLinkedList<Vehicle> VehicleLinkedList { get => vehicleLinkedList; set => vehicleLinkedList = value; }

        public static void addIntoList(Vehicle vehicle)
        {
            VehicleLinkedList.Add(vehicle);
        }
        public static bool deleteVehicle(Vehicle V)
        {
            DoublyLinkedListNode<Vehicle> Head = VehicleLinkedList.Head;
            while(Head != null)
            {
                if(Head.Data.RegistrationNumber == V.RegistrationNumber)
                {
                    VehicleLinkedList.RemoveNode(Head);
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }
        public static void StoreVehicleDataIntoFiles(string path)
        {
            DoublyLinkedListNode<Vehicle> Head = VehicleLinkedList.Head;
            StreamWriter file = new StreamWriter(path);
            int i = 0;
            while (Head != null)
            {
                file.Write(Head.Data.VehicleType + "," + Head.Data.VehicleWeight + "," + Head.Data.VehicleVolume + "," + Head.Data.RegistrationNumber + "," + Head.Data.Assigned);
                if (i != vehicleLinkedList.Count - 1)
                    file.WriteLine();
                i++;
                Head = Head.Next;
            }
            file.Close();
        }

        public static void LoadDataFromFiles(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    StreamReader file = new StreamReader(path);
                    string record;
                    while ((record = file.ReadLine()) != null && (record = file.ReadLine()) != "")
                    {

                        string[] SplittedRecord = record.Split(',');
                        string vehicleType = SplittedRecord[0];
                        double vehicleWeight = Double.Parse(SplittedRecord[1]);
                        double vehicleVolume = Double.Parse(SplittedRecord[2]);
                        string registrationNumber = SplittedRecord[3];
                        bool assigned = bool.Parse(SplittedRecord[4]);
                        Vehicle vehicle = new Vehicle(vehicleType, vehicleVolume, vehicleWeight, registrationNumber);
                        vehicle.Assigned = assigned;
                        VehicleDL.addIntoList(vehicle);
                    }
                    file.Close();
                }
            }
            catch(Exception ex) { }
           
        }

        public static bool AlreadyExist(string registrationNo)
        {
            DoublyLinkedListNode<Vehicle> Head = VehicleLinkedList.Head;
            while(Head != null)
            {
                if (Head.Data.RegistrationNumber == registrationNo)
                {
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }

        public static Vehicle returnVehicleData(string registrationNo)
        {
            DoublyLinkedListNode<Vehicle> Head = VehicleLinkedList.Head;
            while (Head != null)
            {
                if (Head.Data.RegistrationNumber == registrationNo)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;
        }
    }
}
