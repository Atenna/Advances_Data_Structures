using System;
using System.Collections.Generic;
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
            string[] a = tree.InorderTraversalToStringArray(tree.Root);
            for (int i = 0; i < a.Length; i++)
            {
                w.WriteLine(a[i]);
            }
        }

        public static void WriteReaderToFile(string filename, AvlTree<Reader> tree)
        {
            StreamWriter w = new StreamWriter(filename);
            string[] a = tree.InorderTraversalToStringArray(tree.Root);
            for (int i = 0; i < a.Length; i++)
            {
                w.WriteLine(a[i]);
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
        }

        public static void WriteBorrowingToFile(string filename, AvlTree<Borrowing> tree)
        {
            StreamWriter w = new StreamWriter(filename);
            string[] a = tree.InorderTraversalToStringArray(tree.Root);
            for (int i = 0; i < a.Length; i++)
            {
                w.WriteLine(a[i]);
            }
        }
    }
}
