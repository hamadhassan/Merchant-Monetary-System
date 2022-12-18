using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Merchant_Monetary_System.DL
{
    public class LedgerDL
    {
        private static List<Ledger> ledgers = new List<Ledger>();

        public static List<Ledger> Ledgers { get => ledgers; set => ledgers = value; }

        public static void addintoList(Ledger ledger)
        {
            ledgers.Add(ledger);
        }

        public static void StoreDataIntoFiles(string path)
        {
            StreamWriter file = new StreamWriter(path);
            int i = 0;
            foreach(var ledger in Ledgers)
            {
                file.Write(ledger.PaymentType + "," + ledger.PaymentMode + "," + ledger.CurrentDate.ToString() + "," + ledger.Amount);
                file.Write("," + ledger.PaymentByDesignation + "," + ledger.PaymentByName + "," + ledger.PaymentRecievedByDesignation + "," + ledger.PaymentRecievedByName);
                file.Write("," + ledger.Description);
                file.Flush();
                i++;
                if (i != 0)
                    file.WriteLine();
            }
            file.Close();
        }

        public static void LoadDataFromFiles(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] SplittedRecord = record.Split(',');
                    string paymentType = SplittedRecord[0];
                    string paymentMode = SplittedRecord[1];
                    DateTime currentDate = DateTime.Parse(SplittedRecord[2]);
                    double amount = Double.Parse(SplittedRecord[3]);
                    string ByDesignation = SplittedRecord[4];
                    string ByName = SplittedRecord[5];
                    string ReceivedByDesignation = SplittedRecord[6];
                    string ReceivedByName = SplittedRecord[7];
                    string description = SplittedRecord[8];
                    Ledger ledger = new Ledger(paymentType, paymentMode, currentDate, amount, ByDesignation, ByName, ReceivedByDesignation, ReceivedByName, description);
                    LedgerDL.addintoList(ledger);
                }
                file.Close();
            }
        }

        public static bool deleteOnlyLedgerDetails(Ledger ledger)
        {
            foreach(Ledger l in ledgers)
            {
                if(l == ledger)
                {
                    ledgers.Remove(l);
                    return true;
                }
            }
            return false;
        }
    }
}
