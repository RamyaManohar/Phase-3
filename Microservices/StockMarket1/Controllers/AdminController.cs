using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket1.Models;
using StockMarket1.Repository.Admin;

namespace StockMarket1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public AdminRepository _repo = new AdminRepository();

        [HttpPost]
        [Route("add")]
        public IActionResult Admincreate(UserEntity user)
        {
            _repo.create(user);
            return Ok("Admin Added");
        }

        [HttpPost]
        [Route("check")]
        public IActionResult Admincheck(UserEntity user)
        {
            bool ans = _repo.check(user);
            if (ans == true)
                return Ok("Admin logged in");
            return Ok("No Access");
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult Getall()
        {
            List<UserEntity> l = _repo.getall();
            return Ok(l);
        }

    }
}
