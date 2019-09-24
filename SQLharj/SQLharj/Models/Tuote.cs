using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SQLharj.Models
{
    public class Tuote
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; } 
        public string LAAKENIMI { get; set; }
        [StringLength(64, ErrorMessage = "Tuotenimi ei voi ylittää 64 merkkiä")]
        public string ATCKOODI { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MA_Date { get; set; }
    }
}
