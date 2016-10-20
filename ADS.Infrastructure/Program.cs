using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.ADS.DataStructures;

namespace ADS.ADS
{
    public class Program
    {
        public static void Main()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(8);
            bst.Add(4);
            bst.Add(1);
            bst.Add(3);
        }
    }
}
