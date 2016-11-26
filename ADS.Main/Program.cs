using System;
using System.Collections.Generic;
using ADS.ADS.Data.Library;
using ADS.ADS.DataStructures;
using ADS.ADS.Nodes;
using ADS.ADS.Services.DataProcessing;
using ADS.Core.Domain.Controller;
using ADS.Core.Domain.Model;

namespace ADS.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LibraryController ctrl = new LibraryController();
            //Console.WriteLine(ctrl.SearchBookByName("zz"));
            Console.WriteLine(LibraryModel.BooksByName.InorderTraversal(LibraryModel.BooksByName.Root));
        }
    }
}
