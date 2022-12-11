using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class Warehouse
    {
        private int id;
        private string name;
        private float totalSpace;
        private float currentSpace;
        private float occupiedSpace;
        private Location location;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float TotalSpace { get => totalSpace; set => totalSpace = value; }
        public float CurrentSpace { get => currentSpace; set => currentSpace = value; }
        public float OccupiedSpace { get => occupiedSpace; set => occupiedSpace = value; }
        public Location Location { get => location; set => location = value; }

        public Warehouse(string name,float totalSpace,Location location)
        {
            this.name = name;
            this.totalSpace = totalSpace;
            this.location = location;
        }


    }
}
