using System;
using System.ComponentModel.DataAnnotations;

namespace SQLharj.Models.ProductViewModels
{
    public class ATCGroup
    {
        [DataType(DataType.Text)]
        public string Tuote { get; set; }

        public int TuoteCount { get; set; }
    }
}