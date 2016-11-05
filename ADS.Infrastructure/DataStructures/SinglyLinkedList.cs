using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.ADS.DataStructures
{
    public class SinglyLinkedList<T> where T: IComparable<T>
    {
        public class ListNode<T> where T: IComparable<T>
        {
            public T Data { get; private set; }
            public ListNode<T> Next { get; set; }

            public ListNode(T data)
            {
                Data = data;
            }

            public bool HasNext()
            {
                return Next != null;
            }
        }

        public ListNode<T> First { get; private set; }

        public void Add(T data)
        {
            if (First == null)
            {
                First = new ListNode<T>(data);
                return;
            }

            ListNode<T> current = First;
            while (current.HasNext())
            {
                current = current.Next;
            }

            current.Next = new ListNode<T>(data);
        }

        public void Remove(T data)
        {
            ListNode<T> previous = First;

            if (First.Data.CompareTo(data)==0)
            {
                First = First.Next;
                return;
            }

            while (previous.HasNext())
            {
                var current = previous.Next;
                if (current.Data.Equals(data))
                {
                    previous.Next = current.Next;
                    return;
                }
            }
        }
    }
}
