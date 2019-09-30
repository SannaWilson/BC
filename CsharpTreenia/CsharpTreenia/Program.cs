using System;

namespace CsharpTreenia
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tehdään peli, joka kehittyy vaiheittain:
             * 1) Lisätään ajanotto olemassa olevaan harjoitukseen
             * 2) Muokataan tehtävää ja lisätään vastaukselle pituusehto.
             * 3) Tarkistus, onko pituusehto täyttynyt.
            */
                
            Console.WriteLine("Kirjoita vähintään 10 merkin pätkä.");

            DateTime alku = DateTime.Now;
            String vastaus = Console.ReadLine();

            int pituus = vastaus.Length;
            DateTime loppu = DateTime.Now;
            TimeSpan aika = loppu - alku;

            if (pituus >9)
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
