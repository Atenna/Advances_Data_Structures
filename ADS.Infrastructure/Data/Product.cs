using ADS.ADS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.ADS.Data
{
    public class Product : IData<Product>
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
    }
}
