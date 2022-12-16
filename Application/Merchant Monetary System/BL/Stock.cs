using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.BL
{
    public class Stock
    {
        public Stock(string product, int quantity, double retailPrice, double costPrice, DateTime manufacturingDate, DateTime expiryDate, DateTime recievedDate, string vendor)
        {
            this.product = product;
            this.quantity = quantity;
            this.retailPrice = retailPrice;
            this.costPrice = costPrice;
            this.manufacturingDate = manufacturingDate;
            this.expiryDate = expiryDate;
            this.recievedDate = recievedDate;
            this.vendor = vendor;
        }
        private string product;
        private int quantity;
        private double retailPrice;
        private double costPrice;
        private DateTime manufacturingDate;
        private DateTime expiryDate;
        private DateTime recievedDate;
        private string vendor;

        public string Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double RetailPrice { get => retailPrice; set => retailPrice = value; }
        public double CostPrice { get => costPrice; set => costPrice = value; }
        public DateTime ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public DateTime RecievedDate { get => recievedDate; set => recievedDate = value; }
        public string Vendor { get => vendor; set => vendor = value; }

        public void addQuantity(int quantity)
        {
            this.quantity += quantity;
        }

        public void decreaseQuantity(int quantity)
        {
            this.quantity -= quantity;
        }
    }
}
