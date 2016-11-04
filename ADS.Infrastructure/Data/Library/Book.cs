using System;
using System.Collections;
using System.Collections.Generic;
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
                return string.Compare(x.Title, y.Title);
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
                return 0;
            }
        }

        public string Author { get; }
        public string Title { get; }
        public string CodeIsbn { get; }
        public string CodeEan { get; }
        public Genres[] GenreList { get; }
        public string Genre { get; }
        public Library CurrentLibrary { get; set; }
        public int StandardDaysForBorrow { get; }
        public DateTime TimeOfBorrow { get; }
        public DateTime TimeOfReturn { get; }
        public int UniqueId { get; }
        public int FeePerDay { get; } // in cents
        public bool IsArchived { get; }

        public Book(string author, string title, string isbn, string ean, Genres[] genre, Library currentLibrary, 
            int standardDaysForBorrow, DateTime borrowTime, DateTime returnTime, int uniqueId, int feePerDay)
        {
            Author = author;
            Title = title;
            CodeIsbn = isbn;
            CodeEan = ean;
            GenreList = genre;
            CurrentLibrary = currentLibrary;
            StandardDaysForBorrow = standardDaysForBorrow;
            TimeOfBorrow = borrowTime;
            TimeOfReturn = returnTime;
            UniqueId = uniqueId;
            FeePerDay = feePerDay;
            IsArchived = false;
        }

        public Book(string author, string title, string genre)
        {
            Author = author;
            Title = title;
            Genre = genre;
        }

        public Book(string author, string title, string genre, string isbn)
        {
            Author = author;
            Title = title;
            Genre = genre;
            CodeIsbn = isbn;
        }

        public override string ToString()
        {
            return Title + "\n";
        }
    }
}
