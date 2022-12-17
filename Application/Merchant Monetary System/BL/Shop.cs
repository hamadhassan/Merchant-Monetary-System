using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.BL
{
    public class Shop
    {
        private string id;
        private string shopName;
        private string city;
        private string area;
        private string state;

        public Shop(string id, string shopName, string city, string area, string state)
        {
            this.Id = id;
            this.ShopName = shopName;
            this.City = city;
            this.Area = area;
            this.State = state;
        }

        public string Id { get => id; set => id = value; }
        public string ShopName { get => shopName; set => shopName = value; }
        public string City { get => city; set => city = value; }
        public string Area { get => area; set => area = value; }
        public string State { get => state; set => state = value; }
    }
}
