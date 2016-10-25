using System;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;

namespace ADS.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            bst.Add(5);
            bst.Add(2);
            bst.Add(-4);
            bst.Add(3);
            bst.Add(12);
            bst.Add(9);
            bst.Add(21);
            bst.Add(19);
            bst.Add(25);

            bst.BstRemove(12, bst.Root);
        }
    }
}
