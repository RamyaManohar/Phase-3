
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SectorInfo.Models;


namespace SectorInfo.Repository
{
    public interface SectorInterface
    {
        public List<CompanyEntity> getList(string sec);
        public decimal GetSectorPrice(string SecName);
        public decimal FromToPrice(String sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);
        public List<decimal> FromToPriceList(string sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);


    }
}
