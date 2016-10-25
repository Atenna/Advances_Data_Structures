using System;

namespace ADS.ADS.Nodes
{
    public class BinarySearchTreeNode<T> : AbstractNode<T> where T : IComparable<T>
    {
        public new BinarySearchTreeNode<T> Left { get; set; }
        public new BinarySearchTreeNode<T> Right { get; set; }
        public new BinarySearchTreeNode<T> Ancestor { get; set; }

        public BinarySearchTreeNode(T data): base(data)
        {
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
