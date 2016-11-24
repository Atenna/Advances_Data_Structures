using System;
using System.Collections;
using System.Collections.Generic;
using ADS.ADS.DataStructures;

namespace ADS.ADS.Data.Library
{
    public class Reader
    {
        public class ReaderIdComparator : IComparer<Reader>
        {
            public int Compare(Reader x, Reader y)
            {
                long xd = x.UniqueId;
                long yd = y.UniqueId;
                if (xd > yd)
                {
                    return 1;
                }
                else if (xd < yd)
                {
                    return -1;
                }
                return 0;
            }
        }
        public class ReaderNameComparator : IComparer<Reader>
        {
            public int Compare(Reader x, Reader y)
            {
                string xd = x.Surname+x.Name;
                string yd = y.Surname + y.Name;
                return string.Compare(xd, yd);
            }
        }

        public string Name;
        public String Surname;
        public int UniqueId;
        public bool IsActive;
        public AvlTree<Borrowing> BooksBorrowedInPast;
        public AvlTree<Book> BooksCurrentlyBorrowed;
        public AvlTree<Book> LateBookReturns;
        public bool HasBlockedBorrowing { get; set; }
        public Reader(int id, string name, string surname)
        {
            UniqueId = id;
            Name = name;
            Surname = surname;
            HasBlockedBorrowing = false;
            BooksBorrowedInPast = new AvlTree<Borrowing>(new Borrowing.BorrowingComparator());
            BooksCurrentlyBorrowed = new AvlTree<Book>(new Book.BookNameComparator());
            LateBookReturns = new AvlTree<Book>(new Book.BookNameComparator());
            IsActive = true;
        }


        public override string ToString()
        {
            var archived = IsActive ? "" : ", (inactive)";
            return Name + " " + Surname + ", " + UniqueId + archived;
        }
    }
}
