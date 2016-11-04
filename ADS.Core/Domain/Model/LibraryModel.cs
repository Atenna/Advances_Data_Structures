using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.ADS.Services.DataProcessing;

namespace ADS.Core.Domain.Model
{
    public class LibraryModel
    {
        public LibraryModel()
        {
            BooksByName = new AvlTree<Book>(new Book.BookNameComparator());
            BooksByName = DataParser.FillDataStructure(BooksByName);
            //Libraries = libraries;
            //BooksByIsbn = booksByIsbn;
            //Readers = readers;
        }

        public AvlTree<Library> Libraries { get; }
        public AvlTree<Book> BooksByName { get; }
        public AvlTree<Book> BooksByIsbn { get; }
        public AvlTree<Reader> Readers { get; }
    }
}
