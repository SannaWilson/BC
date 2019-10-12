using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyDB.Models;

namespace MyDB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*NorthwindContext context = new NorthwindContext();
            int lkm = context.Customers.Count();

            ViewBag.AsiakkaidenLkm = lkm;*/

            ImportContext malli = new ImportContext();
            int lkm = malli.Pakkaus0.Count();

            ViewBag.PakkaustenLkm = lkm;

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
