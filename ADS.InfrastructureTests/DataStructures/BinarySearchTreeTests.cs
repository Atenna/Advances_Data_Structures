using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.InfrastructureTests.DataStructures
{
    [TestClass()]
    public class BinarySearchTreeTests
    {
        [TestMethod()]
        public void BstRemoveTwoChildrenTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(null);

            bst.Add(5);
            bst.Add(2);
            bst.Add(-4);
            bst.Add(3);
            bst.Add(12);
            bst.Add(21);
            bst.Add(9);
            bst.Add(19);
            bst.Add(25);

            bst.BstRemove(12, bst.Root);
            int data = bst.Root.Right.Data;

            Assert.AreEqual(data, 19);
        }
        [TestMethod()]
        public void BstRemoveOneChildTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(null);

            bst.Add(5);
            bst.Add(2);
            bst.Add(-4);
            bst.Add(3);
            bst.Add(12);
            bst.Add(19);
            bst.Add(9);
            bst.Add(21);

            bst.BstRemove(21, bst.Root);
            int data = bst.Root.Right.Right.Data;

            Assert.AreEqual(data, 19);
        }
        [TestMethod()]
        public void BstRemoveNoChildTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(null);

            bst.Add(5);
            bst.Add(2);
            bst.Add(-4);
            bst.Add(3);
            bst.Add(12);
            bst.Add(9);
            bst.Add(21);
            bst.Add(19);

            bst.BstRemove(19, bst.Root);

            Assert.IsNull(bst.Root.Right.Right.Left);
        }
        [TestMethod()]
        public void BstRemoveRootTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(null);

            bst.Add(5);
            bst.Add(2);
            bst.Add(-4);
            bst.Add(3);
            bst.Add(12);
            bst.Add(9);
            bst.Add(21);
            bst.Add(19);

            bst.BstRemove(5, bst.Root);

            Assert.AreEqual(bst.Root.Data, 9);
        }
        [TestMethod()]
        public void BstRemoveNonExistingNodeTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(null);

            bst.Add(5);
            bst.Add(2);

            var nothing = bst.BstRemove(7, bst.Root);

            Assert.IsNull(nothing);
        }
        [TestMethod()]
        public void BstRemoveRootFromOneNodeTreeTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(null);

            bst.Add(5);

            var nothing = bst.BstRemove(5, bst.Root);

            Assert.IsNull(nothing);
        }
        [TestMethod()]
        public void AddTest()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(null);
            bst.Add(5);
            bst.Add(8);
            bst.Add(4);
            bst.Add(1);
            bst.Add(3);

            AbstractNode<int> node = bst.Root;
            Assert.IsNotNull(node);

            Assert.AreEqual(node.Left.Data, 4);
            Assert.AreEqual(node.Right.Data, 8);

            Assert.AreEqual(node.Left.Left.Data, 1);
            Assert.AreEqual(node.Left.Left.Right.Data, 3);
        }
    }
}