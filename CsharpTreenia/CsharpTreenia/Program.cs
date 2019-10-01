using System;
/* Tehdään peli, joka kehittyy vaiheittain:
 * 1) Lisätään ajanotto olemassa olevaan harjoitukseen
 * 2) Muokataan tehtävää ja lisätään vastaukselle pituusehto.
 * 3) Tarkistus, onko pituusehto täyttynyt.
 * 4) Selkiytetään koodia ja järjestellään luokkia
 * 5) Luodaan lisää osia, että saadaan koodiin lisää sisältöä: Aloitus
 * 6) Ohjauslauseharjoituksia Tehtävissä 1-3:
 *      1) if...else
 *      2) switch...case
 *      3) do..while
*/
namespace CsharpTreenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Peli.Aloitus();
            Peli.Tehtävä3();
            Peli.Lopetus();
        }
    }
    public static class Peli
    {
        public static void Aloitus()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("   XXXX   ");
            Console.WriteLine("  X    X     / /            #                               #   # #");
            Console.WriteLine(" X         xxxxxx         #####                             ");
            Console.WriteLine(" X          / /     ____    #   # ###  ####    ####  # ##   #   ###");
            Console.WriteLine(" X        xxxxxx   /___/    #   ##    #____#  #____# ##  #  #  #   #");
            Console.WriteLine("  X    X   / /              #   #     #       #      #   #  #  #   #");
            Console.WriteLine("   XXXX                      #  #      ####    ####  #   #  #   ### # \n\n");
            Console.ResetColor();
        }
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
        public static void Tehtävä2()
        {
            // switch...case
            Console.WriteLine("Kokeillaan seuraavaksi, onko sinulla onnea. Heitä noppaa painamalla jotain näppäintä.");
            Console.ReadKey();
            Random Noppa = new Random();
            int arpa = Noppa.Next(1, 7);

            switch(arpa)
            {
                case 1:
                    Console.WriteLine("Arpaonni ei suosinut tällä kertaa. Sait huonoimman mahdollisen: 1");
                    break;
                case 2:
                    Console.WriteLine("Sait numeron 2.");
                    break;
                case 3:
                    Console.WriteLine("Sait numeron 3.");
                    break;
                case 6:
                    Console.WriteLine("Onni suosii sinua: sait numeron 6.");
                    break;
                default:
                    Console.WriteLine("Onnea! Sait numeron " + arpa + "!");
                    break;
            }
        }
        public static void Tehtävä3()
        {
            // do...while
            Console.WriteLine("Heitä noppaa, kunnes saat kuutosen.");
                Console.ReadKey();
            int arpa2 = 0;
            do
            {
                Random Noppa2 = new Random();
                arpa2 = Noppa2.Next(1, 7);
                if (arpa2 < 6)
                {
                Console.WriteLine("Sait: " + arpa2 + ". Heitetäänpä uudestaan!");
                }
            } while (arpa2 != 6);
            Console.WriteLine("Onnea! Sait numeron 6");
        }
        public static void Lopetus()
        {
            Console.Write("Hauskaa oli; on aika siirtyä eteenpäin ja kokeilla windows form -pohjaa");
        }
    }
}