using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.Services.DataGenerating;

namespace ADS.ADS.Services.DataProcessing
{
    public class DataParser
    {
        private static string _genreName;
        //public static List<Book> Books { get; private set; }

        private static UniqueKeyGenerator gen = new UniqueKeyGenerator();
        private static Editor _editor1 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Thomson&Thomson");
        private static Editor _editor2 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Ziva's Books");
        private static Editor _editor3 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "B&W");
        private static Editor _editor4 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Alan Musk");
        private static Editor _editor5 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "SanNotino");
        private static Random _rnd = new Random(0);

        public static void FillDataStructure(AvlTree<Book> tree, AvlTree<Book> tree2)
        {

            AvlTree<Book> books = tree;
            AvlTree<Book> books2 = tree2;

            _genreName = "Poetry";

            StreamReader reader = new StreamReader("poetry.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    var b = ParseLine(line, books);
                    books.Add(b);
                    books2.Add(b);
                }
                catch (Exception e)
                {
                    //Console.WriteLine("While reading data from file, this exception occured: {0}", e.StackTrace);
                }
            }

            //return books;
        }

        public static AvlTree<Reader> FillReadersByName(AvlTree<Reader> tree)
        {
            AvlTree<Reader> readers = tree;

            StreamReader reader = new StreamReader("readers.txt");
            string[] readerData;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    readerData = line.Split(',');
                    var r = new Reader(int.Parse(readerData[2]), readerData[0], readerData[1]);
                    readers.Add(r);
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
            return readers;
        }

        public static AvlTree<Reader> FillReadersById(AvlTree<Reader> tree)
        {
            AvlTree<Reader> readers = tree;

            StreamReader reader = new StreamReader("readers.txt");
            string[] readerData;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    readerData = line.Split(',');
                    var r = new Reader(int.Parse(readerData[2]), readerData[0], readerData[1]);
                    readers.Add(r);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return readers;
        }

        private static Book ParseLine(string line, AvlTree<Book> books)
        {
            string[] words = line.Split('-');
            string name = words[0];
            //nemusi byt
            string author = words[1];
            int firstBracketOccurence = name.IndexOf("(");
            string year = name.Substring(firstBracketOccurence);
            name = name.Substring(0, firstBracketOccurence);

            return  new Book(author.Trim(), name.Trim(), _genreName.Trim(), AssignIsbnCode());
        }

        private static string AssignIsbnCode()
        {
            double var = _rnd.Next();
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

        public static AvlTree<Reader> FillDataStructure(AvlTree<Reader> readersByName)
        {
            throw new NotImplementedException();
        }
    }
}
