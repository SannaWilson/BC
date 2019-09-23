using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations

namespace MVCdemo.Models
{
    public class Products
    {
        public int PAKKAUSNRO { get; set; }
        public string LAAKENIMI { get; set; }
        public string ATCKOODI { get; set; }
    }
}
