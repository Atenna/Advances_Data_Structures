using System;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;

namespace ADS.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AvlTree<int> avl = new AvlTree<int>();
            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);
            avl.Add(50);

            AvlTree<int> avl2 = new AvlTree<int>();

            avl2.Add(40);
            avl2.Add(20);
            avl2.Add(50);
            avl2.Add(30);
            avl2.Add(10);

            avl2.RemoveNode(10);


            Console.WriteLine("Root: {0}", avl.Root.Data);
            avl.RemoveNode(10);
            Console.WriteLine("Root: {0}", avl.Root.Data);

            Console.ReadKey();
        }
    }
}
