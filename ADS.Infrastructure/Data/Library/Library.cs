using System;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;

namespace ADS.ADS.Data.Library
{
    public class Library
    {
        public string NameOfLibrary {get; private set; }
        public AvlTree<Book> AllBooks { get; set; }
        public AvlTree<Book> BorrowedBooks { get; set; }

        public Library(string name)
        {
            NameOfLibrary = name;
        }

    }
}
