using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL_BCharj.Models;

namespace SQL_BCharj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Customers> ListaaKaikki()
        {
            NorthwindContext ohjain = new NorthwindContext();
            List<Customers> kaikki = ohjain.Customers.ToList();
            return kaikki;
        }
        [Route("")]
        [HttpDelete]
        public bool PoistaAsiakkaat()
        {
            return false;
        }
    }
}