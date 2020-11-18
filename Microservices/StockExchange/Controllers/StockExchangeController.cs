using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Models;
using StockExchange.Repository;

namespace StockExchange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockExchangeController : ControllerBase
    {
        public StockExchangeRepository _repo = new StockExchangeRepository();

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<StockExchangeEntity> l = _repo.getall();
            return Ok(l);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddSE(StockExchangeEntity s)
        {
            _repo.addStockExchange(s);
            return Ok("Stock Exchange added");
        }

        [HttpGet]
        [Route("getcompany/{name}")]
        public IActionResult getCompanies(string name)
        {
            List<CompanyEntity> l = _repo.getCompanies(name);
            return Ok(l);
        }

    }
}
