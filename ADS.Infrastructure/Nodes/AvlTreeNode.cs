﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

        public new AvlTreeNode<T> Ancestor { get; set; }
        public new AvlTreeNode<T> Left { get; set; }
        public new AvlTreeNode<T> Right { get; set; }
    }
}
