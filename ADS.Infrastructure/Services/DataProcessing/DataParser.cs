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

        public static AvlTree<Book> Books;
        private static UniqueKeyGenerator gen = new UniqueKeyGenerator();
        private static Editor _editor1 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Thomson&Thomson");
        private static Editor _editor2 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Ziva's Books");
        private static Editor _editor3 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "B&W");
        private static Editor _editor4 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "Alan Musk");
        private static Editor _editor5 = new Editor(gen.GenerateEditorCode(), gen.GenerateGroupCode(), "SanNotino");
        private static Random _rnd=  new Random();

        public static void ReadDataFromFile(string name, string genre)
        {
            _genreName = genre;
            //Books = new List<Book>();
            Books = new AvlTree<Book>(new Book.BookNameComparator());

            StreamReader reader = new StreamReader(name);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    ParseLine(line);
                }
                catch (Exception e)
                {
                    //Console.WriteLine("While reading data from file, this exception occured: {0}", e.StackTrace);
                }
            }
        }

        private static void ParseLine(string line)
        {
            string[] words = line.Split('-');
            string name = words[0];
            //nemusi byt
            string author = words[1];
            int firstBracketOccurence = name.IndexOf("(");
            string year = name.Substring(firstBracketOccurence);
            name = name.Substring(0, firstBracketOccurence);

            Book book=  new Book(author.Trim(), name.Trim(), _genreName.Trim(), AssignIsbnCode());
            Books.Add(book);
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

    }
}
