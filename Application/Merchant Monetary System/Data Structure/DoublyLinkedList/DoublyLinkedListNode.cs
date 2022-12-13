using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{
    public class DoublyLinkedListNode<T>
    {
        public T Data { get; }
        public DoublyLinkedListNode(T data) => Data = data;
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
    }
}
