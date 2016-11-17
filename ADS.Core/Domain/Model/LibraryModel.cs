using System;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.ADS.Services.DataProcessing;
using ADS.Core.Domain.Controller;

namespace ADS.Core.Domain.Model
{
    public class LibraryModel
    {
        public LibraryModel()
        {
            _maxReaderId = 6000;
            BooksByName = new AvlTree<Book>(new Book.BookNameComparator());
            BooksByName = DataParser.FillDataStructure(BooksByName);

            //Libraries = libraries;
            BooksByIsbn = new AvlTree<Book>(new Book.BookIsbnComparator());
            BooksByIsbn = DataParser.FillDataStructure(BooksByIsbn);
            ReadersByName = new AvlTree<Reader>(new Reader.ReaderNameComparator());

            ReadersByName = DataParser.FillReadersByName(ReadersByName);
            ReadersByName.Add(new Reader(157785, "barbora", "kasmanova"));
            ReadersByName.Add(new Reader(157787, "michal", "mruskovic"));
            ReadersByName.Add(new Reader(8557035, "martina", "bolibruchova"));
            ReadersByName.Add(new Reader(6778551, "andreas", "benz"));
            Reader strasiak = new Reader(342256, "peter", "gasiak");
            
            ReadersByName.Add(new Reader(44370989, "andreas", "benz"));
            ReadersByName.Add(new Reader(345522, "marian", "mojzis"));
            ReadersByName.Add(new Reader(345522, "raphael", "hiesgen"));
            ReadersByName.Add(new Reader(127785, "andrea", "kasmanova"));
            ReadersByName.Add(new Reader(127787, "martin", "mruskovic"));
            ReadersByName.Add(new Reader(8257035, "andrea", "bolibruchova"));
            ReadersByName.Add(new Reader(6278551, "andreas", "benz"));
            ReadersByName.Add(new Reader(322256, "alex", "gasiak"));
            ReadersByName.Add(new Reader(42370989, "rene", "benz"));
            ReadersByName.Add(new Reader(325522, "michal", "mojzis"));
            ReadersByName.Add(new Reader(325522, "sebastian", "hiesgen"));
            ReadersByName.Add(new Reader(167785, "michala", "kassova"));
            ReadersByName.Add(new Reader(167787, "michal", "mruskovic"));
            ReadersByName.Add(new Reader(8657035, "martina", "bobokova"));
            ReadersByName.Add(new Reader(6678551, "andreas", "berkeley"));
            ReadersByName.Add(new Reader(362256, "peter", "gallo"));
            ReadersByName.Add(new Reader(46370989, "francois", "borat"));
            ReadersByName.Add(new Reader(365522, "milan", "mojzis"));
            ReadersByName.Add(new Reader(365522, "raphael", "hiesgen"));

            ReadersById = new AvlTree<Reader>(new Reader.ReaderIdComparator());
            ReadersById = DataParser.FillReadersByName(ReadersById);
            ReadersById.Add(new Reader(157785, "barbora", "kasmanova"));
            ReadersById.Add(new Reader(157787, "michal", "mruskovic"));
            ReadersById.Add(new Reader(8557035, "martina", "bolibruchova"));
            ReadersById.Add(new Reader(6778551, "andreas", "benz"));
            //ReadersById.Add(new Reader(342256, "peter", "gasiak"));
            ReadersById.Add(new Reader(44370989, "andreas", "benz"));
            ReadersById.Add(new Reader(345522, "marian", "mojzis"));
            ReadersById.Add(new Reader(345522, "raphael", "hiesgen"));
            ReadersById.Add(new Reader(127785, "andrea", "kasmanova"));
            ReadersById.Add(new Reader(127787, "martin", "mruskovic"));
            ReadersById.Add(new Reader(8257035, "andrea", "bolibruchova"));
            ReadersById.Add(new Reader(6278551, "andreas", "benz"));
            ReadersById.Add(new Reader(322256, "alex", "gasiak"));
            ReadersById.Add(new Reader(42370989, "rene", "benz"));
            ReadersById.Add(new Reader(325522, "michal", "mojzis"));
            ReadersById.Add(new Reader(325522, "sebastian", "hiesgen"));
            ReadersById.Add(new Reader(167785, "michala", "kassova"));
            ReadersById.Add(new Reader(167787, "michal", "mruskovic"));
            ReadersById.Add(new Reader(8657035, "martina", "bobokova"));
            ReadersById.Add(new Reader(6678551, "andreas", "berkeley"));
            ReadersById.Add(new Reader(362256, "peter", "gallo"));
            ReadersById.Add(new Reader(46370989, "francois", "borat"));
            ReadersById.Add(new Reader(365522, "milan", "mojzis"));
            ReadersById.Add(new Reader(365522, "raphael", "hiesgen"));

            Libraries= new AvlTree<Library>(new Library.LibraryNameComparator());
            Library lib1 = new Library("Library 1");
            Library lib2 = new Library("Library 2");
            Library lib3 = new Library("Library 3");

            Book b1 = new Book("Ernst Hemingway", "Sto rokov samoty", "drama", "123456789");
            Book b2 = new Book("Aneta Langerova", "Mala morska vila", "rozpravka", "123456786");
            Book b3 = new Book("Vaclav Kadlec", "Ucime se programovat v Delphi", "ucebnica", "128456789");
            Book b4 = new Book("Jiri Herout", "Jazyk C", "ucebnica", "18766789");
            Book b5 = new Book("Ernst Hemingway", "Cesta okolo sveta za 80 dni", "dobrodruzna proza", "576456789");
            Book b6 = new Book("Paolo Coelho", "Brida", "beletria", "654442339");
            Book b7 = new Book("Antoine de Saint Exupery", "Citadela", "autobiografia", "12298006");
            Book b8 = new Book("Joseph Heller", "Hlava XXII", "historicky roman", "3442111");
            Book b9 = new Book("Natasa Tanska", "Stuky a stucky", "kniha pre dievcata", "98845322");
            Book b10 = new Book("Antoine de Saint Exupery", "Maly princ", "rozpravka pre dospelych", "766634424");
            Book b11 = new Book("marliese Aroldova", "Lahka ako vtak", "drama, autobiografia", "9988866676");
            Book b12 = new Book("Paula Hawkins", "Dievca vo vlaku", "drama", "34458776");


            strasiak.BooksCurrentlyBorrowed.Add(b1);
            strasiak.BooksCurrentlyBorrowed.Add(b2);
            strasiak.BooksCurrentlyBorrowed.Add(b3);
            strasiak.BooksCurrentlyBorrowed.Add(b6);
            strasiak.BooksCurrentlyBorrowed.Add(b8);

            strasiak.BooksBorrowedInPast.Add(b11);
            strasiak.BooksBorrowedInPast.Add(b2);
            strasiak.BooksBorrowedInPast.Add(b12);
            strasiak.BooksBorrowedInPast.Add(b9);
            strasiak.BooksBorrowedInPast.Add(b4);

            ReadersByName.Add(strasiak);
            ReadersById.Add(strasiak);

            lib1.AllBooksByName.Add(b1);
            lib1.AllBooksByName.Add(b3);
            lib1.AllBooksByName.Add(b5);
            lib1.AllBooksByName.Add(b7);
            lib1.AllBooksByName.Add(b12);
            lib1.AllBooksByIsbn.Add(b1);
            lib1.AllBooksByIsbn.Add(b3);
            lib1.AllBooksByIsbn.Add(b5);
            lib1.AllBooksByIsbn.Add(b7);
            lib1.AllBooksByIsbn.Add(b12);
            //lib1.AllBooksByName = BooksByName;
            Libraries.Add(lib1);

            lib2.AllBooksByName.Add(b2);
            lib2.AllBooksByName.Add(b8);
            lib2.AllBooksByName.Add(b3);
            lib2.AllBooksByName.Add(b4);
            lib2.AllBooksByName.Add(b5);
            lib2.AllBooksByName.Add(b12);
            lib2.AllBooksByName.Add(b9);
            lib2.AllBooksByName.Add(b11);
            lib2.AllBooksByIsbn.Add(b2);
            lib2.AllBooksByIsbn.Add(b8);
            lib2.AllBooksByIsbn.Add(b3);
            lib2.AllBooksByIsbn.Add(b4);
            lib2.AllBooksByIsbn.Add(b5);
            lib2.AllBooksByIsbn.Add(b12);
            lib2.AllBooksByIsbn.Add(b9);
            lib2.AllBooksByIsbn.Add(b11);
            Libraries.Add(lib2);

            lib3.AllBooksByName.Add(b4);
            lib3.AllBooksByName.Add(b1);
            lib3.AllBooksByName.Add(b7);
            lib3.AllBooksByName.Add(b8);
            lib3.AllBooksByName.Add(b9);
            lib3.AllBooksByName.Add(b6);
            lib3.AllBooksByName.Add(b2);
            lib3.AllBooksByIsbn.Add(b4);
            lib3.AllBooksByIsbn.Add(b1);
            lib3.AllBooksByIsbn.Add(b7);
            lib3.AllBooksByIsbn.Add(b8);
            lib3.AllBooksByIsbn.Add(b9);
            lib3.AllBooksByIsbn.Add(b6);
            lib3.AllBooksByIsbn.Add(b2);
            Libraries.Add(lib3);

            Libraries.Add(new Library("Library 6"));
            Libraries.Add(new Library("Library 8"));
            Libraries.Add(new Library("Library 7"));
            Libraries.Add(new Library("Library 9"));
            Libraries.Add(new Library("Library 5"));
            Libraries.Add(new Library("Library 4"));
            Libraries.Add(new Library("Library 12"));
            Libraries.Add(new Library("Library 11"));
            Libraries.Add(new Library("Library 10"));
        }

        public AvlTree<Library> Libraries { get; }
        public AvlTree<Book> BooksByName { get; }
        public AvlTree<Book> BooksByIsbn { get; }
        public AvlTree<Reader> ReadersById { get; }

        public ReaderSession ReaderSession { get; set; }
        public AvlTree<Reader> ReadersByName { get; }
        private int _maxReaderId;

        public int NewReaderId()
        {
            return _maxReaderId++;
        }
    }
}
