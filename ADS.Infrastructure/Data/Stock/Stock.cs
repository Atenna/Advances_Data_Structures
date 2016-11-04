using System;
using ADS.ADS.DataStructures;

namespace ADS.ADS.Data.Stock
{
    public class Stock : IData<Stock>
    {
        public string StockId { get; set; }
        public BinarySearchTree<Product> Products;

        public Stock()
        {
            Products =  new BinarySearchTree<Product>(null);
            StockId = "blabla";
        }

        public int CompareTo(Stock other)
        {
            throw new NotImplementedException();
        }

        public int Compare(Stock x, Stock y)
        {
            throw new NotImplementedException();
        }
    }
}
