using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System
{

    public class DoublyLinkedList <T>
    {
        public DoublyLinkedList(T data)
        {
            Head = new DoublyLinkedListNode<T>(data);
            Tail = Head;
            Count = 1;
        }
        public DoublyLinkedList()
        {
            Tail = Head;
            Count = 0;
        }
        public int Count { get; private set; }

        public DoublyLinkedListNode<T> Head { get; set; }

        public DoublyLinkedListNode<T> Tail { get; set; }

        public DoublyLinkedListNode<T> AddHead(T data)
        {
            var node = new DoublyLinkedListNode<T>(data);

            if (Head is null)
            {
                Head = node;
                Tail = node;
                Count = 1;
                return node;
            }

            Head.Previous = node;
            node.Next = Head;
            Head = node;
            Count++;
            return node;
        }
        public DoublyLinkedListNode<T> Add(T data)
        {
            if (Head == null)
            {
                return AddHead(data);
            }

            var node = new DoublyLinkedListNode<T>(data);
            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;
            Count++;
            return node;
        }

        public DoublyLinkedListNode<T> AddAfter(T data, DoublyLinkedListNode<T> existingNode)
        {
            if (existingNode == Tail)
            {
                return Add(data);
            }

            var node = new DoublyLinkedListNode<T>(data);
            node.Next = existingNode.Next;
            node.Previous = existingNode;
            existingNode.Next = node;

            if (node.Next != null)
            {
                node.Next.Previous = node;
            }

            Count++;
            return node;
        }
        
        public DoublyLinkedListNode<T> Find(T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data ==null && data == null || current.Data != null && current.Data.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public DoublyLinkedListNode<T> GetAt(int position)
        {
            if (position < 0 || position >= Count)
            {
                throw new ArgumentOutOfRangeException($"Max count is {Count}");
            }

            var current = Head;
            for (var i = 0; i < position; i++)
            {
                current = current.Next;
            }

            return current ?? throw new ArgumentOutOfRangeException($"{nameof(position)} must be an index in the list");
        }

        public void RemoveHead()
        {
            if (Head == null)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;
            if (Head == null)
            {
                Tail = null;
                Count = 0;
                return;
            }

            Head.Previous = null;
            Count--;
        }
        public void RemoveAll()
        {
            if (Tail == null)
            {
                throw new InvalidOperationException("Cannot prune empty list");
            }

            Tail = Tail.Previous;
            if (Tail == null)
            {
                Head = null;
                Count = 0;
                return;
            }

            Tail.Next = null;
            Count--;
        }

        public void RemoveNode(DoublyLinkedListNode<T> node)
        {
            if (node == Head)
            {
                RemoveHead();
                return;
            }

            if (node == Tail)
            {
                RemoveAll();
                return;
            }

            if (node.Previous == null || node.Next == null)
            {
                throw new ArgumentException(
                    $"{nameof(node)} cannot have Previous or Next null if it's an internal node");
            }

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            Count--;
        }
        public int listCount(T data)
        {
            var current = Head;
            var index = 0;
            while (current != null)
            {
                if (current.Data == null && data == null || current.Data != null && current.Data.Equals(data))
                {
                    return index;
                }

                index++;
                current = current.Next;
            }

            return -1;
        }
    }


}
