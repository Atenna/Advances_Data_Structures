using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ADS.ADS.Data;
using ADS.ADS.Nodes;

namespace ADS.ADS.DataStructures
{
    public class AvlTree<T> where T: IComparable<T>
    {
        public AvlTreeNode<T> Root;

        public AvlTree()
        {
            
        }

        public int Height()
        {
            return Root?.Height ?? 0;
        }

        public int BalanceFactor(AvlTreeNode<T> node)
        {
            return node.BalanceFactor;
        }

        public bool Add(T data)
        {
            if (Root == null)
            {
                Root = new AvlTreeNode<T>(data) {Ancestor = null};
            }
            else
            {
                InsertNode(Root, data);
            }
            return true;
        }

        private bool InsertNode(AvlTreeNode<T> current, T data)
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
                        AvlTreeNode<T> inserted = new AvlTreeNode<T>(data);
                        current.Left = inserted;
                        inserted.Ancestor = current;
                        // upravit vysky
                        AdjustHeights(inserted);
                        // upravit balance factor
                        AdjustBalanceFactor(inserted);
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
                        AvlTreeNode<T> inserted = new AvlTreeNode<T>(data);
                        current.Right = inserted;
                        inserted.Ancestor = current;
                        // upravit vysky
                        AdjustHeights(inserted);
                        // upravit balance factor
                        AdjustBalanceFactor(inserted);
                        return true;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        private bool AdjustBalanceFactor(AvlTreeNode<T> node)
        {
            AvlTreeNode<T> current = node;
            while (true)
            {
                if (node.Ancestor == null)
                {
                    return true;
                }

                var left = current.Left?.Height ?? 0;
                var right = current.Right?.Height ?? 0;
                current.BalanceFactor = Math.Max(left, right);

                if (current.BalanceFactor == 0)
                {
                    return true;
                }
                if (current.BalanceFactor == 2 || current.BalanceFactor == -2)
                {
                    return Rebalance(current);
                }

                current = current.Ancestor;
            }
        }

        private bool Rebalance(AvlTreeNode<T> node)
        {
            if (node.BalanceFactor == 2)
            {
                if (node.Right.BalanceFactor == 1)
                {
                    return RotateLeft(node);
                }
                if (node.Right.BalanceFactor == -1)
                {
                    return RotateRightLeft(node);
                }
            }

            if (node.BalanceFactor == -2)
            {
                if (node.Left.BalanceFactor == -1)
                {
                    return RotateRight(node);
                }
                if (node.Left.BalanceFactor == 1)
                {
                    return RotateLeftRight(node);
                }
            }

            return true;
        }

        // TO-DO
        private void AdjustHeights(AvlTreeNode<T> node)
        {
            AvlTreeNode<T> current = node;
            while (true)
            {
                // root
                if (current.Ancestor == null)
                {
                    return;
                }
                current.Height = Math.Max(current.Left.Height, current.Right.Height);
                current = current.Ancestor;
            }
        }

        public bool Remove(T data)
        {
            return true;
        }

        private bool RotateLeft(AvlTreeNode<T> node)
        {
            return true;
        }

        private bool RotateLeftRight(AvlTreeNode<T> node)
        {
            return true;
        }

        private bool RotateRight(AvlTreeNode<T> node)
        {
            AvlTreeNode<T> y = node.Left;
            AvlTreeNode<T> x = y.Left;
            AvlTreeNode<T> z = node;
            AvlTreeNode<T> p = y.Right;

            /*
                         z                                      y 
                        / \                                   /   \
                       y   T4      Right Rotate (z)          x      z
                      / \          - - - - - - - - ->      /  \    /  \ 
                     x   p                                T1  T2  p   T4
                    / \
                  T1   T2
             */

            y.Ancestor = z.Ancestor; // aj spatne nastavit ycku ci je lavy alebo pravy potomok
            
            z.Left = p;
            y.Right = z;
            z.Ancestor = y;

            if (y.Ancestor?.Data.CompareTo(z.Data) == 1)
            {
                y.Ancestor.Right = y;
            }
            else if (y.Ancestor?.Data.CompareTo(z.Data) == -1)
            {
                y.Ancestor.Left = y;
            }

            return true;
        }

        private bool RotateRightLeft(AvlTreeNode<T> node)
        {
            return true;
        }
    }
}
