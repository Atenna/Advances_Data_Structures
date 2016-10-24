using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.ADS.DataStructures;

namespace ADS.ADS.Data
{
    public class Stock : IData<Stock>
    {
        public string StockId { get; set; }
        public BinarySearchTree<Product> Products;

        public Stock()
        {
            Products =  new BinarySearchTree<Product>();
            StockId = "blabla";
        }

        public int CompareTo(Stock other)
        {
            throw new NotImplementedException();
        }
    }
}
