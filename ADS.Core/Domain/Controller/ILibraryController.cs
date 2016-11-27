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

        string SearchLibraryByName(string name);

        string SearchLibraryById(string name);

        string SearchBookByIsbn(string isbn, string libraryName);

        string[] SearchBookByIsbnArray(string isbn, string libraryName);

        string SearchBookByName(string name, string libraryName);

        bool BorrowBook(int bookId, string bookIsbn, int readerId, string libraryName, DateTime when);

        int ReturnBook(string isbn, int bookId, string bookName, int readerId, string libraryId, DateTime when);

        string SearchReaderById(string readerId);

        string[] SearchReaderByName(string readerId);

        string ShowBorrowedBooksCurrently(int readerId);

        string[] ShowAllLibraries();

        string ShowBooksInLibrary(string libraryId);

        string ShowBorrowedBooksInLibrary(string libraryId);

        bool AddNewReader(string name, string surname,string address, string dateOfBirth);

        bool AddNewBook(string title, string author, string genre, string isbn, string ean, string libraryId);

        string[] ShowBorrowedBooksAfterReturnDate(string libraryId);

        bool ArchiveBook(string isbn);

        bool ArchiveBook(string isbn, int bookId, string libraryName);

        string ShowLateReturnedBooks(string readerId, DateTime fromTime, DateTime toTime);

        string ShowBorrowedBooksPast(string readerId);

        bool AddLibrary(string name);

        bool RemoveLibrary(string libraryId, string moveToLibraryId);

        bool RemoveReader(string readerId);

        string ShowAllReaders();

        string ShowAllBooks();

        string ShowAllBooks(string libraryName);

        string ShowAllBooks(int libraryId);

        string SearchBookByNameWithUniqueId(string bookname, int uniqueid, string libraryName);
    }
}
