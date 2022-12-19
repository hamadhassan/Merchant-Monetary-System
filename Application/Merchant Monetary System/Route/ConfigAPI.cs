using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class ConfigAPI
    {
        private static string apiKey = "AIzaSyCFE8e8PiPP_3u2-mT-WtZUb6WlPAdShKc";

        public static string ApiKey { get => apiKey; set => apiKey = value; }
    }
}
