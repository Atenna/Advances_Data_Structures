using System;

namespace ADS.ADS.Nodes
{
    public class BinarySearchTreeNode<T> where T : IComparable<T>
    {
        public T Data;
        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }
        public BinarySearchTreeNode<T> Ancestor { get; set; }

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
    }
}
