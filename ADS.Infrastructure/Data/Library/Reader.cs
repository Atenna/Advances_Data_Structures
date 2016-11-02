using System;
using ADS.ADS.DataStructures;

namespace ADS.ADS.Data.Library
{
    public class Reader
    {
        public string Name;
        public String Surname;
        public int UniqueId;
        public AvlTree<Book> BooksBorrowedInPast;
        public AvlTree<Book> BooksCurrentlyBorrowed;
        public AvlTree<Book> LateBookReturns;

        public Reader()
        {
            
        }

    }
}
