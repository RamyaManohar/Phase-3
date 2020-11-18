using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Models;

namespace Company.Repository
{
    public interface CompanyInterface
    {
        public IpodetailEntity getCompanyIPOdetails(decimal Stockcode);
        public CompanyEntity getCompanyDetails(decimal Stockcode);
        public decimal GetCompanyStockPrice(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);
        public List<decimal> GetCompanyStockPriceList(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);
        public void addCompany(CompanyEntity c);
        public void updateCompany(CompanyEntity c);
        public void addIPO(IpodetailEntity I);
        public List<IpodetailEntity> getallipo();



    }
}
