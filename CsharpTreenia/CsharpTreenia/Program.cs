using System;

namespace CsharpTreenia
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tehdään peli, joka kehittyy vaiheittain:
             * 1) Lisätään ajanotto olemassa olevaan harjoitukseen
            */
                
            Console.WriteLine("Hei, mikä on nimesi?");
            DateTime alku = DateTime.Now;
            String nimi = Console.ReadLine();
            DateTime loppu = DateTime.Now;
            Console.WriteLine("Hei, " + nimi, " !");
            TimeSpan aika = loppu - alku;
            Console.WriteLine("Vastausaikasi oli: " + aika);
        }
    }
}
