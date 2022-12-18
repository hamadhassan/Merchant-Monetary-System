using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.BL
{
    public class Vehicle
    {
        private string vehicleType;
        private double vehicleVolume;
        private double vehicleWeight;
        private string registrationNumber;

        public Vehicle(string vehicleType, double vehicleVolume, double vehicleWeight, string registrationNumber)
        {
            VehicleType = vehicleType;
            VehicleVolume = vehicleVolume;
            VehicleWeight = vehicleWeight;
            RegistrationNumber = registrationNumber;
        }

        public string VehicleType { get => vehicleType; set => vehicleType = value; }
        public double VehicleVolume { get => vehicleVolume; set => vehicleVolume = value; }
        public double VehicleWeight { get => vehicleWeight; set => vehicleWeight = value; }
        public string RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
    }
}
