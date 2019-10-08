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
        public List<Customers> ListaaKaikki()
        {
            NorthwindContext malli = new NorthwindContext();
            List<Customers> kaikki = malli.Customers.ToList();
            return kaikki;
        }
       
        [HttpGet]
        [Route("{id}")]
        public Customers NäytäYksi(string id)
        {
            NorthwindContext context = new NorthwindContext();
            Customers asiakas = (from c in context.Customers
                                 where c.CustomerId == id
                                 select c).FirstOrDefault();

            //Customers asiakas2 = context.Customers.Find(id); 
            return asiakas;
        }

        [HttpPost]
        [Route("")]
        public bool LisääUusi(Customers uusi)
        {
            NorthwindContext malli2 = new NorthwindContext();
            malli2.Customers.Add(uusi);

            malli2.SaveChanges();
            return true;
        }

        [HttpDelete]
        [Route("")]
        public bool PoistaAsiakkaat()
        {
            return false;
        }
    }
}