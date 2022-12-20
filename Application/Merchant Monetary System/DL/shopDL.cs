using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.BL;

namespace Merchant_Monetary_System.DL
{
    public class shopDL
    {
        private static List<Shop> shopList = new List<Shop>();
        public static List<Shop> ShopList { get => shopList; set => shopList = value; }

        public static void addDataIntoList(Shop S)
        {
            shopList.Add(S);
        }
        public static string generateUniqueID(int _characterLength = 8)
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
        public static bool deleteShop(List<Shop> shopList,Shop deleteShop)
        {
            foreach(Shop shop in shopList)
            {
                if(deleteShop == shop)
                {
                    shopList.Remove(shop);
                    return true;
                }
            }
            return false;
        }
        public static
    }
}
