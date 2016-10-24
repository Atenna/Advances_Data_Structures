using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ADS.ADS.Data;
using ADS.ADS.Nodes;

namespace ADS.ADS.DataStructures
{
    public class AvlTree<T> : BinarySearchTree<T> where T: IComparable<T>
    {
        public new AvlTreeNode<T> Root; // new lebo v bst je Root typu BSTnode.. TODO

        public AvlTree(): base()
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

        public new bool Add(T data)
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
            AvlTreeNode<T> inserted = new AvlTreeNode<T>(data);

            while (true)
            {
                if (inserted.Data.CompareTo(current.Data) == 0)
                {
                    return false;
                }
                else if (inserted.Data.CompareTo(current.Data) == -1)
                {
                    if (current.Left == null)
                    {
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
                if (current.Ancestor == null)
                {
                    return true;
                }

                var left = current.Left?.Height ?? 0;
                var right = current.Right?.Height ?? 0;
                current.BalanceFactor = left - right;

                if (current.BalanceFactor == 0)
                {
                    //return true;
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
                int left = current.Left?.Height ?? 0;
                int right = current.Right?.Height ?? 0;
                current.Height = 1 + Math.Max(left, right);

                if (current.Ancestor == null)
                {
                    return;
                }

                current = current.Ancestor;
            }
        }

        public bool Remove(T data)
        {
            // normal BST deletion
            BstRemove(data);
            // 
            return true;
        }

        public bool RotateLeft(AvlTreeNode<T> node)
        {
            /*
                  z                                y
                 /  \                            /   \ 
                T1   y     Left Rotate(z)       z      x
                    /  \   - - - - - - - ->    / \    / \
                   p    x                     T1  p  T3  T4
                       / \
                     T3   T4
             */
            AvlTreeNode<T> z = node;
            AvlTreeNode<T> y = node.Right;
            AvlTreeNode<T> x = y.Right;
            AvlTreeNode<T> p = y.Left;

            y.Ancestor = z.Ancestor;
            z.Ancestor = y;
            z.Right = p;
            p.Ancestor = z;
            y.Left = z;

            SetAncestor(y);

            return true;
        }

        public void SetAncestor(AvlTreeNode<T> y)
        {
            if (y.Ancestor?.Data.CompareTo(y.Data) == 1)
            {
                y.Ancestor.Left = y;
            }
            else if (y.Ancestor?.Data.CompareTo(y.Data) == -1)
            {
                y.Ancestor.Right = y;
            }
            else if(y.Ancestor == null)
            {
                this.Root = y;
            }
        }

        private bool RotateLeftRight(AvlTreeNode<T> node)
        {
            /*
                     z                               z                           x
                    / \                            /   \                        /  \ 
                   y   T4  Left Rotate (y)        x    T4  Right Rotate(z)    y      z
                  / \      - - - - - - - - ->    /  \      - - - - - - - ->  / \    / \
                T1   x                          y    T3                    T1  T2 T3  T4
                    / \                        / \
                  T2   T3                    T1   T2
             */
            AvlTreeNode<T> z = node;
            AvlTreeNode<T> y = node.Left;

            RotateLeft(y);
            RotateRight(z);

            return true;
        }

        public bool RotateRight(AvlTreeNode<T> node)
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
            p.Ancestor = z;
            y.Right = z;
            z.Ancestor = y;

            SetAncestor(y);

            return true;
        }

        private bool RotateRightLeft(AvlTreeNode<T> node)
        {
            /*
                       z                            z                            x
                      / \                          / \                          /  \ 
                    T1   y   Right Rotate (y)    T1   x      Left Rotate(z)   z      y
                        / \  - - - - - - - - ->     /  \   - - - - - - - ->  / \    / \
                       x   T4                      T2   y                  T1  T2  T3  T4
                      / \                              /  \
                    T2   T3                           T3   T4
             */

            AvlTreeNode<T> z = node;
            AvlTreeNode<T> y = node.Right;

            RotateRight(y);
            RotateLeft(z);

            return true;
        }
    }
}
