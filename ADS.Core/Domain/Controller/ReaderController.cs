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
            string ret = "";
            foreach (var bor in Reader.BooksCurrentlyBorrowed)
            {
                ret += bor.ToString() + "\n";
            }
            return ret;
        }

        public string ShowLateReturnedBooks()
        {
            string ret = "";
            foreach (var bor in Reader.LateBookReturns)
            {
                ret += bor.ToString() + "\n";
            }
            return ret;
        }

        public string ShowBorrowedBooksPast()
        {
            string ret = "";
            foreach (var bor in Reader.BooksBorrowedInPast)
            {
                ret += bor.ToString() + "\n";
            }
            return ret;
        }
    }
}
