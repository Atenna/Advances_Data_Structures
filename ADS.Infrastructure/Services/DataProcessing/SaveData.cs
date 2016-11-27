using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;

namespace ADS.ADS.Services.DataProcessing
{
    public class SaveData
    {

        public static void WriteBookToFile(string filename, AvlTree<Book> tree)
        {
            StreamWriter w = new StreamWriter(filename);
            string[] a = tree.InorderTraversalToStringArraysave(tree.Root);
            for (int i = 0; i < a.Length; i++)
            {
                w.WriteLine(a[i]);
            }
            w.Close();
        }

        public static void WriteReaderToFile(string filename, AvlTree<Reader> tree)
        {
            StreamWriter w = new StreamWriter(filename);
            StreamWriter wA = new StreamWriter("current.txt"); // current
            StreamWriter wB = new StreamWriter("previous.txt"); //previous
            StreamWriter wC = new StreamWriter("late.txt"); //late
            string[] a = tree.InorderTraversalToStringArray(tree.Root);
            for (int i = 0; i < a.Length; i++)
            {
                w.WriteLine(a[i]);
                var reader = a[i].Split(',');
                var readerName = reader[0].Split(' ');
                if (reader.Length == 2)
                {
                    var found = tree.SearchNode(new Reader(Convert.ToInt32(reader[1]), readerName[0], readerName[1]),
                        tree.Root);
                    WriteBorrowingToFile(wA, found.Data.BooksCurrentlyBorrowed);
                    WritePastBorrowingToFile(wB, found.Data.BooksBorrowedInPast);
                    WriteLateBorrowingToFile(wC, found.Data.LateBookReturns);
                }
                else
                {
                    var found = tree.SearchNode(new Reader(Convert.ToInt32(reader[2]), readerName[0], readerName[1]),
                    tree.Root);
                    WriteBorrowingToFile(wA, found.Data.BooksCurrentlyBorrowed);
                    WritePastBorrowingToFile(wB, found.Data.BooksBorrowedInPast);
                    WriteLateBorrowingToFile(wC, found.Data.LateBookReturns);
                }
                
            }
            w.Close();
            wA.Close();
            wB.Close();
            wC.Close();
        }

        private static void WriteLateBorrowingToFile(StreamWriter wC, List<Borrowing> data)
        {
            if (data != null || data.Count != 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    wC.WriteLine(data[i].ToStringSave());
                }
            }
        }

        private static void WritePastBorrowingToFile(StreamWriter wB, List<Borrowing> data)
        {
            if (data != null && data.Count != 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    wB.WriteLine(data[i].ToStringSave());
                }
            }
        }

        private static void WriteBorrowingToFile(StreamWriter w, List<Book> tree)
        {
            
            if (tree != null && tree.Count != 0)
            {
                for (int i = 0; i < tree.Count; i++)
                {
                    w.WriteLine(tree[i].ToStringSave());
                }
            }
        }

        private static void WriteBorrowingToFile(StreamWriter w, AvlTree<Book> tree)
        {
            string[] a = tree.InorderTraversalToStringArraysave(tree.Root);
            if (a != null)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    // nezapisuje readera
                    w.WriteLine(a[i]);
                }
            }
        }

        public static void WriteLibraryToFile(string filename, AvlTree<Library> tree)
        {
            StreamWriter w = new StreamWriter(filename);
            string[] a = tree.InorderTraversalToStringArray(tree.Root);
            for (int i = 0; i < a.Length; i++)
            {
                w.WriteLine(a[i]);
            }
            w.Close();
        }

        public static void WriteBorrowingToFile(string filename, AvlTree<Borrowing> tree)
        {
            StreamWriter w = new StreamWriter(filename);
            string[] a = tree.InorderTraversalToStringArraysave(tree.Root);
            if (a != null)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    w.WriteLine(a[i]);
                }
            }
            w.Close();
        }
    }
}
