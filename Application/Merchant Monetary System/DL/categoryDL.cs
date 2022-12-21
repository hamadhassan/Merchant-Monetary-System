using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchant_Monetary_System;
using System.IO;
using System.Diagnostics.Contracts;
using Merchant_Monetary_System.BL;

namespace Merchant_Monetary_System.DL
{
    public sealed class categoryDL
    {
        private static readonly categoryDL instance = new categoryDL();
        private static List<string> categoryList = new List<string>();
        private static DoublyLinkedList<Category> categories = new DoublyLinkedList<Category>();
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

        public static List<string> CategoryList { get => categoryList; set => categoryList = value; }
        public static DoublyLinkedList<Category> Categories { get => categories; set => categories = value; }

        public static void addIntoCategoryList(Category category)
        {
            categories.Add(category);
        }

        public static void StoreDataIntoFiles(string path)
        {
            StreamWriter file = new StreamWriter(path);
            DoublyLinkedListNode<Category> Head = categories.Head;
            while(Head != null)
            {
                file.WriteLine(Head.Data.CategoryName);
                Head = Head.Next;
            }
            file.Close();
        }

        public static void loadDataFromFiles(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while((record = file.ReadLine()) != null)
            {
                Category category = new Category(record);
                Categories.Add(category);
            }
            file.Close();
        }

        public static bool deleteCategory(string category)
        {
            DoublyLinkedListNode<Category> Head = categories.Head;
            while(Head!=null)
            {
                if(Head.Data.CategoryName == category)
                {
                    categories.RemoveNode(Head);
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }
        public static Category returnCategory(string categoryName)
        {
            DoublyLinkedListNode<Category> Head = categories.Head;
            while (Head != null)
            {
                if (Head.Data.CategoryName == categoryName)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;


        }


    }
}
