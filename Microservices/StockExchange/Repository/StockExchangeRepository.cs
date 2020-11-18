using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Models;


namespace StockExchange.Repository
{
    public class StockExchangeRepository : StockExchangeInterface
    {
        public StockMarketDBContext db = new StockMarketDBContext();
        public void addStockExchange(StockExchangeEntity s)
        {
            db.StockExchangeEntity.Add(s);
            db.SaveChanges();
        }

        public List<StockExchangeEntity> getall()
        {
            return db.StockExchangeEntity.ToList();
        }
        public List<CompanyEntity> getCompanies(string SEName)
        {
            var Sid = db.StockExchangeEntity.Where(i => i.StockExchange == SEName).Select(j => j.Seid).FirstOrDefault();
            List<CompanyEntity> l = db.CompanyEntity.Where(x => x.ListedinStockExchange == Sid).ToList();
            return l;
        }
    }
}
