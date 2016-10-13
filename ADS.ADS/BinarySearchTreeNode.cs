using System;
using System.ComponentModel.Design.Serialization;
using ADS.ADS.Data;

namespace ADS.ADS
{
    public class BinarySearchTreeNode
    {
        public IData Data;
        public BinarySearchTreeNode Left;
        public BinarySearchTreeNode Right;

        public BinarySearchTreeNode(IData data)
        {
            this.Data = data;
        }

        public BinarySearchTreeNode BinarySearchTreeNodeLeft { get; private set; }
        public BinarySearchTreeNode BinarySearchTreeNodeRight { get; private set; }
        public BinarySearchTreeNode BinarySearchTreeNodeAncestor { get; private set; }
    }
}
