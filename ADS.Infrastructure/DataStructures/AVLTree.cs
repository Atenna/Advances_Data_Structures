using System;
using ADS.ADS.Nodes;

namespace ADS.ADS.DataStructures
{
    public class AvlTree<T> : BinarySearchTree<T> where T: IComparable<T>
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
            return true;
        }

        private bool InsertNode(AbstractNode<T> current, T data)
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

        private bool AdjustBalanceFactor(AbstractNode<T> node)
        {
            AvlTreeNode<T> current = (AvlTreeNode<T>) node;
            while (true)
            {
                if (current.Ancestor == null)
                {
                    return true;
                }

                AvlTreeNode<T> leftNode = (AvlTreeNode<T>)current.Left;
                AvlTreeNode<T> rightNode = (AvlTreeNode<T>)current.Right;

                int left = leftNode?.Height ?? 0;
                int right = rightNode?.Height ?? 0;

                current.BalanceFactor = left - right;

                if (current.BalanceFactor == 0)
                {
                    //return true;
                }
                if (current.BalanceFactor == 2 || current.BalanceFactor == -2)
                {
                    return Rebalance(current);
                }

                current = (AvlTreeNode<T>) current.Ancestor;
            }
        }

        private bool Rebalance(AbstractNode<T> nodeToRebalance)
        {
            AvlTreeNode<T> node = (AvlTreeNode<T>) nodeToRebalance;
            AvlTreeNode<T> right = (AvlTreeNode<T>) node.Right;
            AvlTreeNode<T> left = (AvlTreeNode<T>) node.Left;

            if (node.BalanceFactor == 2)
            {
                if (right.BalanceFactor == 1)
                {
                    return RotateLeft(node);
                }
                if (right.BalanceFactor == -1)
                {
                    return RotateRightLeft(node);
                }
            }

            if (node.BalanceFactor == -2)
            {
                if (left.BalanceFactor == -1)
                {
                    return RotateRight(node);
                }
                if (left.BalanceFactor == 1)
                {
                    return RotateLeftRight(node);
                }
            }

            return true;
        }

        // TO-DO
        private void AdjustHeights(AbstractNode<T> node)
        {
            AvlTreeNode<T> current = (AvlTreeNode<T>) node;
            while (true)
            {
                AvlTreeNode<T> leftNode = (AvlTreeNode<T>) current.Left;
                AvlTreeNode<T> rightNode = (AvlTreeNode<T>)current.Right;

                int left = leftNode?.Height ?? 0;
                int right = rightNode?.Height ?? 0;
                current.Height = 1 + Math.Max(left, right);

                if (current.Ancestor == null)
                {
                    return;
                }

                current = (AvlTreeNode<T>) current.Ancestor;
            }
        }

        public bool Remove(T data)
        {
            // normal BST deletion
            BstRemove(data, Root);
            // 
            return true;
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
            AbstractNode<T> z = node;
            AbstractNode<T> y = node.Right;
            AbstractNode<T> p = y.Left;

            y.Ancestor = z.Ancestor;
            z.Ancestor = y;
            z.Right = p;
            p.Ancestor = z;
            y.Left = z;

            SetAncestor(y);

            return true;
        }

        public void SetAncestor(AbstractNode<T> y)
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
                Root = (AvlTreeNode<T>) y;
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
            AbstractNode<T> z = node;
            AbstractNode<T> y = node.Left;

            RotateLeft(y);
            RotateRight(z);

            return true;
        }

        public bool RotateRight(AbstractNode<T> node)
        {
            AbstractNode<T> y = node.Left;
            AbstractNode<T> z = node;
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
            p.Ancestor = z;
            y.Right = z;
            z.Ancestor = y;

            SetAncestor(y);

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
    }
}
