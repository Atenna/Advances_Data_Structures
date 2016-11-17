using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.ADS.Data.Library;
using ADS.ADS.Nodes;

namespace ADS.Core.Domain.Controller
{
    public class ReaderSession : IReaderSession
    {
        public Reader Reader { get; set; }

        public ReaderSession(Reader r)
        {
            Reader = r;
        }


        public void BorrowBook(string bookIsbn, int bookId, string libraryName)
        {
        }

        public void ReturnBook(string bookIsbn, int bookId, string libraryName)
        {
            // to do 
            Reader.BooksCurrentlyBorrowed.RemoveNode(null);
        }
    }
}
