using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_Monetary_System
{
    internal class CompanyDL
    {
        public static void storeRecordIntoFile(Compnay record, string path)
        {
            StreamWriter file = new StreamWriter(path,false);
            file.WriteLine(record.Name + "," + record.Address + "," + record.Phone + "," + record.Assets);
            file.Flush();
            file.Close();
        }
        public static bool loadRecordFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spilitedRecord = record.Split(',');
                    string name = spilitedRecord[0];
                    string address = spilitedRecord[1];
                    double phone = Convert.ToDouble(spilitedRecord[2]);
                    double revenue = Convert.ToInt64(spilitedRecord[3]);
                    Compnay compnay = Compnay.Instance(name, address, phone,revenue);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Compnay loadRecordFromFile2(string path)
        {
            Compnay c=new Compnay();
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] spilitedRecord = record.Split(',');
                    string name = spilitedRecord[0];
                    string address = spilitedRecord[1];
                    double phone = Convert.ToDouble(spilitedRecord[2]);
                    double revenue = Convert.ToInt64(spilitedRecord[3]);
                    Compnay compnay = Compnay.Instance(name, address, phone, revenue);
                }
                fileVariable.Close();
                c=new Compnay();
                return c;
            }
            else
            {
                return null;
            }
        }
    }
}
