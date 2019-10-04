using System;
using System.Collections.Generic;

namespace MyDB2.Models
{
    public partial class Pakkaus0
    {
        public int Pakkausnro { get; set; }
        public string Vnrnro { get; set; }
        public string Pakkauskoko { get; set; }
        public int Kerroin { get; set; }
        public double Koko { get; set; }
        public string Yksikko { get; set; }
        public string Laite { get; set; }
        public int? Astiatun { get; set; }
        public DateTime? Kauppaantulopvm { get; set; }
        public DateTime? Kaupastapoispvm { get; set; }
        public string Reseptistatus { get; set; }
        public string Laakenimi { get; set; }
        public string Vahvuus { get; set; }
        public string Laakemuotonimi { get; set; }
        public int Laakemuototun { get; set; }
        public string Haltija { get; set; }
        public string Hum { get; set; }
        public string Vet { get; set; }
        public bool Rinnakkaistuonti { get; set; }
        public int Vaikainelkm { get; set; }
        public string Atckoodi { get; set; }
        public int Atctun { get; set; }
        public string Ddd { get; set; }
        public string Dddyksikko { get; set; }
        public string Huume { get; set; }
        public string Psykoluokitus { get; set; }
        public bool Liikennevaara { get; set; }
        public int? Ehtokoodi { get; set; }
        public int? Myyntilupanro { get; set; }
        public string Eumyyntilupanro { get; set; }
        public DateTime Paatospvm { get; set; }
        public DateTime? Paattymispvm { get; set; }
        public string Tilanimi { get; set; }
        public int Tilakoodi { get; set; }
        public string Muutos { get; set; }
        public string EdellinenVnrnro { get; set; }
        public string Substituutioryhma { get; set; }
        public bool Kaupan { get; set; }
        public string EdellinenLaakenimi { get; set; }
    }
}
