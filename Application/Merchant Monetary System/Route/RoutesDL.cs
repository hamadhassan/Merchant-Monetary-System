using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public static class RoutesDL
    {
        public static void storeAllRecordIntoFile(string path, List<double> distances)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (double record in distances)
            {
                file.WriteLine(record + ",");
            }
            file.Flush();
            file.Close();
        }
    }
}
