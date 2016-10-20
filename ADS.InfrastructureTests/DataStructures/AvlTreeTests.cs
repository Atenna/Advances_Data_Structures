using System;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.ADS.DataStructures.Tests
{
    [TestClass()]
    public class AvlTreeTests
    {
        [TestMethod()]
        public void RotateRightTest()
        {
            AvlTreeNode<int> z = new AvlTreeNode<int>(100);
            AvlTreeNode<int> y = new AvlTreeNode<int>(80);
            AvlTreeNode<int> x = new AvlTreeNode<int>(50);
            AvlTreeNode<int> p = new AvlTreeNode<int>(90);

            z.Left = y;
            y.Ancestor = z;
            y.Right = p;
            p.Ancestor = y;
            y.Left = x;
            x.Ancestor = y;

            AvlTree<int> tree = new AvlTree<int>();
            tree.Root = z;

            Console.WriteLine("===VYPIS CEZ ROOTA===");

            Console.WriteLine("Koren: " + tree.Root.Data.ToString());
            Console.WriteLine("Lavy syn: " + tree.Root.Left.Data.ToString());
            Console.WriteLine("Lavy Lavy syn: " + tree.Root.Left.Left.Data.ToString());
            Console.WriteLine("Lavy Pravy syn: " + tree.Root.Left.Right.Data.ToString());

            Console.WriteLine("===VYPIS CEZ SMERNIKY===");

            Console.WriteLine("Koren: " + z.Data.ToString());
            Console.WriteLine("Lavy syn: " + y.Data.ToString());
            Console.WriteLine("Lavy Lavy syn: " + x.Data.ToString());
            Console.WriteLine("Lavy Pravy syn: " + p.Data.ToString());

            tree.RotateRight(z);

            Console.WriteLine("===VYPIS PO ROTACII===");

            Console.WriteLine("Koren: " + tree.Root.Data.ToString());
            Console.WriteLine("Lavy syn: " + tree.Root.Left.Data.ToString());
            Console.WriteLine("Pravy syn: " + tree.Root.Right.Data.ToString());
            Console.WriteLine("Pravy Lavy syn: " + tree.Root.Right.Left.Data.ToString());

            Assert.IsNotNull(tree.Root.Right.Left);
            Assert.AreEqual(tree.Root.Right.Left.Data, p.Data);
        }

        [TestMethod()]
        public void RotateLeftTest()
        {
            AvlTreeNode<int> z = new AvlTreeNode<int>(50);
            AvlTreeNode<int> y = new AvlTreeNode<int>(90);
            AvlTreeNode<int> x = new AvlTreeNode<int>(100);
            AvlTreeNode<int> p = new AvlTreeNode<int>(80);

            z.Right = y;
            y.Ancestor = z;
            y.Right = x;
            x.Ancestor = y;
            y.Left = p;
            p.Ancestor = y;

            AvlTree<int> tree = new AvlTree<int> {Root = z};

            Console.WriteLine("===VYPIS CEZ ROOTA===");

            Console.WriteLine("Koren: " + tree.Root.Data.ToString());
            Console.WriteLine("Pravy syn: " + tree.Root.Right.Data.ToString());
            Console.WriteLine("Pravy Lavy syn: " + tree.Root.Right.Left.Data.ToString());
            Console.WriteLine("Pravy Pravy syn: " + tree.Root.Right.Right.Data.ToString());

            Console.WriteLine("===VYPIS CEZ SMERNIKY===");

            Console.WriteLine("Koren: " + z.Data.ToString());
            Console.WriteLine("Pravy syn: " + y.Data.ToString());
            Console.WriteLine("Pravy Lavy syn: " + p.Data.ToString());
            Console.WriteLine("Pravy Pravy syn: " + x.Data.ToString());

            tree.RotateLeft(z);

            Console.WriteLine("===VYPIS PO ROTACII===");

            Console.WriteLine("Koren: " + tree.Root.Data.ToString());
            Console.WriteLine("Lavy syn: " + tree.Root.Left.Data.ToString());
            Console.WriteLine("Pravy syn: " + tree.Root.Right.Data.ToString());
            Console.WriteLine("Lavy Pravy syn: " + tree.Root.Left.Right.Data.ToString());

            Assert.IsNotNull(tree.Root.Left);
            Assert.IsNotNull(tree.Root.Left.Right);
            Assert.AreEqual(p.Data, tree.Root.Left.Right.Data);
        }
    }
}

namespace ADS.InfrastructureTests.DataStructures
{
    [TestClass()]
    public class AvlTreeTests
    {
        [TestMethod()]
        public void SetAncestorTest()
        {
            AvlTreeNode<int> node =  new AvlTreeNode<int>(5);
            //Console.WriteLine(node.Data);
            AvlTreeNode<int> root = new AvlTreeNode<int>(8);
            node.Ancestor = root;

            AvlTree<int> tree = new AvlTree<int>();
            tree.Root = root;

            node.Ancestor = root;
            tree.SetAncestor(node);

            Console.WriteLine("Koren: " + root.Data.ToString());
            Console.WriteLine("Uzol: " + node.Data.ToString());
            Console.WriteLine("Pravy potomok korena: " + root.Right?.Data.ToString());
            Console.WriteLine("Lavy potomok korena: " + root.Left?.Data.ToString());

            Assert.IsNotNull(root.Left);
        }
    }
}