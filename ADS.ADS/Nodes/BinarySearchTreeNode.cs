namespace ADS.ADS.Nodes
{
    public class BinarySearchTreeNode<T>
    {
        public T Data;
        public BinarySearchTreeNode<T> Left;
        public BinarySearchTreeNode<T> Right;

        public BinarySearchTreeNode(T data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        public BinarySearchTreeNode<T> BinarySearchTreeNodeLeft { get; private set; }
        public BinarySearchTreeNode<T> BinarySearchTreeNodeRight { get; private set; }
        public BinarySearchTreeNode<T> BinarySearchTreeNodeAncestor { get; private set; }
    }
}
