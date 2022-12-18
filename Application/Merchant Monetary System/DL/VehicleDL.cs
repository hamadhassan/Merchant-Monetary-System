using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchant_Monetary_System.BL;

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
        public static void deleteVehicle(Vehicle V)
        {
            VehicleList.Remove(V);
        }

    }
}
