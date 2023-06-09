﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.BL
{
    public class Ledger
    {
        private string id;
        private string paymentType;
        private string paymentMode;
        private DateTime currentDate;
        private double amount;
        private string paymentByDesignation;
        private string paymentByName;
        private string paymentRecievedByDesignation;
        private string paymentRecievedByName;
        private string description;

        public Ledger(string paymentType, string paymentMode, DateTime currentDate, double amount, string paymentByDesignation, string paymentByName, string paymentRecievedByDesignation, string paymentRecievedByName, string description)
        {
            id = generateUniqueID();
            PaymentType = paymentType;
            PaymentMode = paymentMode;
            CurrentDate = currentDate;
            Amount = amount;
            PaymentByDesignation = paymentByDesignation;
            PaymentByName = paymentByName;
            PaymentRecievedByDesignation = paymentRecievedByDesignation;
            PaymentRecievedByName = paymentRecievedByName;
            Description = description;
        }
        public Ledger()
        {

        }

        public string PaymentType { get => paymentType; set => paymentType = value; }
        public string PaymentMode { get => paymentMode; set => paymentMode = value; }
        public DateTime CurrentDate { get => currentDate; set => currentDate = value; }
        public double Amount { get => amount; set => amount = value; }
        public string PaymentByDesignation { get => paymentByDesignation; set => paymentByDesignation = value; }
        public string PaymentByName { get => paymentByName; set => paymentByName = value; }
        public string PaymentRecievedByDesignation { get => paymentRecievedByDesignation; set => paymentRecievedByDesignation = value; }
        public string PaymentRecievedByName { get => paymentRecievedByName; set => paymentRecievedByName = value; }
        public string Description { get => description; set => description = value; }
        public string Id { get => id; set => id = value; }

        public void decreaseAmount(double amount)
        {
            this.Amount -= amount;
        }
        public void increaseAmount(double amount)
        {
            this.Amount += amount;
        }
        public static string generateUniqueID(int _characterLength = 5)
        {
            StringBuilder _builder = new StringBuilder();
            Enumerable
                .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(_characterLength)
                .ToList().ForEach(e => _builder.Append(e));
            return _builder.ToString();
        }
    }
}
