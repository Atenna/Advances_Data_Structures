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
        public void RemoveWithoutRebalanceTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(40);
            avl.Add(50);
            avl.Add(30);

            avl.RemoveNode(50);
            avl.RemoveNode(30);
            Assert.AreEqual(40, avl.Root.Data);
            Assert.IsNull(avl.Root.Left);
            Assert.IsNull(avl.Root.Right);
        }
        [TestMethod()]
        public void RemoveWithLeftRotationOneChildTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(50);

            avl.RemoveNode(10);

            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(2, avl.Root.Height);
            Assert.AreEqual(0, avl.Root.BalanceFactor);
        }
        [TestMethod()]
        public void RemoveWithLeftRotationTwoChildrenTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);
            avl.Add(50);

            avl.RemoveNode(10);

            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(30, avl.Root.Left.Right.Data);
            Assert.AreEqual(3, avl.Root.Height);
            Assert.AreEqual(1, avl.Root.BalanceFactor);
        }
        [TestMethod()]
        public void RemoveWithRotationWhileInsertTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);
            avl.Add(50);
            Console.WriteLine("Root: {0}", avl.Root.Data);
            avl.RemoveNode(10);
            Console.WriteLine("Root: {0}", avl.Root.Data);
            //avl.InorderTraversal(avl.Root);
            Assert.AreEqual(40, avl.Root.Data);
            //Assert.AreEqual(50, avl.Root.Right.Data);
            //Assert.AreEqual(20, avl.Root.Left.Data);
            //Assert.AreEqual(30, avl.Root.Left.Right.Data);
        }
        [TestMethod()]
        public void RemoveWithRightRotationOneChildTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(40);
            avl.Add(20);
            avl.Add(50);
            avl.Add(10);

            avl.RemoveNode(50);

            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(40, avl.Root.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
            Assert.AreEqual(2, avl.Root.Height);
            Assert.AreEqual(0, avl.Root.BalanceFactor);
        }
        [TestMethod()]
        public void RemoveWithRightRotationTwoChildrenTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(40);
            avl.Add(20);
            avl.Add(50);
            avl.Add(30);
            avl.Add(10);

            avl.RemoveNode(50);

            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(40, avl.Root.Right.Data);
            Assert.AreEqual(10, avl.Root.Left.Data);
            Assert.AreEqual(30, avl.Root.Right.Left.Data);
            Assert.AreEqual(3, avl.Root.Height);
            Assert.AreEqual(-1, avl.Root.BalanceFactor);
        }
        [TestMethod()]
        public void RemoveWithRightLeftRotationTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);

            avl.RemoveNode(10);

            Assert.AreEqual(30, avl.Root.Data);
            Assert.AreEqual(40, avl.Root.Right.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(2, avl.Root.Height);
            Assert.AreEqual(0, avl.Root.BalanceFactor);
        }
        [TestMethod()]
        public void RemoveWithLeftRightRotationTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(40);
            avl.Add(20);
            avl.Add(50);
            avl.Add(30);

            avl.RemoveNode(50);

            Assert.AreEqual(30, avl.Root.Data);
            Assert.AreEqual(40, avl.Root.Right.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(2, avl.Root.Height);
            Assert.AreEqual(0, avl.Root.BalanceFactor);
        }
        [TestMethod()]
        public void RemoveWithLeftRotationTwoChildrenNoRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(6);
            avl.Add(2);
            avl.Add(9);
            avl.Add(1);
            avl.Add(4);
            avl.Add(8);
            avl.Add(11); //B
            avl.Add(3);
            avl.Add(5);
            avl.Add(7);
            avl.Add(10); //A
            avl.Add(12); //C
            avl.Add(13); //D
            avl.RemoveNode(1);

            Assert.AreEqual(6, avl.Root.Data);
            Assert.AreEqual(4, avl.Root.Left.Data);
            Assert.AreEqual(9, avl.Root.Right.Data);
            Assert.AreEqual(13, avl.Root.Right.Right.Right.Right.Data);
            Assert.AreEqual(-1, avl.Root.BalanceFactor);
            Assert.AreEqual(5, avl.Root.Height);
        }
        [TestMethod()]
        public void RemoveWithDoubleRotationChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(5);
            avl.Add(2);
            avl.Add(8);
            avl.Add(1);
            avl.Add(3);
            avl.Add(7);
            avl.Add(10);
            avl.Add(4);
            avl.Add(6);
            avl.Add(9);
            avl.Add(11);
            avl.Add(12);

            avl.RemoveNode(1);

            Assert.AreEqual(8, avl.Root.Data);
        }
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

            AvlTree<int> tree = new AvlTree<int>(null);
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

            AvlTree<int> tree = new AvlTree<int>(null);

            tree.RotateLeft(z);

            Assert.IsNotNull(tree.Root.Left);
            Assert.IsNotNull(tree.Root.Left.Right);
            Assert.AreEqual(p.Data, tree.Root.Left.Right.Data);
        }

        [TestMethod()]
        public void RightRotationNoChildrenRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);
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
            AvlTree<int> avl = new AvlTree<int>(null);
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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(20);
            avl.Add(10);
            avl.Add(30);
            avl.Add(40);
            avl.Add(50);
            // netusim ako toto mohlo zbehnut, treba dorobit po rebalance opat nastavenie vysok a balance faktoru...
            Assert.AreEqual(10, avl.Root.Left.Data);
            Assert.AreEqual(20, avl.Root.Data);
            Assert.AreEqual(40, avl.Root.Right.Data);
            Assert.AreEqual(30, avl.Root.Right.Left.Data);
            Assert.AreEqual(50, avl.Root.Right.Right.Data);
        }

        [TestMethod()]
        public void RightRotationNoChildrenNoRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

            avl.Add(20);
            avl.Add(10);
            avl.Add(40);
            avl.Add(30);
            avl.Add(50);
            avl.Add(60);

            Assert.AreEqual(40, avl.Root.Data);
            Assert.AreEqual(20, avl.Root.Left.Data);
            Assert.AreEqual(10, avl.Root.Left.Left.Data);
            Assert.AreEqual(60, avl.Root.Right.Right.Data);
            Assert.AreEqual(50, avl.Root.Right.Data);
            Assert.AreEqual(30, avl.Root.Left.Right.Data);
        }

        [TestMethod()]
        public void LeftRotationLeftChildRootChangeTest()
        {
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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
            AvlTree<int> avl = new AvlTree<int>(null);

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

            AvlTree<int> tree = new AvlTree<int>(null);
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