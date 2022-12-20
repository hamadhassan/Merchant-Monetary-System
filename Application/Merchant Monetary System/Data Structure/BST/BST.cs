using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.Data_Structure.BST
{
    public class BST
    {
        private BSTNode head = null;
        private int count = 0;

        public BSTNode Head { get => head; set => head = value; }
        public int Count { get => count; set => count = value; }

        public bool isEmpty()
        {
            return this.Head == null;
        }

        public void Add(Shopkeeper x)
        {
            BSTNode newNode = new BSTNode();
            newNode.Data = x;
            newNode.Left = null;
            newNode.Right = null;
            if (isEmpty())
            {
                Head = newNode;
                newNode.Parent = null;
                count = 1;
            }
            else
            {
                BSTNode temp = Head;
                while (temp != null)
                {
                    if (x.Cnic < temp.Data.Cnic)
                    {
                        if (temp.Left == null)
                        {
                            temp.Left = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.Left;
                        }
                    }
                    else
                    {
                        if (temp.Right == null)
                        {
                            temp.Right = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.Right;
                        }
                    }
                    count++;
                }
            }
        }

        public BSTNode findNode(Shopkeeper x)
        {
            BSTNode temp = Head;
            while (temp != null)
            {
                if (x.Cnic == temp.Data.Cnic)
                {
                    return temp;
                }
                else if (x.Cnic < temp.Data.Cnic)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return null;
        }
        public BSTNode findNode(double x)
        {
            BSTNode temp = Head;
            while (temp != null)
            {
                if (x == temp.Data.Cnic)
                {
                    return temp;
                }
                else if (x < temp.Data.Cnic)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return null;
        }
        public void removeHead()
        {
            if (Head == null)
            {
                return;
            }
            else
            {
                if (Head.Left == null && Head.Right == null)
                {
                    Head = null;
                }
                else if (Head.Left == null || Head.Right == null)
                {
                    if (Head.Left == null)
                    {
                        Head = Head.Right;
                        Head.Parent.Parent = null;
                        Head.Parent.Left = null;
                        Head.Parent.Right = null;
                        Head.Parent.Data = null;
                        Head.Parent = null;
                    }
                    else
                    {
                        Head = Head.Left;
                        Head.Parent.Parent = null;
                        Head.Parent.Left = null;
                        Head.Parent.Right = null;
                        Head.Parent.Data = null;
                        Head.Parent = null;
                    }
                }
                else
                {
                    BSTNode temp = Head.Right;
                    while (temp.Left != null)
                    {
                        temp = temp.Left;
                    }
                    Head.Data = temp.Data;
                    if (temp.Parent.Left == temp)
                    {
                        temp.Parent.Left = temp.Right;
                    }
                    else
                    {
                        temp.Parent.Right = temp.Right;
                    }
                    if (temp.Right != null)
                    {
                        temp.Right.Parent = temp.Parent;
                    }
                    temp.Parent = null;
                    temp.Left = null;
                    temp.Right = null;
                }
            }
        }

        public bool remove(Shopkeeper x)
        {
            BSTNode temp = findNode(x.Cnic);
            if (temp == null)
            {
                return false;
            }
            else
            {
                if(temp.Parent == null)
                {
                    removeHead();
                }
                else if (temp.Left == null && temp.Right == null)
                {
                    if (temp.Parent.Left == temp)
                    {
                        temp.Parent.Left = null;
                    }
                    else
                    {
                        temp.Parent.Right = null;
                    }
                }
                else if (temp.Left == null || temp.Right == null)
                {
                    if (temp.Left == null)
                    {
                        if (temp.Parent.Left == temp)
                        {
                            temp.Parent.Left = temp.Right;
                        }
                        else
                        {
                            temp.Parent.Right = temp.Right;
                        }
                        temp.Right.Parent = temp.Parent;
                    }
                    else
                    {
                        if (temp.Parent.Left == temp)
                        {
                            temp.Parent.Left = temp.Left;
                        }
                        else
                        {
                            temp.Parent.Right = temp.Left;
                        }
                        temp.Left.Parent = temp.Parent;
                    }
                }
                else
                {
                    BSTNode successor = temp.Right;
                    while (successor.Left != null)
                    {
                        successor = successor.Left;
                    }
                    temp.Data = successor.Data;
                    if (successor.Parent.Left == successor)
                    {
                        successor.Parent.Left = successor.Right;
                    }
                    else
                    {
                        successor.Parent.Right = successor.Right;
                    }
                    if (successor.Right != null)
                    {
                        successor.Right.Parent = successor.Parent;
                    }
                }
                count--;
                return true;
            }
        }
    }
}
