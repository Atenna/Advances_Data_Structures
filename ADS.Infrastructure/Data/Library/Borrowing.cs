using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.ADS.Data.Library
{
    public class Borrowing
    {
        public class BorrowingComparator : IComparer<Borrowing>
        {
            public int Compare(Borrowing x, Borrowing y)
            {
                //return string.Compare(x.Title, y.Title);
                if (x.DateOfBorrow > y.DateOfBorrow)
                {
                    return 1;
                }
                if (x.DateOfBorrow < y.DateOfBorrow)
                {
                    return -1;
                }
                return 0;
            }
        }

        public Borrowing(Book b, Reader r)
        {
            Reader = r;
            Book = b;
            if (b.TimeOfBorrow != null) DateOfBorrow = b.TimeOfBorrow.Value;
            if (b.TimeOfReturn != null) DateOfReturn = b.TimeOfReturn.Value;

            if ((DateOfReturn - DateOfBorrow).TotalDays > 30)
            {
                FeeToPay = true;
                Fee = ((DateOfReturn - DateOfBorrow).Days - 30)*b.FeePerDay;
            }
        }
        public Reader Reader { get; }
        public Book Book { get; set; }

        public DateTime DateOfBorrow { get; set; }
        public DateTime DateOfReturn { get; set; }
        public DateTime DateOfProlong { get; set; }
        public int Fee { get; set; }
        public bool FeeToPay { get; set; }
        public bool FeePaid { get; set; }

        public override string ToString()
        {
            var fee = FeeToPay ? "Fee: " + Fee : "None";
            string returndate = DateOfReturn.ToString("dd.MM.yyyy");
            string borrowed = "Borrowed: " + DateOfBorrow.ToString("dd.MM.yyyy") + " - " + returndate;
            string archived = Book.IsArchived ? "Archived" : "Not archived";
            return Book.Title + " : " + Book.Author + "\n\tUnique id:" + Book.UniqueId + "\n\tISBN:" + Book.CodeIsbn + "\n\tEAN:"
                + Book.CodeEan + "\n\t" + borrowed + "\n\t" + archived + "\n\t" + Fee;
        }

        public string ToStringSave()
        {
            var fee = FeeToPay ? Fee+"" : "0";
            return Book.ToStringSave() + "," + fee;
        }
    }
}
