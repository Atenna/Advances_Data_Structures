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
            DataParser.ReadDataFromFile("poetry.txt", "Poetry");

            AvlTree<Book> books = DataParser.Books;
            books.PreorderTraversal(books.Root);

            Book b1 = new Book("", "Advent", "");
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
