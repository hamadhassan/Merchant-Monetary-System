using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchant_Monetary_System.BL;
using System.IO;


namespace Merchant_Monetary_System.DL
{
    public class VehicleDL
    {
        private static List<Vehicle> vehicleList = new List<Vehicle>();

        public static List<Vehicle> VehicleList { get => vehicleList; set => vehicleList = value; }

        public static void addIntoList(Vehicle vehicle)
        {
            VehicleList.Add(vehicle);
        }
        public static bool deleteVehicle(Vehicle V)
        {
            foreach(Vehicle vehicle in VehicleList)
            {
                if(vehicle == V)
                {
                    vehicleList.Remove(vehicle);
                    return true;
                }
            }
            return false;
        }
        public static void StoreVehicleDataIntoFiles(string path)
        {
            StreamWriter file = new StreamWriter(path);
            int i = 0;
            foreach(Vehicle vehicle in VehicleList)
            {
                file.Write(vehicle.VehicleType + "," + vehicle.VehicleWeight + "," + vehicle.VehicleVolume + "," + vehicle.RegistrationNumber + "," + vehicle.Assigned);
                if (i != vehicleList.Count - 1)
                    file.WriteLine();
                i++;
            }
            file.Close();
        }

        public static void LoadDataFromFiles(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while((record = file.ReadLine()) != null)
            {
                string[] SplittedRecord = record.Split(',');
                string vehicleType = SplittedRecord[0];
                double vehicleWeight = Double.Parse(SplittedRecord[1]);
                double vehicleVolume = Double.Parse(SplittedRecord[2]);
                string registrationNumber = SplittedRecord[3];
                bool assigned = bool.Parse(SplittedRecord[4]);
                Vehicle vehicle = new Vehicle(vehicleType,vehicleVolume,vehicleWeight,registrationNumber);
                vehicle.Assigned = assigned;
                VehicleDL.addIntoList(vehicle);
            }
            file.Close();
        }

        public static bool AlreadyExist(string registrationNo)
        {
            foreach(Vehicle V in vehicleList)
            {
                if(V.RegistrationNumber == registrationNo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
