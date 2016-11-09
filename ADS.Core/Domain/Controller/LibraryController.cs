using System;
using System.Collections.Generic;
using ADS.ADS.Data.Library;
using ADS.ADS.Nodes;
using ADS.Core.Domain.Model;

namespace ADS.Core.Domain.Controller
{
    public class LibraryController : ILibraryController
    {
        public readonly LibraryModel _model;

        public LibraryController()
        {
            _model = new LibraryModel();
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

        public string[] SearchReaderById(string readerId)
        {
            int id;

            try
            {
                id = Int32.Parse(readerId);
                Reader r = new Reader(id, "", "");
                var found = _model.ReadersById.SearchNode(r, _model.ReadersById.Root);
                if (found != null)
                {
                    string[] toReturn = new string[1];
                    toReturn[0] = found.Data.ToString();
                    return toReturn;
                }
                List<AbstractNode<Reader>> similarList = _model.ReadersById.SearchSimilar(r, _model.ReadersById.Root);
                string[] similar = new string[similarList.Count];
                for (int reader = 0; reader < similarList.Count; reader++)
                {
                    similar[reader] = similarList[reader].Data.ToString();
                }
                return similar;
            }
            catch (Exception)
            {
                // error
                throw;
            }

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
            try
            {
                Reader r = new Reader(_model.NewReaderId(), name, surname);
                _model.ReadersById.Add(r);
                _model.ReadersByName.Add(r);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
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
            return _model.ReadersByName.InorderTraversal(_model.ReadersByName.Root);
        }

        public string ShowAllBooks()
        {
            return _model.BooksByName.InorderTraversal(_model.BooksByName.Root);
        }

        public string[] SearchReaderByName(string readerName)
        {

            string[] names = readerName.Split(' ');
            if (names.Length == 2)
            {
                Reader r1 = new Reader(-1, names[0], names[1]);
                var found = _model.ReadersByName.SearchNode(r1, _model.ReadersByName.Root);
                if (found != null)
                {
                    string[] toreturn = new string[1];
                    toreturn[0] = found.Data.ToString();
                    return toreturn;
                }
                List<AbstractNode<Reader>> similarList1 = _model.ReadersByName.SearchSimilar(r1, _model.ReadersByName.Root);
                string[] similar = new string[similarList1.Count];
                for (int reader = 0; reader < similarList1.Count; reader++)
                {
                    similar[reader] = similarList1[reader].Data.ToString();
                }
                return similar;
            }
            else if (names.Length == 1)
            {
                Reader r1 = new Reader(-1, names[0], "");
                List<AbstractNode<Reader>> similarList1 = _model.ReadersByName.SearchSimilar(r1, _model.ReadersByName.Root);
                string[] similar = new string[similarList1.Count];
                for (int reader = 0; reader < similarList1.Count; reader++)
                {
                    similar[reader] = similarList1[reader].Data.ToString();
                }
                return similar;
            }
            else
            {
                return new string[0];
            }
        }

        string ILibraryController.SearchReaderById(string readerId)
        {
            throw new NotImplementedException();
        }
    }
}
