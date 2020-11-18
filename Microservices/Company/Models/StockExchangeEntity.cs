using System;
using System.Collections.Generic;

#nullable disable

namespace Company.Models
{
    public partial class StockExchangeEntity
    {
        public StockExchangeEntity()
        {
            CompanyEntities = new HashSet<CompanyEntity>();
        }

        public decimal Seid { get; set; }
        public string StockExchange { get; set; }
        public string Brief { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<CompanyEntity> CompanyEntities { get; set; }
    }
}
