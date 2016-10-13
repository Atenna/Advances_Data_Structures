using System;
using ADS.ADS.Data;

namespace ADS.ADS.DataStructures
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode Root;

        public bool Add(IData data)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode(data);
                return true;
            }

            return InsertNode(data, Root);
        }

        private bool InsertNode(IData data, BinarySearchTreeNode current)
        {

            if (data.Compare(current.Data) == 0)
            {
                return false;
            }
            else if (data.Compare(current.Data) == -1)
            {
                if (current.Left == null)
                {
                    current.Left = new BinarySearchTreeNode(data);
                    return true;
                }
                else
                {
                    return InsertNode(data, current.Left);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = new BinarySearchTreeNode(data);
                    return true;
                }
                else
                {
                    return InsertNode(data, current.Right);
                }
        }
    }

        public bool Remove(IData data)
        {
            if (Root.Data.Compare(data) == 0)
            {
                //
                return true;
            }
            else
            {
                return true;
            }
        }

        public bool Search(IData data, BinarySearchTreeNode current)
        {
            if (current.Data.Compare(data) == 0)
            {
                return true;
            }
            else if (current.Data.Compare(data) == -1)
            {
                return current.Left != null && Search(data, current.Left);
            }
            else
            {
                return current.Right != null && Search(data, current.Right);
            }
        }
    }
}
