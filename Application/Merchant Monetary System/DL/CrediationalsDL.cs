using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    internal class CrediationalsDL
    {
        private static List<Crediationals> crediationalsList = new List<Crediationals>();

        public static List<Crediationals> CrediationalsList { get => crediationalsList; set => crediationalsList = value; }

        public static void storeRecordIntoFile(Crediationals record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Username + "," + record.Password);
            file.Flush();
            file.Close();

        }
        //public static bool loadRecordFromFile(string path)
        //{
        //    clearList();
        //    if (File.Exists(path))
        //    {
        //        StreamReader fileVariable = new StreamReader(path);
        //        string record;
        //        while ((record = fileVariable.ReadLine()) != null)
        //        {
        //            string username= parseData(record, 1);
        //            string password=parseData(record,2) ;
        //            crediationalsList.Add(new Crediationals(username, password));
        //        }
        //        fileVariable.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public static void clearList()
        {
            crediationalsList.Clear();
        }
       
       
    }
}
