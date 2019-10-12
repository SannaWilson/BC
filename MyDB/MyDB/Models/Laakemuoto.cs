using System;
using System.Collections.Generic;

namespace MyDB.Models
{
    public partial class Laakemuoto
    {
        public Laakemuoto()
        {
            Pakkaus0 = new HashSet<Pakkaus0>();
        }

        public short Laakemuototun { get; set; }
        public string Laakemuotonimi { get; set; }
        public string Laakemuotonimir { get; set; }
        public string Laakemuotonimie { get; set; }

        public ICollection<Pakkaus0> Pakkaus0 { get; set; }
    }
}
