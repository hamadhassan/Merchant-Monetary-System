using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class Warehouse
    {
        private int id=0;
        private string name;
        private double totalSpace;
        private double currentSpace;
        private double occupiedSpace;
        private Location location;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double TotalSpace { get => totalSpace; set => totalSpace = value; }
        public double CurrentSpace { get => currentSpace; set => currentSpace = value; }
        public double OccupiedSpace { get => occupiedSpace; set => occupiedSpace = value; }
        public Location Location { get => location; set => location = value; }

        public Warehouse(string name,float totalSpace,Location location)
        {//for take user data
            id = id + 1;
            this.name = name;
            this.totalSpace = totalSpace;
            this.location = location;
        }
        public Warehouse(int id,string name, double totalSpace, double currentSpace, double occupiedSpace,Location location)
        {//For load data 
            this.id = id;
            this.name=name;
            this.totalSpace = totalSpace;
            this.currentSpace = currentSpace;
            this.occupiedSpace = occupiedSpace;
            this.location = location;
        }


    }
}
