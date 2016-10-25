using System;

namespace ADS.ADS.Nodes
{
    public class BinarySearchTreeNode<T> : AbstractNode<T> where T : IComparable<T>
    {

        public BinarySearchTreeNode(T data): base(data)
        {
        }
    }
}
