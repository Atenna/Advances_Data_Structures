using System;
using System.Collections;
using System.Collections.Generic;
using ADS.ADS.Data;
using ADS.ADS.Nodes;

namespace ADS.ADS.DataStructures
{
    public class BinarySearchTree<T>
    {
        public AbstractNode<T> Root;
        public IComparer<T> Comparer;

        public class IntegerComparator : IComparer<int>
        {

            public int Compare(int x, int y)
            {
                if (x > y)
                {
                    return 1;
                }
                if (x < y)
                {
                    return -1;
                }
                return 0;
            }
        }

        public BinarySearchTree(IComparer<T> comparer)
        {
            if (comparer != null)
            {
                Comparer = comparer;
            }
            else
            {
                Comparer = (IComparer<T>) new IntegerComparator();
                
            }
        }

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
                //if (data.CompareTo(current.Data) == 0)
                if (Comparer.Compare(data, current.Data) == 0)
                {
                    return false;
                }
                else if (Comparer.Compare(data, current.Data) == -1)
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
                if (current == null)
                {
                    // prvok sa nenasiel
                    flag = false;
                    return null;
                }
                // najdeny prvok
                //if (current.Data.CompareTo(data) == 0)
                if(Comparer.Compare(data, current.Data) == 0)
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
                else if (Comparer.Compare(data, current.Data) == -1)
                {
                    current = current.Left;
                }
                else if (Comparer.Compare(data, current.Data) == 1)
                {
                    current = current.Right;
                }
            }
            return ancestor;
        }

        private AbstractNode<T> SetPointersToNull(AbstractNode<T> current, T data)
        {
            // uzol je lavy syn
            //if (current.Ancestor?.Data.CompareTo(data) == 1)
            if(current.Ancestor != null && Comparer.Compare(current.Ancestor.Data, data) == 1)
            {
                current.Ancestor.Left = null;
            }
            // uzol je pravy syn
            else if (current.Ancestor != null && Comparer.Compare(current.Ancestor.Data, data) == - 1)
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
            if (Comparer.Compare(current.Data, data) == 0)
            {
                return true;
            }
            else if (Comparer.Compare(current.Data, data) == -1)
            {
                return current.Left != null && Search(data, current.Left);
            }
            else
            {
                return current.Right != null && Search(data, current.Right);
            }
        }

        // to-do: zaobalit do metody, ak vrati null, vypis level order pre dany uzol?
        public AbstractNode<T> SearchNode(T data, AbstractNode<T> root)
        {
            AbstractNode<T> current = root;
            while (true)
            {
                if (Comparer.Compare(data, current.Data) == 0)
                {
                    return current;
                }
                else if (Comparer.Compare(data, current.Data) == -1)
                {
                    if (current.Left == null)
                    {
                        // vratit zoznam potomkov 2 urovne nizsie
                        // nejakod at vediet, ze sa to nenaslo
                        return null;
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
                        
                        return null;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        public List<AbstractNode<T>> SearchSimilar(T data, AbstractNode<T> root)
        {
            AbstractNode<T> current = root;
            List<AbstractNode<T>> similar = new List<AbstractNode<T>>();

            while (true)
            {
                if (Comparer.Compare(data, current.Data) == -1)
                {
                    if (current.Left == null)
                    {
                        similar.Add(current);
                        similar.Add(current.Ancestor);
                        return similar;
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
                        similar.Add(current);
                        similar.Add(current.Ancestor);
                        return similar;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
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

            Console.Write("{0} ", node.Data.ToString());

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
