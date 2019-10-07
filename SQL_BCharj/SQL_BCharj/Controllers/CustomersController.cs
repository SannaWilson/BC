using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SQL_BCharj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auto
    {
        public string Väri { get; set; }
        public int Huippunopeus { get; set; }
    }

    public class CustomersController : ControllerBase
    {
        [Route("")] // Periaatteessa tarpeeton; koodin selkeyden vuoksi hyvä olla 
        public int Oletus()
        {
            return 123;
        }
        [Route("table")]
        public int[] Luvut()
        {
            int[] luvut = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return luvut;
        }
        [Route("1")] 
        public string Tervehdys()
        {
            return "Moikka!";
        }
        [Route("2")]
        public string Tervehdys2()
        {
            return "Hei!";
        }
        // Etherpadistä kopioidut "testi"-metodit
        [Route("testi1")]
        public int Luku()
        {
            return 12345;
        }

        [Route("testi2")]
        public int[] Numerot()
        {
            int[] luvut = { 1, 2, 3, 4, 5 };
            return luvut;
        }

        [Route("testi3")]
        public bool Boolean()
        {
            return true;
        }

        [Route("testi4")]
        public Auto Luokka()
        {
            Auto a = new Auto();
            a.Väri = "Keltainen";
            a.Huippunopeus = 245;
            return a;
        }
    }
}