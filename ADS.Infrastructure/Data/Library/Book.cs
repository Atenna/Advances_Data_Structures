using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using ADS.ADS.Nodes;
using ADS.Services;

namespace ADS.ADS.Data.Library
{
    public enum Genres
    {
        Fiction, Comedy, Drama, Horror, Nonfiction, RealisticNovel, Satire, Tragedy, Tragicomedy, Fantasy, Poetry, Education, Health, Guide, Science, Dictionaries, Comics, Cookbooks, Travel, Romance, Encyclopedias, Art
    }

    public enum SubGenres
    {
        Classic, Crime, Fable, Fairytale, Folklore, Historical, Humor, Legend, Mystery, Mythology, Biography, Autobiography, Essay, Journalism, Memoir, ReferenceBook, SelfHelpBook, Speech, Textbook, EroticNovel, Saga, Religious, 
    }

    public class Book
    {

        public class BookNameComparator : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                //return string.Compare(x.Title, y.Title);
                if (x.Title == y.Title)
                {
                    if ( ( x.CodeIsbn != null && x.CodeIsbn != "" && y.CodeIsbn != null && y.CodeIsbn != "") )
                    {
                        if (x.CodeIsbn.Equals(y.CodeIsbn))
                        {
                            if (x.UniqueId == y.UniqueId)
                            {
                                return 0;
                            }
                            else if (x.UniqueId > y.UniqueId)
                            {
                                return 1;
                            }
                            else
                            {
                                return -1;
                            }
                        }
                        else
                        {
                            return string.Compare(x.CodeIsbn, y.CodeIsbn);
                        }
                    }
                    return 0;
                }
                else
                {
                    return string.Compare(x.Title, y.Title);
                }
            }
        }

        public class BookIsbnComparator : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                //return string.Compare(x.CodeIsbn, y.CodeIsbn);
                long xd= long.Parse(x.CodeIsbn.Replace("-", ""));
                long yd = long.Parse(y.CodeIsbn.Replace("-", ""));
                if ( xd > yd)
                {
                    return 1;
                }
                else if (xd < yd)
                {
                    return -1;
                }
                else if (xd == yd)
                {
                    if (x.UniqueId > y.UniqueId)
                    {
                        return 1;
                    } 
                    else if (x.UniqueId < y.UniqueId)
                    {
                        return -1;
                    }
                }
                return 0;
            }
        }

        public string Author { get; }
        public string Title { get; }
        public string CodeIsbn { get; set; }
        public string CodeEan { get; }
        public string GenreList { get; }
        public string Genre { get; }
        public Library CurrentLibrary { get; set; }
        public int StandardDaysForBorrow { get; set; }
        public DateTime? TimeOfBorrow { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        public int UniqueId { get; set; }
        public int FeePerDay { get; set; } // in cents
        public bool IsArchived { get; set; }
        public bool IsBorrowed { get; set; }
        public Reader CurrentReader { get; set; }

        public Book(string author, string title, string isbn, string ean, string genre, Library currentLibrary, int uniqueId)
        {
            Author = author;
            Title = title;
            CodeIsbn = isbn;
            CodeEan = ean;
            GenreList = genre;
            CurrentLibrary = currentLibrary;
            StandardDaysForBorrow = 30;
            UniqueId = uniqueId;
            FeePerDay = 100;
            IsArchived = false;
            IsBorrowed = false;

            CurrentLibrary?.AllBooksByIsbn.Add(this);
            CurrentLibrary?.AllBooksByName.Add(this);
        }

        public Book(string author, string title, string genre)
        {
            Author = author;
            Title = title;
            Genre = genre;
            UniqueId = 0;
            TimeOfBorrow = new DateTime(2015, 05, 26);
        }

        public Book(string author, string title, string genre, string isbn)
        {
            Author = author;
            Title = title;
            Genre = genre;
            CodeIsbn = isbn;
            UniqueId = 0;
            TimeOfBorrow = new DateTime(2015, 05, 26);
        }

        public Book(string isbn, int bookId, string bookName)
        {
            CodeIsbn = isbn;
            UniqueId = bookId;
            Title = bookName;
            TimeOfBorrow = new DateTime(2015, 05, 26);
        }

        public Book(string author, string title, string isbn, string ean, string genre, Library lib, int bookId, int fee, int borrowLength)
        {
            Author = author;
            Title = title;
            CodeIsbn = isbn;
            CodeEan = ean;
            Genre = genre;
            CurrentLibrary = lib;
            UniqueId = bookId;
            FeePerDay = fee;
            StandardDaysForBorrow = borrowLength;

            IsArchived = false;
            IsBorrowed = false;

            CurrentLibrary?.AllBooksByIsbn.Add(this);
            CurrentLibrary?.AllBooksByName.Add(this);
        }

        public override string ToString()
        {
            return Title + " : " + Author + ", " + CodeIsbn + ", " + UniqueId;
        }

        public string ToStringDetailed()
        {
            string returndate = TimeOfReturn != null
                ? TimeOfReturn.Value.Date.ToString("dd.MM.yyyy") + ","
                : "Not returned yet,";
            string borrowed = IsBorrowed ? "Borrowed to " + CurrentReader.Name +" "+ CurrentReader.Surname
                + ", \n\t" + TimeOfBorrow.Value.Date.ToString("dd.MM.yyyy") + " - " + returndate : "Available,";
            string archived = IsArchived ? "Archived" : "Not archived";
            return Title + " : " + Author + ",\n\tUnique id:" + UniqueId + ",\n\tISBN:" + CodeIsbn  + ",\n\tEAN:" 
                + CodeEan + ",\n\t" + borrowed + "\n\t" + archived + "\n\t" + "Current library: " + CurrentLibrary?.NameOfLibrary;
        }

        public string ToStringSave()
        {
            string returndate = TimeOfReturn != null
                ? TimeOfReturn.Value.Date.ToString("dd.MM.yyyy") + ","
                : ",";
            string borrowed = IsBorrowed ? CurrentReader.Name + "," + CurrentReader.Surname
                + "," + CurrentReader.UniqueId + ","+ TimeOfBorrow.Value.Date.ToString("dd.MM.yyyy") + "," + returndate : ",,,,,";
            string archived = IsArchived ? "true" : "false";
            return Title + "," + Author + "," + UniqueId + "," + CodeIsbn + ","
                + CodeEan + "," + borrowed + "," + archived + "," + CurrentLibrary?.NameOfLibrary;
        }

        public string FormatIsbn(string isbn)
        {
            // kazde tri znaky pomlcka
            return isbn;
        }

        public bool Borrow(Reader r)
        {
            if (IsBorrowed || r.HasBlockedBorrowing || IsArchived)
            {
                return false;
            }
            IsBorrowed = true;
            CurrentReader = r;
            TimeOfBorrow = DateTime.Now;
            r.BooksCurrentlyBorrowed.Add(this);
            CurrentLibrary.BorrowedBooks.Add(this);
            return true;
        }

        public bool Borrow(Reader r, DateTime timeOfBorrow)
        {
            if (IsBorrowed || r.HasBlockedBorrowing || IsArchived)
            {
                return false;
            }
            IsBorrowed = true;
            CurrentReader = r;
            TimeOfBorrow = timeOfBorrow;
            r.BooksCurrentlyBorrowed.Add(this);
            CurrentLibrary.BorrowedBooks.Add(this);
            return true;
        }

        public void Return(Library l, Reader r)
        {
            CurrentLibrary.BorrowedBooks.RemoveNode(Copy());

            if (!CurrentLibrary.NameOfLibrary.Equals(l.NameOfLibrary))
            {
                CurrentLibrary.AllBooksByName.RemoveNode(Copy());
                CurrentLibrary.AllBooksByIsbn.RemoveNode(Copy());
            }

            IsBorrowed = false;
            TimeOfReturn = DateTime.Now;
            r.BooksCurrentlyBorrowed.RemoveNode(Copy());
            CurrentReader = null;
            CurrentLibrary = l;
            l.AllBooksByIsbn.Add(this);
            l.AllBooksByName.Add(this);
            r.BooksBorrowedInPast.Add(new Borrowing(Copy(), r));
            TimeOfBorrow = null;
        }

        public void Return(Library l, Reader r, DateTime timeOfReturn)
        {
            if (DateTime.Now >= timeOfReturn){
                CurrentLibrary.BorrowedBooks.RemoveNode(Copy());

                if (!CurrentLibrary.NameOfLibrary.Equals(l.NameOfLibrary))
                {
                    CurrentLibrary.AllBooksByName.RemoveNode(Copy());
                    CurrentLibrary.AllBooksByIsbn.RemoveNode(Copy());
                }

                IsBorrowed = false;
                TimeOfReturn = timeOfReturn;
                CurrentReader = null;
                CurrentLibrary = l;
                r.BooksBorrowedInPast.Add(new Borrowing(Copy(), r));

                l.AllBooksByIsbn.Add(this);
                l.AllBooksByName.Add(this);
                
                r.BooksCurrentlyBorrowed.RemoveNode(Copy());
                TimeOfBorrow = null;
            }
        }

        public class BookUniqueIdComparer : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                if (x.UniqueId > y.UniqueId)
                {
                    return 1;
                } else if (x.UniqueId < y.UniqueId)
                {
                    return -1;
                }
                return 0;
            }
        }

        public Book Copy()
        {
            Book b = new Book(Author, Title, CodeIsbn, CodeEan, Genre, CurrentLibrary, UniqueId);
            b.CurrentReader = CurrentReader;
            b.FeePerDay = FeePerDay;
            b.IsArchived = IsArchived;
            b.IsBorrowed = IsBorrowed;
            b.TimeOfBorrow = TimeOfBorrow;
            b.TimeOfReturn = TimeOfReturn;
            b.StandardDaysForBorrow = StandardDaysForBorrow;
            return b;
        }
    }
}
