using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Merchant_Monetary_System.Data_Structure.HashTable;

namespace Merchant_Monetary_System.DL
{
    public class LedgerDL
    {
        private static int size = 20;
        private static HashTable ledgers = new HashTable(20);

        public static HashTable Ledgers { get => ledgers; set => ledgers = value; }

        public static void addintoList(Ledger ledger)
        {
            ledgers.Add(ledger);
        }

        public static void StoreDataIntoFiles(string path)
        {
            StreamWriter file = new StreamWriter(path);

            for( int i=0; i<ledgers.Size; i++ )
            {
                if (ledgers.HashTableData[i] != null)
                {
                    DoublyLinkedListNode<Ledger> Head = ledgers.HashTableData[i].Head;
                    int j = 0;
                    while (Head != null)
                    {
                        file.Write(Head.Data.Id + "," + Head.Data.PaymentType + "," + Head.Data.PaymentMode + "," + Head.Data.CurrentDate.ToString() + "," + Head.Data.Amount);
                        file.Write("," + Head.Data.PaymentByDesignation + "," + Head.Data.PaymentByName + "," + Head.Data.PaymentRecievedByDesignation + "," + Head.Data.PaymentRecievedByName);
                        file.Write("," + Head.Data.Description);
                        file.Flush();
                        if (j != 0)
                            file.WriteLine();
                        j++;
                        Head = Head.Next;
                    }
                }
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
                    string Id = SplittedRecord[0];
                    string paymentType = SplittedRecord[1];
                    string paymentMode = SplittedRecord[2];
                    DateTime currentDate = DateTime.Parse(SplittedRecord[3]);
                    double amount = Double.Parse(SplittedRecord[4]);
                    string ByDesignation = SplittedRecord[5];
                    string ByName = SplittedRecord[6];
                    string ReceivedByDesignation = SplittedRecord[7];
                    string ReceivedByName = SplittedRecord[8];
                    string description = SplittedRecord[9];
                    Ledger ledger = new Ledger(paymentType, paymentMode, currentDate, amount, ByDesignation, ByName, ReceivedByDesignation, ReceivedByName, description);
                    ledger.Id = Id;
                    LedgerDL.addintoList(ledger);
                }
                file.Close();
            }
        }

        public static bool deleteOnlyLedgerDetails(Ledger ledger)
        {
            ledgers.Remove(ledger);
            return true;
        }
    }
}
