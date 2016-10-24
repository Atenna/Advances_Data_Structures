using System;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.ADS.DataStructures.Tests
{
    [TestClass()]
    public class BinarySearchTreeTests
    {
        [TestMethod()]
        public void RemoveTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(8);
            bst.Add(4);
            bst.Add(1);
            bst.Add(3);

            BinarySearchTreeNode<int> node = bst.Root;
            Assert.IsNotNull(node);

            bst.BstRemove(5);
        }
    }
}

namespace ADS.InfrastructureTests.DataStructures
{
    [TestClass()]
    public class BinarySearchTreeTests
    {
        [TestMethod()]
        public void AddTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(8);
            bst.Add(4);
            bst.Add(1);
            bst.Add(3);

            BinarySearchTreeNode<int> node = bst.Root;
            Assert.IsNotNull(node);

            Assert.AreEqual(node.Left.Data, 4);
            Assert.AreEqual(node.Right.Data, 8);

            Assert.AreEqual(node.Left.Left.Data, 1);
            Assert.AreEqual(node.Left.Left.Right.Data, 3);
        }
    }
}