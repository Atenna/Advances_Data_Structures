﻿using System;
using ADS.ADS.Data;
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

        public bool BstRemove(T data, AbstractNode<T> root)
        {
            var current = root;
            while (true)
            {
                // najdeny prvok
                if (current.Data.CompareTo(data) == 0)
                {
                    // uzol nema potomkov
                    if (current.Left == null && current.Right == null)
                    {
                        return SetPointersToNull(current, data);
                    }
                    // uzol ma dvoch potomkov
                    else if (current.Left != null && current.Right != null)
                    {
                        current.Data = MinValue(current.Right);
                        BstRemove(current.Data, current.Right);
                    }
                    // uzol ma jedneho potomka
                    else
                    {
                        var childData = current.Left != null ? current.Left.Data : current.Right.Data;
                        current.Data = childData;

                        return SetPointersToNull(current, data);
                    }
                    return true;
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
        }

        private bool SetPointersToNull(AbstractNode<T> current, T data)
        {
            // uzol je lavy syn
            if (current.Ancestor?.Data.CompareTo(data) == 1)
            {
                current.Ancestor.Left = null;
                return true;
            }
            // uzol je pravy syn
            else if (current.Ancestor?.CompareTo(data) == -1)
            {
                current.Ancestor.Right = null;
                return true;
            }
            // nema predchodcov
            else if (current.Ancestor == null)
            {
                Root = null;
                return true;
            }
            return false;
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
    }
}
