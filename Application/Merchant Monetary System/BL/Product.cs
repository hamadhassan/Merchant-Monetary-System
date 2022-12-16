﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.BL
{
    public class Product
    {
        private string name;
        private float weight;
        private double volume;
        private int sKU_Number;
        private string sensitivityType;
        private string category;
        private string manufacturer;

        public string Name { get => name; set => name = value; }
        public float Weight { get => weight; set => weight = value; }
        public double Volume { get => volume; set => volume = value; }
        public int SKU_Number { get => sKU_Number; set => sKU_Number = value; }
        public string SensitivityType { get => sensitivityType; set => sensitivityType = value; }
        public string Category { get => category; set => category = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }

        public Product(string Name, int  SKU_Number, float Weight , double Volume, string Manufacturer, string Category,  string SensitivityType)
        {
            this.Name= Name;
            this.SKU_Number = SKU_Number;
            this.Weight = Weight;
            this.Volume = Volume;
            this.Manufacturer = Manufacturer;
            this.Category = Category;
            this.sensitivityType = SensitivityType;

        }

    }
}
