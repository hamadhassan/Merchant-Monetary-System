using Merchant_Monetary_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_Monetary_System.Data_Structure.BST
{
    public class BSTNode
    {
        private Shopkeeper data;
        private BSTNode parent;
        private BSTNode left;
        private BSTNode right;

        public Shopkeeper Data { get => data; set => data = value; }
        public BSTNode Parent { get => parent; set => parent = value; }
        public BSTNode Left { get => left; set => left = value; }
        public BSTNode Right { get => right; set => right = value; }
    }
}
