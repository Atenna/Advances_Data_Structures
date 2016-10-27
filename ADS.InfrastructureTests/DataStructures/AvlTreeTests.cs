using System;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.InfrastructureTests.DataStructures
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

            tree.RotateRight(z);

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

            tree.RotateLeft(z);

            Assert.IsNotNull(tree.Root.Left);
            Assert.IsNotNull(tree.Root.Left.Right);
            Assert.AreEqual(p.Data, tree.Root.Left.Right.Data);
        }

        [TestMethod()]
        public void RightRotationNoChildrenRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();
            avl.Add(30);
            avl.Add(20);
            avl.Add(10);

            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(30, avl.Root.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
        }

        [TestMethod()]
        public void LeftRotationNoChildrenRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();
            avl.Add(10);
            avl.Add(20);
            avl.Add(30);

            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(30, avl.Root.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
        }

        [TestMethod()]
        public void RightLeftRotationNoChildrenRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(10);
            avl.Add(30);
            avl.Add(20);

            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(30, avl.Root.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
        }

        [TestMethod()]
        public void LeftRightRotationNoChildrenRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(30);
            avl.Add(10);
            avl.Add(20);

            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(30, avl.Root.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
        }

        [TestMethod()]
        public void LeftRotationNoChildrenNoRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(20);
            avl.Add(10);
            avl.Add(30);
            avl.Add(40);
            avl.Add(50);

            Assert.AreEqual(10, avl.Root.Left.Data);
            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(40, avl.Root.Right.Data);
            Assert.AreEqual(30, avl.Root.Right.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Right.Data);
        }

        [TestMethod()]
        public void RightRotationNoChildrenNoRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(40);
            avl.Add(50);
            avl.Add(30);
            avl.Add(20);
            avl.Add(10);

            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(30, avl.Root.Left.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
        }

        [TestMethod()]
        public void LeftRotationRightNoChildrenNoRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(20);
            avl.Add(10);
            avl.Add(30);
            avl.Add(40);
            avl.Add(50);

            Assert.AreEqual(40, avl.Root.Right.Data);
            Assert.AreEqual(50, avl.Root.Right.Right.Data);
            Assert.AreEqual(30, avl.Root.Right.Left.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
            Assert.AreEqual(20, avl.Root.Data);
        }

        [TestMethod()]
        public void LeftRotationRightChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);
            avl.Add(50);
            avl.Add(60);

            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(30, avl.Root.Left.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
        }

        [TestMethod()]
        public void LeftRotationLeftChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);
            avl.Add(60);
            avl.Add(50);

            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(60, avl.Root.Right.Data);
            Assert.AreEqual(30, avl.Root.Left.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Left.Data);
        }

        [TestMethod()]
        public void RightRotationLeftChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(50);
            avl.Add(60);
            avl.Add(30);
            avl.Add(20);
            avl.Add(40);
            avl.Add(10);

            Assert.AreEqual(30, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(40, avl.Root.Right.Left.Data);
        }

        [TestMethod()]
        public void RightRotationRightChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(50);
            avl.Add(60);
            avl.Add(30);
            avl.Add(10);
            avl.Add(40);
            avl.Add(20);

            Assert.AreEqual(30, avl.Root.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
            Assert.AreEqual(20, avl.Root.Left.Right.Data);
            Assert.AreEqual(40, avl.Root.Right.Left.Data);
        }

        [TestMethod()]
        public void RightLeftRotationRightChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(20);
            avl.Add(10);
            avl.Add(50);
            avl.Add(30);
            avl.Add(60);
            avl.Add(40);

            Assert.AreEqual(30, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(40, avl.Root.Right.Left.Data);
        }

        [TestMethod()]
        public void LeftRightRotationLeftChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(50);
            avl.Add(60);
            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);

            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(30, avl.Root.Left.Right.Data);
        }

        [TestMethod()]
        public void RightLeftRotationLeftChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(20);
            avl.Add(10);
            avl.Add(50);
            avl.Add(40);
            avl.Add(60);
            avl.Add(30);

            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(30, avl.Root.Left.Right.Data);
        }

        [TestMethod()]
        public void LeftRightRotationRightChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>();

            avl.Add(50);
            avl.Add(60);
            avl.Add(20);
            avl.Add(10);
            avl.Add(30);
            avl.Add(40);

            Assert.AreEqual(30, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(40, avl.Root.Right.Left.Data);
        }

        [TestMethod()]
        public void SetAncestorTest()
        {
            AvlTreeNode<int> node = new AvlTreeNode<int>(5);
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