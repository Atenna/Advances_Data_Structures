using System;
using System.Collections.Generic;
using ADS.ADS.Data.Library;
using ADS.ADS.Nodes;

namespace ADS.Core.Domain.Controller
{
    public interface ILibraryController
    {
        string SearchBookByIsbn(string isbn);

        string SearchBookByName(string name);

        bool BorrowBook(string bookId, string readerId, string libraryId);

        bool ReturnBook(string bookId, string readerId, string libraryId);

        string SearchReaderById(string readerId);

        string[] SearchReaderByName(string readerId);

        string ShowBorrowedBooksCurrently(string readerId);

        string ShowAllLibraries();

        string ShowBooksInLibrary(string libraryId);

        string ShowBorrowedBooksInLibrary(string libraryId);

        bool AddNewReader(string name, string surname,string address, string dateOfBirth);

        bool AddNewBook(string title, string author, string genre, string isbn, string ean, string libraryId);

        string ShowBorrowedBooksAfterReturnDate(string libraryId);

        bool ArchiveBook(string isbn);

        string ShowLateReturnedBooks(string readerId, DateTime fromTime, DateTime toTime);

        string ShowBorrowedBooksPast(string readerId);

        bool AddLibrary(string name);

        bool RemoveLibrary(string libraryId, string moveToLibraryId);

        string ShowAllReaders();

        string ShowAllBooks();
    }
}
