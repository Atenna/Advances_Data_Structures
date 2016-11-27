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
        public List<Borrowing> BooksBorrowedInPast;
        public List<Book> BooksCurrentlyBorrowed;
        public List<Borrowing> LateBookReturns;
        public bool HasBlockedBorrowing { get; set; }
        public Reader(int id, string name, string surname)
        {
            UniqueId = id;
            Name = name;
            Surname = surname;
            HasBlockedBorrowing = false;
            BooksBorrowedInPast = new List<Borrowing>();
            //BooksCurrentlyBorrowed = new AvlTree<Book>(new Book.BookNameComparator());
            BooksCurrentlyBorrowed = new List<Book>();
            LateBookReturns = new List<Borrowing>();
            IsActive = true;
        }


        public override string ToString()
        {
            var archived = IsActive ? "" : ", (inactive)";
            return Name + " " + Surname + ", " + UniqueId + archived;
        }
    }
}
