using System;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;

namespace ADS.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AvlTreeNode<int> z = new AvlTreeNode<int>(50);
            AvlTreeNode<int> y = new AvlTreeNode<int>(90);
            AvlTreeNode<int> x = new AvlTreeNode<int>(100);
            AvlTreeNode<int> p = new AvlTreeNode<int>(80);

            AvlTree<int> tree = new AvlTree<int> {Root = z};
            tree.Add(90);
            tree.Add(100);
            tree.Add(80);

            z = tree.Root;
        }
    }
}
