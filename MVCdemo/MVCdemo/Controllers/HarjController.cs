using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCdemo.Controllers
{
    public class HarjController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hei {name}, osoiterivissa on numero: {numTimes}");
        }
    }
}