using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Core.Domain.Controller
{
    public interface IReaderSession
    {
        void BorrowBook(string bookIsbn, int bookId, string libraryName);

        void ReturnBook(string bookIsbn, int bookId, string libraryName);

    }
}
