using System;
using System.Collections;
using System.Collections.Generic;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.ADS.Services.DataProcessing;

namespace ADS.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataParser.ReadDataFromFile("poetry.txt", "Poetry");
            foreach (var book in DataParser.Books)
            {
                Console.WriteLine("Name {0}, Author {1}, Genre {2}", book.Title, book.Author, book.Genre);
            }
            Console.ReadKey();

            AvlTree<Book> books = new AvlTree<Book>((IComparer<Book>)new Book.BookNameComparator());
            books.Add(new Book("Ivka Lieskovska", "Ako islo vajce na vandrovku", "Proza"));
            books.Add(new Book("Anexander Dubcek", "Zootopia", "Drama"));
            books.Add(new Book("Janko Janech", "Kral Drozdia Brada", "Rozpravky"));
            books.Add(new Book("Peter Spidy Gonzales", "Medial Banana", "Drama"));
            books.Add(new Book("Jardo Janacek", "Zootopia", "Drama"));
        }
    }
}
