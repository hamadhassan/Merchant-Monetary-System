using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IronPython.Runtime.Profiler;

namespace Merchant_Monetary_System.Data_Structure.HashTable
{
    public class HashTable
    {
        private int keysOccupied;
        private int count;
        private int size;
        private DoublyLinkedList<Ledger>[] hashTable;

        public HashTable(int size)
        {
            this.keysOccupied = 0;
            this.size = size;
            hashTable = new DoublyLinkedList<Ledger>[size];
        }

        public int KeysOccupied { get => keysOccupied; set => keysOccupied = value; }
        public int Size { get => size; set => size = value; }
        public DoublyLinkedList<Ledger>[] HashTableData { get => hashTable; set => hashTable = value; }
        public int Count { get => count; set => count = value; }

        public int HashFunction(Ledger data)
        {
            int sum = 0;
            foreach (char s in data.Id)
            {
                int digit = Convert.ToInt32(s);
                sum = sum + digit;
            }
            return sum % size;
        }

        public int HashFunction(string data)
        {
            int sum = 0;
            foreach (char s in data)
            {
                int digit = Convert.ToInt32(s);
                sum = sum + digit;
            }
            return sum % size;
        }

        public Ledger SearchKey(Ledger data)
        {
            int key = HashFunction(data);
            DoublyLinkedList<Ledger> list = hashTable[key];
            DoublyLinkedListNode<Ledger> Head = list.Head;
            while (Head != null)
            {
                if (Head.Data.Id == data.Id)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;
        }

        public Ledger SearchKey(string ID)
        {
            int key = HashFunction(ID);
            DoublyLinkedList<Ledger> list = hashTable[key];
            DoublyLinkedListNode<Ledger> Head = list.Head;
            while (Head != null)
            {
                if (Head.Data.Id == ID)
                {
                    return Head.Data;
                }
                Head = Head.Next;
            }
            return null;
        }

        public DoublyLinkedListNode<Ledger> SearchKeyReturningNode(Ledger data)
        {
            int key = HashFunction(data);
            DoublyLinkedList<Ledger> list = hashTable[key];
            DoublyLinkedListNode<Ledger> Head = list.Head;
            while (Head != null)
            {
                if (Head.Data.Id == data.Id)
                {
                    return Head;
                }
                Head = Head.Next;
            }
            return null;
        }


        public void Add(Ledger ledger)
        {
            int hashValue = HashFunction(ledger);
            if(hashTable[hashValue] == null)
            {
                hashTable[hashValue] = new DoublyLinkedList<Ledger>();
                keysOccupied++;
            }
            hashTable[hashValue].Add(ledger);
            Count++;
            if (loadFactor()) reHashing();
        }
        public void Remove(Ledger ledger)
        {
            int hashValue = HashFunction(ledger);
            DoublyLinkedListNode<Ledger> ledgerNode = SearchKeyReturningNode(ledger);
            hashTable[hashValue].RemoveNode(ledgerNode);
            if (hashTable[hashValue].Head == null)
            {
                keysOccupied--;
            }
            Count--;
        }

        public void reHashing()
        {
            DoublyLinkedList<Ledger>[] previousTable = hashTable;
            int previousSize = size;
            size = size * 2;
            hashTable = new DoublyLinkedList<Ledger>[size];
            for (int i = 0; i < previousSize; i++)
            {
                DoublyLinkedListNode<Ledger> Head = hashTable[i].Head;
                while (Head != null)
                {
                    hashTable[i].Add(Head.Data);
                    Head = Head.Next;
                }
            }
        }

        public bool loadFactor()
        {
            float factor = (Count / size) * 100;
            if (factor > 0.75) return true;
            return false;
        }
    }
}
