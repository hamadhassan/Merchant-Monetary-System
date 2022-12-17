using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System.BL
{
    public class Product
    {
        private string name;
        private double weight;
        private double volume;
        private int sKU_Number;
        private string sensitivityType;
        private string category;
        private string manufacturer;

        public string Name { get => name; set => name = value; }
        public double Volume { get => volume; set => volume = value; }
        public int SKU_Number { get => sKU_Number; set => sKU_Number = value; }
        public string SensitivityType { get => sensitivityType; set => sensitivityType = value; }
        public string Category { get => category; set => category = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Weight { get => weight; set => weight = value; }

        public Product(string Name, int  SKU_Number, double Weight , double Volume, string Manufacturer, string Category,  string SensitivityType)
        {
            this.Name= Name;
            this.SKU_Number = SKU_Number;
            this.Weight = Weight;
            this.Volume = Volume;
            this.Manufacturer = Manufacturer;
            this.Category = Category;
            this.sensitivityType = SensitivityType;
        }
        public Product()
        {
        }
        public static void storeRecordIntoFile(Product record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Name + "," + record.SKU_Number + "," + record.Weight + "," + record.Volume
                 + "," + record.SensitivityType + "," + record.Category + "," + record.Manufacturer);
            file.Flush();
            file.Close();
        }
    }
}
