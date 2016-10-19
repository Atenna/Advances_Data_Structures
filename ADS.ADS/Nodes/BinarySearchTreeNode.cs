using System;

namespace ADS.ADS.Nodes
{
    public class BinarySearchTreeNode<T> where T : IComparable<T>
    {
        public T Data;
        public BinarySearchTreeNode<T> Left;
        public BinarySearchTreeNode<T> Right;

        public BinarySearchTreeNode(T data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        public BinarySearchTreeNode<T> BinarySearchTreeNodeLeft { get; private set; }
        public BinarySearchTreeNode<T> BinarySearchTreeNodeRight { get; private set; }
        public BinarySearchTreeNode<T> BinarySearchTreeNodeAncestor { get; private set; }
    }
}
