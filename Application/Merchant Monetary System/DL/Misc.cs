using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Merchant_Monetary_System.DL
{
    public static class Misc
    {
        private static List<string> cities = new List<string>();

        public static List<string> Cities { get => cities; set => cities = value; }

        public static void LoadCitiesOfPunjabFromFile(string path)
        {
            StreamReader file  = new StreamReader(path);
            string record;
            while((record = file.ReadLine())!= null)
            {
                addIntoList(record);
            }
            file.Close();
        }

        public static void addIntoList(string city)
        {
            cities.Add(city);
        }
    }
}
