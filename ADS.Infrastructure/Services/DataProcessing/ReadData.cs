using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;

namespace ADS.ADS.Services.DataProcessing
{
    public class ReadData
    {
        public AvlTree<Library> Libraries { get; set; }
        public AvlTree<Book> BooksByName { get; set; }
        public AvlTree<Book> BooksByIsbn { get; set; }
        public AvlTree<Book> BooksByUniqueId { get; set; }
        public AvlTree<Reader> ReadersById { get; set; }
        public AvlTree<Reader> ReadersByName { get; set; }
        public int NumberOfReaders { get; set; }
        public int NumberOfBooks { get; set; }

        public ReadData()
        {
            BooksByName = new AvlTree<Book>(new Book.BookNameComparator());
            Libraries = new AvlTree<Library>(new Library.LibraryNameComparator());
            BooksByIsbn = new AvlTree<Book>(new Book.BookIsbnComparator());
            BooksByUniqueId = new AvlTree<Book>(new Book.BookUniqueIdComparer());
            ReadersById = new AvlTree<Reader>(new Reader.ReaderIdComparator());
            ReadersByName = new AvlTree<Reader>(new Reader.ReaderNameComparator());

            ReadReadersFromFile("");
            ReadLibrariesFromFile("");
            ReadBooksFromFile("");
            ReadBorrowingsFromFile("");
        }
        public static void ReadBooksFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine())!=null)
            {
                w.ReadLine();
            }
        }

        public static void ReadReadersFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                w.ReadLine();
            }
        }

        private static void ReadBorrowingsFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                w.ReadLine();
            }
        }

        public static void ReadLibrariesFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                w.ReadLine();
            }
        }

        Book ParseBook(string line)
        {
            return new Book("", 0, "");
        }
        Reader ParseReader(string line)
        {
            return new Reader(0,"", "");
        }
        Library ParseLibrary(string line)
        {
            return new Library("");
        }
        Borrowing ParseBorrowing(string line)
        {
            return new Borrowing(new Book("",0,""), new Reader(0,"",""));
        }
    }
}
