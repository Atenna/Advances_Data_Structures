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
            ReadCurrentBorrowingsFromFile("current.txt");
            ReadPreviousBorrowingsFromFile("previous.txt");
            ReadlateBorrowingsFromFile("late.txt");
        }

        private void ReadlateBorrowingsFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                var b = ParseLateBorrowing(line);
            }
            w.Close();
        }

        private void ReadPreviousBorrowingsFromFile(string filename)
        {
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                var b = ParsePreviousBorrowing(line);
            }
            w.Close();
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

        private void ReadCurrentBorrowingsFromFile(string filename)
        {
            // Monks Pond: No. 1  1968,Thomas Merton,6185,978-41-64944-1615,978-41-64944-1625,Josephine,Lichtenberg,9483,27.11.2016,,,false,Aldersbach O6
            StreamReader w = new StreamReader(filename);
            string line = "";
            while ((line = w.ReadLine()) != null)
            {
                var b = ParseCurrentBorrowing(line);
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
            int id = 0;
            if (r.Length == 3)
            {
                id = int.Parse(r[2].Trim());
            }
            else
            {
                id = int.Parse(r[1].Trim());
            }
            string[] n = r[0].Split(' ');
            
            string name = n[0].Trim();
            string surname = n[1].Trim();
            return new Reader(id, name, surname);
        }
        Library ParseLibrary(string line)
        {
            return new Library("");
        }
        Borrowing ParseCurrentBorrowing(string line)
        {
            // The Creator,Dejan Stojanović,10708,978-41-64944-2775,978-41-64944-2785,Josephine,Lichtenberg,9483,27.11.2016,,,false,Altenpleen K2
            // Monks Pond: No. 1  1968,Thomas Merton,6185,978-41-64944-1615,978-41-64944-1625,Josephine,Lichtenberg,9483,27.11.2016,,,false,Aldersbach O6

            var data = line.Split(',');
            var title = data[0];
            var author = data[1];
            var uid = data[2];
            var isbn = data[3];
            var ean = data[4];
            var readername = data[5];
            var surname = data[6];
            var rid = data[7];
            var from = data[8].Split('.');
            var to = data[9].Split('.');
            var wtf = data[10];
            var archived = data[11];
            var lib = data[12];
            var l = Libraries.SearchNode(new Library(lib), Libraries.Root);
            var book = new Book(author, title, isbn, ean, "", l.Data, int.Parse(uid), 0, 0);
            
            var b = BooksByUniqueId.SearchNode(book, BooksByUniqueId.Root);
            b.Data.TimeOfBorrow = new DateTime(int.Parse(from[2]), int.Parse(from[1]), int.Parse(from[0]));
            b.Data.IsArchived = archived.Equals("true");
            var r = ReadersById.SearchNode(new Reader(int.Parse(rid), readername, surname), ReadersById.Root);
            b.Data.CurrentReader = r.Data;
            b.Data.IsBorrowed = true;
            Borrowing bor = new Borrowing(b.Data.Copy(), new Reader(int.Parse(rid), readername, surname));
            
            if (data[9] == "")
            {
                r.Data.BooksCurrentlyBorrowed.Add(b.Data);
            }

            return bor;
        }

        Borrowing ParseLateBorrowing(string line)
        {
            // The Creator,Dejan Stojanović,10708,978-41-64944-2775,978-41-64944-2785,Josephine,Lichtenberg,9483,27.11.2016,,,false,Altenpleen K2
            // Monks Pond: No. 1  1968,Thomas Merton,6185,978-41-64944-1615,978-41-64944-1625,Josephine,Lichtenberg,9483,27.11.2016,,,false,Aldersbach O6

            var data = line.Split(',');
            var title = data[0];
            var author = data[1];
            var uid = data[2];
            var isbn = data[3];
            var ean = data[4];
            var readername = data[5];
            var surname = data[6];
            var rid = data[7];
            var from = data[8].Split('.');
            var to = data[9].Split('.');
            var archived = data[10];
            var lib = data[11];
            var fee = int.Parse(data[12]);

            var l = Libraries.SearchNode(new Library(lib), Libraries.Root);
            var book = new Book(author, title, isbn, ean, "", l.Data, int.Parse(uid), 0, 0);

            var b = BooksByUniqueId.SearchNode(book, BooksByUniqueId.Root);
            b.Data.TimeOfBorrow = new DateTime(int.Parse(from[2]), int.Parse(from[1]), int.Parse(from[0]));
            b.Data.IsArchived = archived.Equals("true");

            var r = ReadersById.SearchNode(new Reader(int.Parse(rid), readername, surname), ReadersById.Root);
            Borrowing bor = new Borrowing(b.Data.Copy(), new Reader(int.Parse(rid), readername, surname));

            bor.DateOfBorrow = new DateTime(int.Parse(from[2]), int.Parse(from[1]), int.Parse(from[0]));
            bor.DateOfReturn = new DateTime(int.Parse(to[2]), int.Parse(to[1]), int.Parse(to[0]));
            bor.Fee = fee;
            bor.FeeToPay = true;
            r.Data.LateBookReturns.Add(bor);

            return bor;
        }

        Borrowing ParsePreviousBorrowing(string line)
        {

            // Cables to the Ace,Thomas Merton,1826,978-41-64944-475,978-41-64944-485,Josephine,Lichtenberg,
            // 9483,27.11.2016,27.11.2016,false,Aldersbach O6,0
            var data = line.Split(',');
            var title = data[0];
            var author = data[1];
            var uid = data[2];
            var isbn = data[3];
            var ean = data[4];
            var readername = data[5];
            var surname = data[6];
            var rid = data[7];
            var from = data[8].Split('.');
            var to = data[9].Split('.');
            var archived = data[10];
            var lib = data[11];
            var fee = int.Parse(data[12]);
            var l = Libraries.SearchNode(new Library(lib), Libraries.Root);

            var book = new Book(author, title, isbn, ean, "", l.Data, int.Parse(uid), 0, 0);
            var b = BooksByUniqueId.SearchNode(book, BooksByUniqueId.Root);
            b.Data.TimeOfBorrow = new DateTime(int.Parse(from[2]), int.Parse(from[1]), int.Parse(from[0]));
            b.Data.IsArchived = archived.Equals("true");

            var r = ReadersById.SearchNode(new Reader(int.Parse(rid), readername, surname), ReadersById.Root);
            Borrowing bor = new Borrowing(b.Data.Copy(), new Reader(int.Parse(rid), readername, surname));

            bor.DateOfBorrow = new DateTime(int.Parse(from[2]), int.Parse(from[1]), int.Parse(from[0]));
            bor.DateOfReturn = new DateTime(int.Parse(to[2]), int.Parse(to[1]), int.Parse(to[0]));
            bor.Fee= fee;
            bor.FeeToPay = true;
            r.Data.BooksBorrowedInPast.Add(bor);

            return bor;
        }
    }
}
