﻿using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public static class GMapExtension
    {
        public static void refreshMap(this GMapControl map)
        {
            map.Zoom--;
            map.Zoom++;
        }
    }
}
