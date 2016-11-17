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
                listOfSimilarBooks += book.Data.ToString() + "\n";
            }
            return listOfSimilarBooks;
        }

        public string SearchLibraryByName(string name)
        {
            throw new NotImplementedException();
        }

        public string SearchLibraryById(string name)
        {
            throw new NotImplementedException();
        }

        public string SearchBookByIsbn(string isbn, string libraryName)
        {
            AbstractNode<Library> l = _model.Libraries.SearchNode(new Library(libraryName), _model.Libraries.Root);
            AbstractNode<Book> b = l.Data.AllBooksByIsbn.SearchNode(new Book("", "", "", isbn),
                l.Data.AllBooksByIsbn.Root);
            return b?.Data.ToString();
        }

        public string[] SearchBookByIsbnArray(string isbn, string libraryName)
        {
            Book b = new Book("", "", "", isbn);
            AbstractNode<Library> l = _model.Libraries.SearchNode(new Library(libraryName), _model.Libraries.Root);

            string[] books;
            AbstractNode<Book> result = l.Data.AllBooksByIsbn.SearchNode(b, l.Data.AllBooksByIsbn.Root);
            if (result != null)
            {
                books = new string[1];
                books[0] = result.Data.ToString();
                return books;
            }
            List<AbstractNode<Book>> found = l.Data.AllBooksByIsbn.SearchSimilar(b, l.Data.AllBooksByIsbn.Root);
            books = new string[found.Count];
            for (int i = 0; i < found.Count; i++)
            {
                books[i] = found[i].Data.ToString();
            }
            return books;
        }

        public string SearchBookByName(string name, string libraryName)
        {
            AbstractNode<Library> l = _model.Libraries.SearchNode(new Library(libraryName), _model.Libraries.Root);
            if (libraryName == "")
            {
                return "";
            }
            AbstractNode<Book> b = l.Data.AllBooksByName.SearchNode(new Book("", name, ""), l.Data.AllBooksByName.Root);
            if (b != null)
            {
                return b.Data.ToString();
            }
            List<AbstractNode<Book>> books = l.Data.AllBooksByName.SearchSimilar(new Book("", name, ""),
                l.Data.AllBooksByName.Root);
            string listOfSimilarBooks = "";
            foreach (var book in books)
            {
                listOfSimilarBooks += book.Data.ToString() + "\n";
            }
            return listOfSimilarBooks;
        }

        public bool BorrowBook(int bookId, string bookIsbn, int readerId, string libraryName)
        {
            Book b = new Book(bookIsbn, bookId);
            AbstractNode<Library> l = _model.Libraries.SearchNode(new Library(libraryName), _model.Libraries.Root);

            Reader r = new Reader(readerId, "", "");
            var foundR = _model.ReadersById.SearchNode(r, _model.ReadersById.Root);

            AbstractNode<Book> foundB = l.Data.AllBooksByIsbn.SearchNode(b, l.Data.AllBooksByIsbn.Root);
            
            // check if can be borrowed

            // then borrow
            foundB.Data.Borrow(foundR.Data);

            return true;
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
                    _model.ReaderSession = new ReaderSession(found.Data);
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
                Reader r = new Reader(0, "", "");
                List<AbstractNode<Reader>> similarList = _model.ReadersById.SearchSimilar(r, _model.ReadersById.Root);
                string[] similar = new string[similarList.Count];
                for (int reader = 0; reader < similarList.Count; reader++)
                {
                    similar[reader] = similarList[reader].Data.ToString();
                }
                return similar;
            }

        }

        public string[] ShowBorrowedBooksCurrently(string readerId)
        {
            try
            {
                if (readerId != null || readerId != "")
                {
                    Reader r = new Reader(Convert.ToInt32(readerId), "", "");
                    AbstractNode<Reader> found = _model.ReadersById.SearchNode(r, _model.ReadersById.Root);
                    if (found == null)
                    {
                        return new string[] { };
                    }
                    else
                    {
                        _model.ReaderSession = new ReaderSession(found.Data);
                        return found.Data.BooksCurrentlyBorrowed.InorderTraversalToStringArray(found.Data.BooksCurrentlyBorrowed.Root);
                    }
                }
                return new string[] { };
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public string ShowBorrowedBooksCurrently(int readerId)
        {
            throw new NotImplementedException();
        }

        public string[] ShowAllLibraries()
        {
            return _model.Libraries.InorderTraversalToStringArray(_model.Libraries.Root);
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
            AbstractNode<Library> lib = _model.Libraries.SearchNode(new Library(libraryId), _model.Libraries.Root);
            Book knizka = new Book(author, title, genre, isbn);
            lib.Data.AllBooksByIsbn.Add(knizka);
            lib.Data.AllBooksByName.Add(knizka);
            return true;
        }

        public string[] ShowBorrowedBooksAfterReturnDate(string libraryId)
        {
            throw new NotImplementedException();
        }

        public bool ArchiveBook(string isbn)
        {
            throw new NotImplementedException();
        }

        public string[] ShowLateReturnedBooks(string readerId, DateTime fromTime, DateTime toTime)
        {
            Reader r = new Reader(Convert.ToInt32(readerId), "", "");
            var found = _model.ReadersById.SearchNode(r, _model.ReadersById.Root);
            if (found != null)
            {
                return new string[]{};
            }
            else
            {
                _model.ReaderSession = new ReaderSession(found.Data);
                return found.Data.LateBookReturns.InorderTraversalToStringArray(found.Data.LateBookReturns.Root);
            }
        }

        public string[] ShowBorrowedBooksPast(string readerId)
        {
            Reader r = new Reader(Convert.ToInt32(readerId), "", "");
            var found = _model.ReadersById.SearchNode(r, _model.ReadersById.Root);
            if (found == null)
            {
                return new string[] { };
            }
            else
            {
                _model.ReaderSession = new ReaderSession(found.Data);
                return found.Data.BooksBorrowedInPast.InorderTraversalToStringArray(found.Data.BooksBorrowedInPast.Root);
            }
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

        public string ShowAllBooks(string libraryName)
        {
            Library l = new Library(libraryName);
            AvlTreeNode<Library> lib = (AvlTreeNode<Library>) _model.Libraries.SearchNode(l, _model.Libraries.Root);
            if (lib != null && lib.Data.AllBooksByName != null)
            {
                return lib.Data.AllBooksByName.InorderTraversal(lib.Data.AllBooksByName.Root);
            }
            return "";
        }

        public string ShowAllBooks(int libraryId)
        {
            throw new NotImplementedException();
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
                    _model.ReaderSession = new ReaderSession(found.Data);
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
