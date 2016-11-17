using System;
using System.Collections.Generic;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;

namespace ADS.ADS.Data.Library
{
    public class Library
    {
        public class LibraryNameComparator : IComparer<Library>
        {
            public int Compare(Library x, Library y)
            {
                return string.Compare(x.NameOfLibrary, y.NameOfLibrary);
            }
        }

        public class LibraryIdComparator : IComparer<Library>
        {
            public int Compare(Library x, Library y)
            {
                return (x.LibraryId > y.LibraryId) ? 1 : (x.LibraryId < y.LibraryId ? -1 : 0);
            }
        }
        public string NameOfLibrary {get; private set; }
        public AvlTree<Book> AllBooksByName { get; set; }
        public AvlTree<Book> AllBooksByIsbn { get; set; }
        public AvlTree<Book> BorrowedBooks { get; set; }

        public int LibraryId { get; }

        public Library(string name)
        {
            NameOfLibrary = name;
            AllBooksByName = new AvlTree<Book>(new Book.BookNameComparator());
            AllBooksByIsbn = new AvlTree<Book>(new Book.BookIsbnComparator());
        }

        public override string ToString()
        {
            return NameOfLibrary;
        }
    }
}
