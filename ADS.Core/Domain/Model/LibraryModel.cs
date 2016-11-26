using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.ADS.Services.DataProcessing;
using ADS.Core.Domain.Controller;
using ADS.ADS.Services.DataGenerating;

namespace ADS.Core.Domain.Model
{
    public class LibraryModel
    {
        public LibraryModel()
        {
            Read();
        }

        // nacitanie dat zo suboru do kniznice :)
        private void LoadData()
        {
            StreamReader w = new StreamReader("libraries.txt");
            string line = "";
            Libraries = new AvlTree<Library>(new Library.LibraryNameComparator());
            while ((line = w.ReadLine())!=null)
            {
                Libraries.Add(new Library(line));
            }
            w.Close();

            StreamReader w2 = new StreamReader("books.txt");
            line = "";
            BooksByName = new AvlTree<Book>(new Book.BookNameComparator());
            BooksByUniqueId = new AvlTree<Book>(new Book.BookUniqueIdComparer());
            BooksByIsbn = new AvlTree<Book>(new Book.BookIsbnComparator());
            while ((line = w2.ReadLine()) != null)
            {
                var data = line.Split(',');

                var title = data[0].Trim();
                    var author = data[1];
                    var uid = data[2].Trim();
                    var isbn = data[3].Trim();
                    var ean = data[4].Trim();

                    //var name = data[5].Trim();
                    //var surname = data[6].Trim();
                    //var from = data[7].Trim();
                    //var to = data[8].Trim();
                    //var borrowed = data[9].Trim();
                    //var archived = data[10].Trim();

                    Book b = new Book(author, title, isbn, ean, "Poetry", null, int.Parse(uid));
                    // time from, to, archived, borrowed
                    BooksByIsbn.Add(b);
                    BooksByUniqueId.Add(b);
                    BooksByName.Add(b);
            }
            w2.Close();

            StreamReader w3 = new StreamReader("current.txt");
            line = "";
            while ((line = w3.ReadLine()) != null)
            {
                var data = line.Split(',');
                if (data[0].Contains(":"))
                {
                    var title = data[0].Trim();
                    var author = data[1];
                    var uid = data[2].Trim();
                    var isbn = data[3].Trim();
                    var ean = data[4].Trim();

                    var name = data[5].Trim();
                    var surname = data[6].Trim();
                    var rid = data[7].Trim();
                    var from = data[8].Trim();
                    var to = data[9].Trim();
                    var borrowed = data[10].Trim();
                    var archived = data[11].Trim();
                    
                    var currLib = data[12].Trim();

                    Book b = new Book(author, title, isbn, ean, "Poetry", new Library(currLib), int.Parse(uid));
                    if (from != "")
                    {
                        var date = from.Split('.');
                        b.TimeOfBorrow = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                    }
                    if (to != "")
                    {
                        var date = to.Split('.');
                        b.TimeOfReturn = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                    }

                    b.IsBorrowed = borrowed != "";
                    b.IsArchived = archived != "";

                    if (name != "" && surname != "" && rid != "")
                    {
                        Reader r = new Reader(int.Parse(rid), name, surname);
                        Reader rf = ReadersById.SearchNode(r, ReadersById.Root).Data;
                        Borrowing brw = new Borrowing(b, rf);
                    }
                    
                    
                    
                }
                else
                {
                    continue;
                }
            }
            w2.Close();
        }

        public static AvlTree<Library> Libraries { get; set; }
        public static AvlTree<Book> BooksByName { get; set; }
        public static AvlTree<Book> BooksByIsbn { get; set; }
        public static AvlTree<Book> BooksByUniqueId { get; set; }
        public static AvlTree<Reader> ReadersById { get; set; }
        private static int _maxBookId;
        public ReaderSession ReaderSession { get; set; }
        public static AvlTree<Reader> ReadersByName { get; set; }
        private static int _maxReaderId;

        public int NewReaderId()
        {
            return ++_maxReaderId;
        }

        public int NextBookId()
        {
            return ++_maxBookId;
        }

        public static void Save()
        {
            SaveData.WriteBookToFile("books.txt", BooksByName);
            SaveData.WriteBorrowingToFile("borrowing.txt", ReadersById.SearchNode(new Reader(0, "",""), ReadersById.Root).Data.BooksBorrowedInPast);
            SaveData.WriteLibraryToFile("libraries.txt", Libraries);
            SaveData.WriteReaderToFile("readers.txt", ReadersById);
        }

        public static void GenerateData()
        {
            LibraryDataGenerator generator = new LibraryDataGenerator();

            BooksByName = generator.BooksByName;
            BooksByIsbn = generator.BooksByIsbn;
            BooksByUniqueId = generator.BooksByUniqueId;
            ReadersByName = generator.ReadersByName;
            ReadersById = generator.ReadersById;
            Libraries = generator.Libraries;
            _maxReaderId = generator.NumberOfReaders;
            _maxBookId = generator.NumberOfBooks;
        }

        public static void Read()
        {
            ReadData reader = new ReadData();

            BooksByName = reader.BooksByName;
            BooksByIsbn = reader.BooksByIsbn;
            BooksByUniqueId = reader.BooksByUniqueId;
            ReadersByName = reader.ReadersByName;
            ReadersById = reader.ReadersById;
            Libraries = reader.Libraries;
            _maxReaderId = reader.NumberOfReaders;
            _maxBookId = reader.NumberOfBooks;
        }
    }
}
