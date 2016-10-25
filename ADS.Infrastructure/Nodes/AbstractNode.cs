using System;

namespace ADS.ADS.Nodes
{
    public class AbstractNode<T> where T : IComparable<T>
    {
        public T Data;
        public AbstractNode<T> Left { get; set; }
        public AbstractNode<T> Right { get; set; }
        public AbstractNode<T> Ancestor { get; set; }

        public AbstractNode(T data)
        {
            Data = data;
        }

        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }
    }
}
