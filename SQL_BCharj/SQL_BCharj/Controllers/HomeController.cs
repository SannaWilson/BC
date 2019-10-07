using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SQL_BCharj.Models;

namespace SQL_BCharj.Controllers
{
    public class HomeController : Controller
    {
        private void LinqTesti()
        {
            int[] luvut = { 1,2,3,4,5,6,1,22,6};

            List<int> suuret = (from l in luvut
                                where l > 5
                                orderby l
                                select l).ToList();

            ViewBag.Luvut = suuret;

            //foreach (int suuri in suuret)
            //{
            //    Console.WriteLine(suuri);
            //}

        }
        public IActionResult Index()
        { 
            // Asiakkaiden lukumäärä
            NorthwindContext context = new NorthwindContext();
            int lkm = context.Customers.Count();

            ViewBag.AsiakkaidenLkm = lkm;

            //koko listaus mahdollista tehdä näin suoraan muistiin "ToList", koska tiedetään, että asaikkaiden määrä on varsin pieni (91)
            List<Customers> asiakkaat = context.Customers.ToList();
            ViewBag.KaikkiAsiakkaat = asiakkaat;

            //Suomalaiset asiakkaat (c on uusi muuttuja, joka tässä tapauksessa tarkoittaa käytännössä asiakastaulukon riviä
            List<Customers> suomalaiset = (from c in context.Customers
                                            where c.Country == "Finland"
                                            select c).ToList();
            ViewBag.KaikkiAsiakkaat = suomalaiset;

            List<Customers> suomalaiset2 =
                context.Customers.Where(c => c.Country == "Finland").ToList();

            LinqTesti();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
