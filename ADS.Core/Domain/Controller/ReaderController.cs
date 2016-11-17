using System;
using ADS.ADS.Data.Library;

namespace ADS.Core.Domain.Controller
{
    public class ReaderController
    {
        public Reader Reader { get; set; }

        public ReaderController(int readerId)
        {
            Reader = new Reader(readerId, "", "");
        }

        public override String ToString()
        {
            return Reader.ToString();
        }

        public string ShowBorrowedBooksCurrently()
        {
            return Reader.BooksCurrentlyBorrowed.InorderTraversal(Reader.BooksCurrentlyBorrowed.Root);
        }

        public string ShowLateReturnedBooks()
        {
            return Reader.LateBookReturns.InorderTraversal(Reader.LateBookReturns.Root);
        }

        public string ShowBorrowedBooksPast()
        {
            return Reader.BooksBorrowedInPast.InorderTraversal(Reader.BooksBorrowedInPast.Root);
        }
    }
}
