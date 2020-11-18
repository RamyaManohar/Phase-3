using System;
using System.Collections.Generic;

namespace StockExchange.Models
{
    public partial class CompanyEntity
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public decimal Turnover { get; set; }
        public string Ceo { get; set; }
        public string BoardOfDirectors { get; set; }
        public decimal ListedinStockExchange { get; set; }
        public string Sector { get; set; }
        public string BriefWriteup { get; set; }
        public decimal CompanyStockCode { get; set; }

        public virtual StockExchangeEntity ListedinStockExchangeNavigation { get; set; }
    }
}
