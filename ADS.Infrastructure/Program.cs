using System;
using ADS.ADS.DataStructures;

namespace ADS.ADS
{
    public class Program
    {
        public static void Main()
        {
            AvlTree<int> avl = new AvlTree<int>();
            avl.Add(20);
            avl.Add(10);
            avl.Add(30);
            avl.Add(40);
            avl.Add(50);


            Console.WriteLine("Asi sa nic nepokazilo");
            Console.ReadKey();
        }
    }
}
