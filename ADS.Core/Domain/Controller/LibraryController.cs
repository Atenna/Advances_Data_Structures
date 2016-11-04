using System;
using System.Collections.Generic;
using ADS.ADS.Data.Library;
using ADS.ADS.Nodes;
using ADS.Core.Domain.Model;

namespace ADS.Core.Domain.Controller
{
    public class LibraryController : ILibraryController
    {
        private readonly LibraryModel _model;
        public LibraryController()
        {
            _model=  new LibraryModel();
        }

        public string SearchBookByIsbn(string isbn)
        {
            Book b = new Book("", "", "", isbn);
            AbstractNode<Book> result = _model.BooksByIsbn.SearchNode(b, _model.BooksByIsbn.Root);
            if (result != null)
            {
                return result.Data.ToString();
            }
            List<AbstractNode<Book>> found = _model.BooksByIsbn.SearchSimilar(b, _model.BooksByIsbn.Root);
            string listOfSimilarBooks = "";
            foreach (var book in found)
            {
                listOfSimilarBooks += book.Data.ToString();
            }
            return listOfSimilarBooks;
        }

        public string SearchBookByName(string name)
        {
            Book b = new Book("", name, "");
            AbstractNode<Book> result = _model.BooksByName.SearchNode(b, _model.BooksByName.Root);
            if (result != null)
            {
                return result.Data.ToString();
            }
            List<AbstractNode<Book>> found = _model.BooksByName.SearchSimilar(b, _model.BooksByName.Root);
            string listOfSimilarBooks = "";
            foreach (var book in found)
            {
                listOfSimilarBooks += book.Data.ToString();
            }
            return listOfSimilarBooks;
        }

        public bool BorrowBook(string bookId, string readerId, string libraryId)
        {
            throw new NotImplementedException();
        }

        public bool ReturnBook(string bookId, string readerId, string libraryId)
        {
            throw new NotImplementedException();
        }

        public string SearchReaderById(string readerId)
        {
            throw new NotImplementedException();
        }

        public string ShowBorrowedBooksCurrently(string readerId)
        {
            throw new NotImplementedException();
        }

        public string ShowAllLibraries()
        {
            throw new NotImplementedException();
        }

        public string ShowBooksInLibrary(string libraryId)
        {
            throw new NotImplementedException();
        }

        public string ShowBorrowedBooksInLibrary(string libraryId)
        {
            throw new NotImplementedException();
        }

        public bool AddNewReader(string name, string surname, string address, string dateOfBirth)
        {
            throw new NotImplementedException();
        }

        public bool AddNewBook(string title, string author, string genre, string isbn, string ean, string libraryId)
        {
            throw new NotImplementedException();
        }

        public string ShowBorrowedBooksAfterReturnDate(string libraryId)
        {
            throw new NotImplementedException();
        }

        public bool ArchiveBook(string isbn)
        {
            throw new NotImplementedException();
        }

        public string ShowLateReturnedBooks(string readerId, DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }

        public string ShowBorrowedBooksPast(string readerId)
        {
            throw new NotImplementedException();
        }

        public bool AddLibrary(string name)
        {
            throw new NotImplementedException();
        }

        public bool RemoveLibrary(string libraryId, string moveToLibraryId)
        {
            throw new NotImplementedException();
        }

        public string ShowAllReaders()
        {
            throw new NotImplementedException();
        }
    }
}
