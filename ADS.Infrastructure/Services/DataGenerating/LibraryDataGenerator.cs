using System;
using System.Collections.Generic;
using System.IO;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.ADS.Services.DataProcessing;
using ADS.Services.DataGenerating;

namespace ADS.ADS.Services.DataGenerating
{
    public class LibraryDataGenerator
    {
        private string[] _names;
        private string[] _surnames;
        private string[] _cities;

        public AvlTree<Library> Libraries { get; set; }
        public AvlTree<Book> BooksByName { get; set; }
        public AvlTree<Book> BooksByIsbn { get; set; }
        public AvlTree<Book> BooksByUniqueId { get; set; }
        public AvlTree<Reader> ReadersById { get; set; }
        public AvlTree<Reader> ReadersByName { get; set; }

        private static UniqueKeyGenerator gen = new UniqueKeyGenerator();
        private static Editor _editor1 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Thomson&Thomson");
        private static Editor _editor2 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Ziva's Books");
        private static Editor _editor3 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "B&W");
        private static Editor _editor4 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Alan Musk");
        private static Editor _editor5 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "SanNotino");

        private static Random _generator;
        private string[] libraryNames;
        public int NumberOfReaders;
        public int NumberOfBooks;
        private int NumberOfLibraries;
        private static int counterOfBooks;

        public LibraryDataGenerator()
        {
            BooksByName = new AvlTree<Book>(new Book.BookNameComparator());
            Libraries = new AvlTree<Library>(new Library.LibraryNameComparator());
            BooksByIsbn = new AvlTree<Book>(new Book.BookIsbnComparator());
            BooksByUniqueId = new AvlTree<Book>(new Book.BookUniqueIdComparer());
            ReadersById = new AvlTree<Reader>(new Reader.ReaderIdComparator());
            ReadersByName = new AvlTree<Reader>(new Reader.ReaderNameComparator());

            _generator = new Random();

            NumberOfReaders = 10000;
            NumberOfLibraries = 3000;
            counterOfBooks = 1;

            ReadData();

            GenerateReaderData();
            GenerateLibraryData();
            libraryNames = Libraries.InorderTraversalToStringArray(Libraries.Root);
            GenerateBookData();
            NumberOfBooks = counterOfBooks;
            
            GenerateBorrowingData();
        }

        private void ReadData()
        {
            StreamReader reader = new StreamReader("names.txt");
            List<string> names = new List<string>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                names.Add(line.Trim());
            }

            StreamReader reader2 = new StreamReader("surnames.txt");
            List<string> surnames = new List<string>();
            string line2;
            while ((line2 = reader2.ReadLine()) != null)
            {
                surnames.Add(line2.Trim());
            }

            StreamReader reader3 = new StreamReader("cities.txt");
            List<string> cities = new List<string>();
            string line3;
            while ((line3 = reader3.ReadLine()) != null)
            {
                cities.Add(line3.Trim());
            }

            _names = names.ToArray();
            _surnames = surnames.ToArray();
            _cities = cities.ToArray();
        }


        public void GenerateReaderData()
        {
            for (int i = 0; i < NumberOfReaders; i++)
            {
                var r = new Reader(i, _names[_generator.Next(0, _names.Length)], _surnames[_generator.Next(0,_surnames.Length)]);
                ReadersById.Add(r);
                ReadersByName.Add(r);
            }
        }

        public void GenerateLibraryData()
        {
            for (int i = 0; i < 5000; i++)
            {
                string name = _cities[_generator.Next(0, _cities.Length)];
                if (name != "")
                {
                    char part = (char) _generator.Next(65, 90);
                    Libraries.Add(new Library(name + " " + part + i%8));
                }
            }
        }

        public void GenerateBorrowingData()
        {
            for (int i = 1; i < NumberOfBooks; i++)
            {
                var b = BooksByUniqueId.SearchNode(new Book("", "", "", "", "", null, i), BooksByUniqueId.Root);
                DateTime from = new DateTime(_generator.Next(2012, 2013), _generator.Next(1, 12), _generator.Next(1, 28));
                DateTime to = from.AddDays(_generator.Next(5, 35));
                for (int j = 0; j < 10000; j++)
                {
                    var r = ReadersById.SearchNode(new Reader( 1, "", ""), ReadersById.Root);
                    var l = Libraries.SearchNode(new Library(libraryNames[_generator.Next(0, NumberOfLibraries)]),
                    Libraries.Root);
                    b.Data.Borrow(r.Data, from);
                    b.Data.Return(l.Data, r.Data, to);
                    from = to.AddDays(2);
                    to = from.AddDays(_generator.Next(5, 35));
                    if (to > DateTime.Today)
                    {
                        return;
                    }
                }
            }
        }

        public void GenerateBookData()
        {
            StreamReader reader = new StreamReader("poetry.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    Book b = ParseLine(line);
                    var rand = _generator.Next(100,1000);
                    for (int i = 0; i < rand; i++)
                    {
                        Library l = Libraries.SearchNode(
                        new Library(libraryNames[_generator.Next(0, libraryNames.Length)]), Libraries.Root).Data;
                        Book c = new Book(b.Author, b.Title, b.CodeIsbn, b.CodeEan, b.Genre, l, counterOfBooks);
                        BooksByIsbn.Add(c);
                        BooksByUniqueId.Add(c);
                        BooksByName.Add(c);
                        counterOfBooks++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("While reading data from file, this exception occured: {0}", e.StackTrace);
                }
            }
        }

        private static Book ParseLine(string line)
        {
            string[] words = line.Split('-');
            string name = words[0];
            //nemusi byt
            string author = words[1];
            int firstBracketOccurence = name.IndexOf("(");
            name = name.Substring(0, firstBracketOccurence);
            Book newBook = new Book(author.Trim(), name.Trim(), AssignIsbnCode(), AssignEanCode(), "Poetry", null, counterOfBooks);
            return newBook;
        }

        private static string AssignEanCode()
        {
            double var = _generator.Next();
            if (var < 20 && var >= 0)
            {
                return _editor1.GenerateIsbn();
            }
            else if (var < 40 && var >= 20)
            {
                return _editor2.GenerateIsbn();
            }
            else if (var < 60 && var >= 40)
            {
                return _editor3.GenerateIsbn();
            }
            else if (var < 80 && var >= 60)
            {
                return _editor4.GenerateIsbn();
            }
            else
            {
                return _editor5.GenerateIsbn();
            }
        }

        private static string AssignIsbnCode()
        {
            double var = _generator.Next();
            if (var < 20 && var >= 0)
            {
                return _editor1.GenerateIsbn();
            }
            else if (var < 40 && var >= 20)
            {
                return _editor2.GenerateIsbn();
            }
            else if (var < 60 && var >= 40)
            {
                return _editor3.GenerateIsbn();
            }
            else if (var < 80 && var >= 60)
            {
                return _editor4.GenerateIsbn();
            }
            else
            {
                return _editor5.GenerateIsbn();
            }
        }
    }
}
