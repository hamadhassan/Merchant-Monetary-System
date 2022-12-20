using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.BL
{
    public class Shopkeeper
    {
        private string shopkeeperName;
        private double cnic;
        private string email;
        private double contactNumber;
        private DoublyLinkedList<Shop> shopList;

        public Shopkeeper(string shopkeeperName, double cnic, string email, double contactNumber)
        {
            ShopkeeperName = shopkeeperName;
            Cnic = cnic;
            Email = email;
            ContactNumber = contactNumber;
            ShopList = new DoublyLinkedList<Shop>();
        }
        public Shopkeeper()
        {

        }

        public string ShopkeeperName { get => shopkeeperName; set => shopkeeperName = value; }
        public double Cnic { get => cnic; set => cnic = value; }
        public string Email { get => email; set => email = value; }
        public double ContactNumber { get => contactNumber; set => contactNumber = value; }
        public DoublyLinkedList<Shop> ShopList { get => shopList; set => shopList = value; }
    }
}
