using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.ADS.Data.Library;

namespace ADS.ADS.Services.DataProcessing
{
    public class DataParser
    {
        private static string genreName;
        public static List<Book> Books { get; private set; }
        public static void ReadDataFromFile(string name, string genre)
        {
            genreName = genre;
            Books = new List<Book>();
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
                    Console.WriteLine("While reading data from file, this exception occured: {0}", e.StackTrace);
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

            Book book=  new Book(author, name, genreName);
            Books.Add(book);
        }
    }
}
