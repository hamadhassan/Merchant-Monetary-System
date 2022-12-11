using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{

    public class Node <T>
    {
        private T users;
        private T next;
        private T pre;

        public Node(T users)
        {
            this.users = users;
            
        }
    }
   
}
