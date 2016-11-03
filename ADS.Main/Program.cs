using System;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;
using ADS.ADS.Services.DataProcessing;

namespace ADS.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AvlTree<Book> books = new AvlTree<Book>(new Book.BookIsbnComparator());

            //books.PreorderTraversal(books.Root);

            Book b1 = new Book("", "Advent", "", "978-94-738428-1765");
            AbstractNode<Book> result = books.SearchNode(b1, books.Root);
            Console.WriteLine(result?.Data.Title);

            DataGenerator g = new DataGenerator();

            for (int i = 0; i < 20; i++)
            {
                Reader r = g.GenerateReader();
                //Console.WriteLine("Name: {0}, Surname: {1}", r.Name, r.Surname);
            }

            Console.ReadKey();
        }
    }
}
