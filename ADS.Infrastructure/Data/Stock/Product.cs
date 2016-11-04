using System;

namespace ADS.ADS.Data.Stock
{
    public class Product : IData<Product>, IComparable<Product>
    {
        public string Name { get; set; }
        public string DateLatestUsage { get; set; }
        public DateTime DateStartExport { get; set; }
        public DateTime DateExpectedEndExport { get; set; }
        public string ProductId { get; set; }
        public int CarId { get; set; }
        public string OriginStockId { get; set; }
        public string TargetStockId { get; set; }

        public int CompareTo(Product other)
        {
            throw new NotImplementedException();
        }

        public int Compare(Product x, Product y)
        {
            throw new NotImplementedException();
        }
    }
}
