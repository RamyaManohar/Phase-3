using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Models;

namespace Company.Repository
{
    public class CompanyRepository : CompanyInterface
    {
        public StockMarketDBContext db = new StockMarketDBContext();

        public void addCompany(CompanyEntity c)
        {
            db.CompanyEntities.Add(c);
            db.SaveChanges();
             
        }

        public void addIPO(IpodetailEntity I)
        {
            db.IpodetailEntities.Add(I);
            db.SaveChanges();
        }

        public CompanyEntity getCompanyDetails(decimal Stockcode)
        {
            CompanyEntity i = db.CompanyEntities.FirstOrDefault(i => i.CompanyStockCode == Stockcode);
            return i;
        }
        
        public IpodetailEntity getCompanyIPOdetails(decimal Stockcode)
        {
            IpodetailEntity i = db.IpodetailEntities.Find(Stockcode);
            return i;
        }

        public decimal GetCompanyStockPrice(decimal StockCode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> d;
            d = db.StockPriceEntities.Where(j => j.CompanyStockCode == StockCode && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).ToList();
            decimal c = d.Average();
            return c;
        }

        public void updateCompany(CompanyEntity c)
        {
            db.CompanyEntities.Update(c);
            db.SaveChanges();
        }
        public List<IpodetailEntity> getallipo()
        {
            return db.IpodetailEntities.ToList();
        }

        public List<decimal> GetCompanyStockPriceList(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> d;
            d = db.StockPriceEntities.Where(j => j.CompanyStockCode == Stockcode && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).ToList();
            
            return d;
        }
    }
}
