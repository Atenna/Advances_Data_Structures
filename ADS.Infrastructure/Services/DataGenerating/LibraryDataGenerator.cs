using System;
using System.Collections.Generic;
using System.IO;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;

namespace ADS.ADS.Services.DataGenerating
{
    public class LibraryDataGenerator
    {
        private string[] _names;
        private string[] _surnames;
        private string[] _cities;

        public AvlTree<Library> Libraries { get; set; }
        public AvlTree<Book> BooksByName { get; }
        public AvlTree<Book> BooksByIsbn { get; }
        public AvlTree<Reader> ReadersById { get; }
        public AvlTree<Reader> ReadersByName { get; }

        private Random _generator;

        public LibraryDataGenerator()
        {
            ReadersByName = new AvlTree<Reader>(new Reader.ReaderNameComparator());
            ReadersById = new AvlTree<Reader>(new Reader.ReaderIdComparator());
            _generator = new Random();

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

            GenerateReaderData();
            GenerateLibraryData();
        }

        public void GenerateReaderData()
        {
            for (int i = 0; i < 20000; i++)
            {
                var r = new Reader(i, _names[_generator.Next(0, _names.Length)], _surnames[_generator.Next(0,_surnames.Length)]);
                ReadersById.Add(r);
                ReadersByName.Add(r);
            }
        }

        public void GenerateLibraryData()
        {
            Libraries = new AvlTree<Library>(new Library.LibraryNameComparator());
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
            
        }

        public void GenerateReturnData()
        {
            
        }

        public void GenerateBookData()
        {
            
        }
    }
}
