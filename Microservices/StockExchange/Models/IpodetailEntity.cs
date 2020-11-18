using System;
using System.Collections.Generic;

namespace StockExchange.Models
{
    public partial class IpodetailEntity
    {
        public decimal Id { get; set; }
        public string CompanyName { get; set; }
        public string StockExchange { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNoOfShares { get; set; }
        public DateTime OpenDateTime { get; set; }
        public string Remarks { get; set; }
    }
}
