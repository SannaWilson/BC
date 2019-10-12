using System;
using System.Collections.Generic;

namespace MyDB.Models
{
    public partial class Atc
    {
        public Atc()
        {
            Pakkaus0 = new HashSet<Pakkaus0>();
        }

        public int Atctun { get; set; }
        public string Atckoodi { get; set; }
        public string Selites { get; set; }
        public string Seliter { get; set; }
        public string Ddd { get; set; }
        public string Dddyksikko { get; set; }

        public Atc AtctunNavigation { get; set; }
        public Atc InverseAtctunNavigation { get; set; }
        public ICollection<Pakkaus0> Pakkaus0 { get; set; }
    }
}
