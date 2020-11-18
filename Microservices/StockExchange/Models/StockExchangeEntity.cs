using System;
using System.Collections.Generic;

namespace StockExchange.Models
{
    public partial class StockExchangeEntity
    {
        public StockExchangeEntity()
        {
            CompanyEntity = new HashSet<CompanyEntity>();
        }

        public decimal Seid { get; set; }
        public string StockExchange { get; set; }
        public string Brief { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<CompanyEntity> CompanyEntity { get; set; }
    }
}
