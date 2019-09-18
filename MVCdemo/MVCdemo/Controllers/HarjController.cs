using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCdemo.Controllers
{
    public class HarjController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}