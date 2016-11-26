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

            ReadReadersFromFile("readers.txt");
            ReadLibrariesFromFile("libraries.txt");
            ReadBooksFromFile("books.txt");
            //ReadBorrowingsFromFile("");
        }
        public void ReadBooksFromFile(string filename)
        {
            // title, author, uid, isbn, ean, reader name, reader surname, ruid, from, to, archived, library
            StreamReader w = new StreamReader(filename);
            string line;
            while ((line = w.ReadLine())!=null)
            {
                var b = ParseBook(line);
                if (b!=null)
                {
                    BooksByName.Add(b);
                    BooksByIsbn.Add(b);
                    BooksByUniqueId.Add(b);
                    NumberOfBooks++;
                }
            }
            w.Close();
        }

        public void ReadReadersFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                var r = ParseReader(line);
                ReadersById.Add(r);
                ReadersByName.Add(r);
                NumberOfReaders++;
            }
            w.Close();
        }

        private void ReadBorrowingsFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                w.ReadLine();
            }
            w.Close();
        }

        public void ReadLibrariesFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                Libraries.Add(new Library(line.Trim()));
            }
            w.Close();
        }

        public Book ParseBook(string line)
        {
            // title, author, uid, isbn, ean, reader name, reader surname, ruid, from, to, archived, library
            var b = line.Split(',');
            string title = b[0].Trim();
            string author = b[1].Trim();
            int uid = Convert.ToInt32(b[2].Trim());
            string isbn = b[3].Trim();
            string ean = b[4].Trim();
            string name = b[5].Trim();
            string surname = b[5].Trim();
            string rid = b[6].Trim();
            string from = b[7].Trim();
            string to = b[8].Trim();
            bool archived = b[9].Trim().Equals("true") ? true : false;
            string library = b[12].Trim();
            var lib = Libraries.SearchNode(new Library(library), Libraries.Root);
            if (lib != null)
            {
                Book book = new Book(author, title, isbn, ean, "Poetry", lib.Data, uid);
                return book;
            }
            return null;
        }
        Reader ParseReader(string line)
        {
            string[] r = line.Split(',');
            string[] n = r[0].Split(' ');
            int id = int.Parse(r[1].Trim());
            string name = n[0].Trim();
            string surname = n[1].Trim();
            return new Reader(id, name, surname);
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
