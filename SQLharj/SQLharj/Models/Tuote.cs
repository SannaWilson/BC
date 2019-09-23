using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLharj.Models
{
    public class Tuote
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; } 
        public string LAAKENIMI { get; set; }
        public string ATCKOODI { get; set; }
    }
}
