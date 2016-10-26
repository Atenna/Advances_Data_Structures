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

        }
        [TestMethod()]
        public void LeftRotationNoChildrenNoRootChangeTest()
        {

        }
        [TestMethod()]
        public void RightRotationNoChildrenNoRootChangeTest()
        {

        }
        [TestMethod()]
        public void LeftRotationRightChildRootChangeTest()
        {

        }
        [TestMethod()]
        public void LeftRotationLeftChildRootChangeTest()
        {

        }
        [TestMethod()]
        public void RightRotationLeftChildRootChangeTest()
        {

        }
        [TestMethod()]
        public void RightRotationRightChildRootChangeTest()
        {

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