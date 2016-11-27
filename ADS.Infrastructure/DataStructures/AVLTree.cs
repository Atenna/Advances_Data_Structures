using System;
using System.Collections.Generic;
using ADS.ADS.Data.Library;
using ADS.ADS.Nodes;

namespace ADS.ADS.DataStructures
{
    public class AvlTree<T> : BinarySearchTree<T>
    {
        public new AvlTreeNode<T> Root;

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
            AdjustHeightToNode(Root);
            AdjustBalancefactorToNode(Root);
            return true;
        }

        public bool Add(AvlTreeNode<T> node)
        {
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                InsertNode(Root, node.Data, node);
            }
            AdjustHeightToNode(Root);
            AdjustBalancefactorToNode(Root);
            return true;
        }

        private bool InsertNode(AbstractNode<T> current, T data, AvlTreeNode<T> node)
        {
            AvlTreeNode<T> inserted = node;

            while (true)
            {
                //if (inserted.Data.CompareTo(current.Data) == 0)
                if(Comparer.Compare(data, current.Data) == 0)
                {
                    return false;
                }
                else if (Comparer.Compare(inserted.Data, current.Data) == -1)
                {
                    if (current.Left == null)
                    {
                        current.Left = inserted;
                        inserted.Ancestor = current;
                        // upravit vysky
                        AdjustHeights(inserted, false);
                        // upravit balance factor
                        //AdjustBalanceFactor(inserted);
                        Rebalance((AvlTreeNode<T>)inserted.Ancestor);
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
                        AdjustHeights(inserted, false);
                        // upravit balance factor
                        //AdjustBalanceFactor(inserted);
                        Rebalance((AvlTreeNode<T>)inserted.Ancestor);
                        return true;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }

        }

        private bool InsertNode(AbstractNode<T> current, T data)
        {
            AvlTreeNode<T> inserted = new AvlTreeNode<T>(data);

            while (true)
            {
                //if (inserted.Data.CompareTo(current.Data) == 0)
                if(Comparer.Compare(inserted.Data, current.Data) == 0)
                {
                    return false;
                }
                else if (Comparer.Compare(inserted.Data, current.Data) == -1)
                {
                    if (current.Left == null)
                    {
                        current.Left = inserted;
                        inserted.Ancestor = current;
                        // upravit vysky
                        AdjustHeights(inserted, false);
                        // upravit balance factor
                        //AdjustBalanceFactor(inserted);
                        Rebalance((AvlTreeNode<T>) inserted.Ancestor);
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
                        AdjustHeights(inserted, false);
                        // upravit balance factor
                        //AdjustBalanceFactor(inserted);
                        Rebalance((AvlTreeNode<T>) inserted.Ancestor);
                        return true;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            
        }

        private bool Rebalance(AvlTreeNode<T> nodeToRebalance)
        {
            AvlTreeNode<T> node = (AvlTreeNode<T>) nodeToRebalance;
            AvlTreeNode<T> right = (AvlTreeNode<T>) node.Right;
            AvlTreeNode<T> left = (AvlTreeNode<T>) node.Left;
            bool loop = true;

            while (loop)
            {
                // Left left case || Left right case
                if (node.BalanceFactor == 2)
                {
                    // left left case
                    if (left.BalanceFactor >= 0)
                    {
                        return RotateRight(node);
                    }
                    // left right case
                    if (left.BalanceFactor < 0)
                    {
                        return RotateLeftRight(node);
                    }
                }
                // Right right case || right left case
                if (node.BalanceFactor == -2)
                {
                    // Right right case
                    if (right.BalanceFactor <= 0)
                    {
                        return RotateLeft(node);
                    }
                    // Right left case 
                    if (right.BalanceFactor > 0)
                    {
                        return RotateRightLeft(node);
                    }
                }
                if (node.Ancestor == null)
                {
                    loop = false;
                }
                else
                {
                    node = (AvlTreeNode<T>)node.Ancestor;
                    right = (AvlTreeNode<T>)node.Right;
                    left = (AvlTreeNode<T>)node.Left;
                }
            }

            return true;
        }

        private void AdjustHeights(AbstractNode<T> node, bool deletion)
        {
            AvlTreeNode<T> current = (AvlTreeNode<T>) node;
            AvlTreeNode<T> leftNode = (AvlTreeNode<T>)current.Left;
            AvlTreeNode<T> rightNode = (AvlTreeNode<T>)current.Right;

            while (true)
            {
                int left = leftNode?.Height ?? 0;
                int right = rightNode?.Height ?? 0;
                current.Height = 1 + Math.Max(left, right);
                current.BalanceFactor = left - right;

                if (deletion  && (current.BalanceFactor > 1 || current.BalanceFactor < -1))
                {
                    Rebalance(current);
                }

                if (current.Ancestor == null)
                {
                    return;
                }

                current = (AvlTreeNode<T>) current.Ancestor;
                leftNode = (AvlTreeNode<T>)current.Left;
                rightNode = (AvlTreeNode<T>)current.Right;
            }
        }

        public AvlTreeNode<T> RemoveNode(T item)
        {
            if (Root == null)
            {
                return null;
            }
            AvlTreeNode<T> ancestor = (AvlTreeNode<T>) BstRemove(item, Root);
            // Checking for unbalance, if detected, balance (include also height update)
            // otherwise only Adjust height

            if (ancestor == null)
            {
                // zmazali sme koren
                Root = null;
                return null;
            }

            while (ancestor!= null)
            {
                AdjustBalancefactorToNode(ancestor);
                if ((ancestor.BalanceFactor == 2) || (ancestor.BalanceFactor == -2))
                {
                    Rebalance(ancestor);
                }
                else
                {
                    AdjustHeightToNode(ancestor);
                }
                if (ancestor.Ancestor == null)
                {
                    break;
                }
                ancestor = (AvlTreeNode<T>) ancestor.Ancestor;
            }
            return ancestor;
        }

        private void AdjustHeightToNode(AvlTreeNode<T> node)
        {
            AvlTreeNode<T> current = (AvlTreeNode<T>)node;
            AvlTreeNode<T> leftNode = (AvlTreeNode<T>)current.Left;
            AvlTreeNode<T> rightNode = (AvlTreeNode<T>)current.Right;

            int left = leftNode?.Height ?? 0;
            int right = rightNode?.Height ?? 0;
            current.Height = 1 + Math.Max(left, right);
        }

        private void AdjustBalancefactorToNode(AvlTreeNode<T> node)
        {
            AvlTreeNode<T> current = (AvlTreeNode<T>)node;
            AvlTreeNode<T> leftNode = (AvlTreeNode<T>)current.Left;
            AvlTreeNode<T> rightNode = (AvlTreeNode<T>)current.Right;

            int left = leftNode?.Height ?? 0;
            int right = rightNode?.Height ?? 0;
            current.BalanceFactor = left - right;
        }

        private int GetBalanceFactor(AvlTreeNode<T> node)
        {
            AvlTreeNode<T> current = (AvlTreeNode<T>)node;
            AvlTreeNode<T> leftNode = (AvlTreeNode<T>)current.Left;
            AvlTreeNode<T> rightNode = (AvlTreeNode<T>)current.Right;

            int left = leftNode?.Height ?? 0;
            int right = rightNode?.Height ?? 0;
            return left - right;
        }

        public bool RotateLeft(AbstractNode<T> node)
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
            AvlTreeNode<T> z = (AvlTreeNode<T>) node;
            AvlTreeNode<T> y = (AvlTreeNode<T>) node.Right;
            AbstractNode<T> p = y.Left;

            y.Ancestor = z.Ancestor;
            z.Ancestor = y;
            z.Right = p;
            if (p != null)
            {
                p.Ancestor = z;
            }
            y.Left = z;

            SetAncestor(y);

            AdjustHeightToNode(z);
            AdjustBalancefactorToNode(z);
            AdjustHeightToNode(y);
            AdjustBalancefactorToNode(y);

            return true;
        }

        public void SetAncestor(AbstractNode<T> y)
        {
            if (y.Ancestor == null)
            {
                Root = (AvlTreeNode<T>)y;
                return;
            }
            //else if (y.Ancestor.Data.CompareTo(y.Data) == 1)
            else if (Comparer.Compare(y.Ancestor.Data, y.Data) == 1)
            {
                y.Ancestor.Left = y;
            }
            else if (Comparer.Compare(y.Ancestor.Data, y.Data) == -1)
            {
                y.Ancestor.Right = y;
            }
        }

        private bool RotateLeftRight(AbstractNode<T> node)
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
            AvlTreeNode<T> z = (AvlTreeNode<T>) node;
            AvlTreeNode<T> y = (AvlTreeNode<T>) node.Left;

            RotateLeft(y);
            RotateRight(z);

            return true;
        }

        public bool RotateRight(AbstractNode<T> node)
        {
            AvlTreeNode<T> y = (AvlTreeNode<T>) node.Left;
            AvlTreeNode<T> z = (AvlTreeNode<T>) node;
            AbstractNode<T> p = y.Right;

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
            if (p != null)
            {
                p.Ancestor = z;
            }
            
            y.Right = z;
            z.Ancestor = y;

            SetAncestor(y);

            AdjustHeightToNode(z);
            AdjustBalancefactorToNode(z);
            AdjustHeightToNode(y);
            AdjustBalancefactorToNode(y);

            return true;
        }

        private bool RotateRightLeft(AbstractNode<T> node)
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

            AbstractNode<T> z = node;
            AbstractNode<T> y = node.Right;

            RotateRight(y);
            RotateLeft(z);

            return true;
        }

        public AvlTree(IComparer<T> comparer) : base(comparer)
        {
        }
    }
}
