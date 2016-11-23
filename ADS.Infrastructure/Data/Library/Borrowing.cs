using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.ADS.Data.Library
{
    class Borrowing
    {
        public Reader Reader { get; }
        public Book Book { get; set; }

        public DateTime DateOfBorrow { get; set; }
        public DateTime DateOfReturn { get; set; }
        public DateTime DateOfProlong { get; set; }
        public int Fee { get; set; }
        public bool FeeToPay { get; set; }
        public bool FeePaid { get; set; }
    }
}
