using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using ADS.ADS.Data.Library;

namespace ADS.ADS.Services.DataProcessing
{
    public class DataGenerator
    {
        private static int _counter;
        private static Random rndName;
        private static Random rndSurname;
        private static List<string> _listOfNames;
        private static List<string> _listOfSurnames;

        public DataGenerator()
        {
            _counter = 0;
            rndName = new Random();
            rndSurname = new Random();
            _listOfNames = new List<string>();
            _listOfSurnames = new List<string>();
            ReadNamesFromFile("names.txt");
            ReadSurnamesFromFile("surnames.txt");
        }
        public Reader GenerateReader()
        {
            int n = rndName.Next(_listOfNames.Count);
            int s = rndSurname.Next(_listOfSurnames.Count);
            string surname = _listOfSurnames[s];
            string name = _listOfNames[n];
            return new Reader(_counter, name, surname);
        }

        private static void ReadNamesFromFile(string file)
        {
            StreamReader r = new StreamReader(file);
            string line;
            while ((line = r.ReadLine())!= null)
            {
                _listOfNames.Add(line);
            }
        }

        private static void ReadSurnamesFromFile(string file)
        {
            StreamReader r = new StreamReader(file);
            string line;
            while ((line = r.ReadLine()) != null)
            {
                _listOfSurnames.Add(line);
            }
        }
    }
}
