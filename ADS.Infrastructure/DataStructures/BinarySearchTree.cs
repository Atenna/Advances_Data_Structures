﻿using System;
using ADS.ADS.Data;
using ADS.ADS.Nodes;

namespace ADS.ADS.DataStructures
{
    public class BinarySearchTree<T> where T: IComparable<T>
    {
        public BinarySearchTreeNode<T> Root;

        public bool Add(T data)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode<T>(data);
                return true;
            }

            return InsertNode(data, Root);
        }

        private bool InsertNode(T data, BinarySearchTreeNode<T> current)
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
                        current.Left = new BinarySearchTreeNode<T>(data);
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
                        current.Right = new BinarySearchTreeNode<T>(data);
                        return true;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        public bool BstRemove(T data)
        {
            BinarySearchTreeNode<T> current = Root;
            while (true)
            {

                if (current.Data.CompareTo(data) == 0)
                {
                    // uzol nema potomkov
                    if (current.Left == null && current.Right == null)
                    {
                        if (current.Ancestor?.CompareTo(data) == 1)
                        {
                            current.Ancestor.Left = null;
                            return true;
                        }
                        else if (current.Ancestor?.CompareTo(data) == -1)
                        {
                            current.Ancestor.Right = null;
                            return true;
                        }
                        else if (current.Ancestor == null)
                        {
                            Root = null;
                            return true;
                        }
                        return false;
                    }
                    // uzol ma jedneho potomka
                    else if (current.Left != null || current.Right != null)
                    {
                        
                    }
                    // uzol ma dvoch potomkov
                    else if (current.Left != null && current.Right != null)
                    {

                    }
                    return true;
                }
                else if (current.Data.CompareTo(data) == -1)
                {
                    current = current.Right;
                }
                else if (current.Data.CompareTo(data) == 1)
                {
                    current = current.Left;
                }
            }
        }

        public bool Search(T data, BinarySearchTreeNode<T> current)
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
    }
}