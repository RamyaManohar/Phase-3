using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SectorInfo.Models;

namespace SectorInfo.Repository
{
    public class SectorRepository : SectorInterface
    {
        public StockMarketDBContext db = new StockMarketDBContext();

        public decimal FromToPrice(string sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
          
    
            decimal d = 0;
            List<decimal> l = db.CompanyEntities.Where(i => i.Sector == sectorname).Select(e => e.CompanyStockCode).ToList();
            for (int i = 0; i < l.Count(); i++)
                d = d + db.StockPriceEntities.Where(j => j.CompanyStockCode == l[i] && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).FirstOrDefault();
            return d / l.Count;

        }

        public List<decimal> FromToPriceList(string sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> d = new List<decimal>();
            List<decimal> l = db.CompanyEntities.Where(i => i.Sector == sectorname).Select(e => e.CompanyStockCode).ToList();
            for (int i = 0; i < l.Count(); i++)
                d.Add(db.StockPriceEntities.Where(j => j.CompanyStockCode == l[i] && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).FirstOrDefault());
            return d;
        }

        public List<CompanyEntity> getList(string SecName)
        {
            List<CompanyEntity> l = db.CompanyEntities.Where(x => x.Sector == SecName).ToList();
            return l;
        }

        public decimal GetSectorPrice(string SecName)
        {
            decimal d = 0;
            List<decimal> l = db.CompanyEntities.Where(i => i.Sector == SecName).Select(j => j.CompanyStockCode).ToList();
            for (int i = 0; i < l.Count(); i++)
                d = d + db.StockPriceEntities.Where(j => j.CompanyStockCode == l[i]).Select(e => e.CurrentPrice).FirstOrDefault();
            return d / l.Count;
        }

        
    }
}

