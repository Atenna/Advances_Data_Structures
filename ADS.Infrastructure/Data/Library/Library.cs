using System;

namespace ADS.ADS.Data.Library
{
    public class Library : IData<Library>
    {
        public string NameOfLibrary {get; private set; }

        public Library(string name)
        {
            NameOfLibrary = name;
        }
        public int CompareTo(Library other)
        {
            throw new NotImplementedException();
        }
    }
}
