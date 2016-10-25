using System;
using ADS.Services;

namespace ADS.ADS.Data.Library
{
    public enum Genres
    {
        
    }

    public class Book : IData<Book>
    {
        public string Author;
        public string Title;
        public string CodeIsbn;
        public string CodeEan;
        public Genres[] GenreList;
        public Time TimeStandardBorrow;
        public Time TimeOfBorrow;
        public Time TimeToReturn;
        public int UniqueId;
        public int Fee;

        public Book()
        {
            
        }

        public int CompareTo(Book other)
        {
            throw new NotImplementedException();
        }
    }
}
