using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchant_Monetary_System;
using System.IO;

namespace Merchant_Monetary_System.DL
{
    public sealed class categoryDL
    {
        private static readonly categoryDL instance = new categoryDL();
        private static List<string> categoryList = new List<string>();
        static categoryDL()
        {
        }
        private categoryDL()
        {
        }
        public static categoryDL Instance
        {
            get
            {
                return instance;
            }
        }

        public List<string> CategoryList { get => categoryList; set => categoryList = value; }

        public static void addIntoCategoryList(string categoryName)
        {
            categoryList.Add(categoryName);
        }

        public static void StoreDataIntoFiles(string path)
        {
            StreamWriter file = new StreamWriter(path);
            int i = 0;
            foreach(string category in categoryList)
            {
                file.Write(category);
                if(i != categoryList.Count - 1) file.WriteLine();
            }
            file.Close();
        }
    }
}
