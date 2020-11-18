using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Company.Models;
using Company.Repository;

namespace Company.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public CompanyRepository _repo = new CompanyRepository();
        [HttpGet]
        [Route("getIPO/{Stockcode}")]
        public IActionResult getIPOdetails(decimal Stockcode)
        {
            IpodetailEntity l = _repo.getCompanyIPOdetails(Stockcode);
            return Ok(l);
        }
        [HttpGet]
        [Route("getcomp/{Stockcode}")]
        public IActionResult GetCompanyDetails(decimal Stockcode)
        {
            CompanyEntity l = _repo.getCompanyDetails(Stockcode);
            return Ok(l);
        }
        [HttpGet]
        [Route("getCompanyPrice/{Stockcode}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult getCompanyPrice(decimal StockCode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            decimal d = _repo.GetCompanyStockPrice(StockCode, d1, d2, t1, t2);
            return Ok(d);
        }
        [HttpPost]
        [Route("addcompany")]
        public IActionResult AddCompany(CompanyEntity c)
        {
            _repo.addCompany(c);
             return Ok("Company Added");
        }

        [HttpPut]
        [Route("updatecompany")]
        public IActionResult UpdateCompany(CompanyEntity c)
        {
            _repo.updateCompany(c);
            return Ok("Company Updated");
        }

        [HttpPost]
        [Route("addipo")]
        public IActionResult AddIPO(IpodetailEntity I)
        {
            _repo.addIPO(I);
            return Ok("IPO details Added");
        }

        [HttpGet]
        [Route("getallipo")]
        public IActionResult GetAllIPO()
        {
            List<IpodetailEntity> l = _repo.getallipo();
            return Ok(l);
        }
        [HttpGet]
        [Route("getCompanyPriceList/{Stockcode}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult getCompanyPriceList(decimal StockCode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
           List<decimal> d = _repo.GetCompanyStockPriceList(StockCode, d1, d2, t1, t2);
            return Ok(d);
        }



    }
}
