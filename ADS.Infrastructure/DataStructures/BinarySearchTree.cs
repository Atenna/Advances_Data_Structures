using System;
using ADS.ADS.Nodes;

namespace ADS.ADS.DataStructures
{
    public class BinarySearchTree<T> where T: IComparable<T>
    {
        public AbstractNode<T> Root;

        public bool Add(T data)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode<T>(data);
                return true;
            }

            return InsertNode(data, Root);
        }

        private bool InsertNode(T data, AbstractNode<T> current)
        {
            while (true)
            {
                if (data.CompareTo(current.Data) == 0)
                {
                    return false;
                }
                else if (data.CompareTo(current.Data) == -1)
                {
                    if (current.Left == null)
                    {
                        var nodeToAdd = new AbstractNode<T>(data);
                        current.Left = nodeToAdd;
                        nodeToAdd.Ancestor = current;
                        return true;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        var nodeToAdd = new AbstractNode<T>(data);
                        current.Right = nodeToAdd;
                        nodeToAdd.Ancestor = current;

                        return true;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        public AbstractNode<T> BstRemove(T data, AbstractNode<T> root)
        {
            AbstractNode<T> current = root;
            AbstractNode<T> ancestor = root;
            bool flag = true;
            while (flag)
            {
                // najdeny prvok
                if (current.Data.CompareTo(data) == 0)
                {
                    // uzol nema potomkov
                    if (current.Left == null && current.Right == null)
                    {
                        ancestor = SetPointersToNull(current, data);
                        flag = false;
                        break;
                    }
                    // uzol ma dvoch potomkov
                    else if (current.Left != null && current.Right != null)
                    {
                        current.Data = MinValue(current.Right);
                        BstRemove(current.Data, current.Right);
                        flag = false;
                    }
                    // uzol ma jedneho potomka
                    else
                    {
                        var childData = current.Left != null ? current.Left.Data : current.Right.Data;
                        current.Data = childData;
                        ancestor = SetPointersToNull(current, data);
                        flag = false;
                        break;
                    }
                }
                else if (data.CompareTo(current.Data) == -1)
                {
                    current = current.Left;
                }
                else if (data.CompareTo(current.Data) == 1)
                {
                    current = current.Right;
                }
            }
            return ancestor;
        }

        private AbstractNode<T> SetPointersToNull(AbstractNode<T> current, T data)
        {
            // uzol je lavy syn
            if (current.Ancestor?.Data.CompareTo(data) == 1)
            {
                current.Ancestor.Left = null;
            }
            // uzol je pravy syn
            else if (current.Ancestor?.CompareTo(data) == -1)
            {
                current.Ancestor.Right = null;
            }
            // nema predchodcov
            else if (current.Ancestor == null)
            {
                Root = null;
            }
            return current.Ancestor;
        }

        public bool Search(T data, AbstractNode<T> current)
        {
            if (current.Data.CompareTo(data) == 0)
            {
                return true;
            }
            else if (current.Data.CompareTo(data) == -1)
            {
                return current.Left != null && Search(data, current.Left);
            }
            else
            {
                return current.Right != null && Search(data, current.Right);
            }
        }

        public T MinValue(AbstractNode<T> node)
        {
            var value = node.Data;
            while (true)
            {
                if (node.Left == null)
                {
                    return value;
                }
                else
                {
                    node = node.Left;
                    value = node.Data;
                }
            }
        }

        public void PreorderTraversal(AbstractNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write("{0} ", node.Data);

            PreorderTraversal(node.Left);

            PreorderTraversal(node.Right);
        }

        public void InorderTraversal(AbstractNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversal(node.Left);

            Console.Write("{0} ", node.Data);

            InorderTraversal(node.Right);
        }

        public void PostorderTraversal(AbstractNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            PostorderTraversal(node.Left);

            PostorderTraversal(node.Right);

            Console.Write("{0} ", node.Data);
        }
    }
}
