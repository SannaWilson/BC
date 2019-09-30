using System;
            /* Tehdään peli, joka kehittyy vaiheittain:
             * 1) Lisätään ajanotto olemassa olevaan harjoitukseen
             * 2) Muokataan tehtävää ja lisätään vastaukselle pituusehto.
             * 3) Tarkistus, onko pituusehto täyttynyt.
             * 4) Selkiytetään koodia ja järjestellään luokkia
            */
namespace CsharpTreenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Peli.Tehtävä();
        }
    }
    public static class Peli
    {
        public static void Tehtävä()
        {
            Console.WriteLine("Kirjoita vähintään 10 merkin pätkä.");

            DateTime alku = DateTime.Now;
            String vastaus = Console.ReadLine();
            DateTime loppu = DateTime.Now;
            int pituus = vastaus.Length;
            TimeSpan aika = loppu - alku;
            if (pituus > 9)
            {
                Console.WriteLine("Vastausaikasi oli: " + aika + ". Kirjoitit: " + pituus + " merkkiä.");
            }
            else
            {
                Console.WriteLine("Vastaus oli liian lyhyt.");
            }
        }
    }
}