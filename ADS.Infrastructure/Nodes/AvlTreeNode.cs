using System;

namespace ADS.ADS.Nodes
{
    public class AvlTreeNode<T>: AbstractNode<T> where T:IComparable<T>
    {
        public AvlTreeNode(T data) : base(data)
        {
            Data = data;
            BalanceFactor = 0;
            Height = 0;
            HeightOfLeftSubTree = 0;
            HeightOfRightSubtree = 0;
        }

        public int BalanceFactor { get; set; }
        public int Height { get; set; }
        public int HeightOfLeftSubTree { get; private set; }
        public int HeightOfRightSubtree { get; private set; }
    }
}
