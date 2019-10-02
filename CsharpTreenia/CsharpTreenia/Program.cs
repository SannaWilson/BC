using System;
using System.Linq;
/* Tässä harjoituksessa on tehty seuraavia asioita:
* 1) Lisätty ajanotto harjoitukseen
* 2) Määritelty vastaukselle pituusehto.
* 3) Tarkistus, onko pituusehto täyttyy.
* 4) Käytetty luokkia ohjelman rakenteen pohjana:
*    1) Aloitus
*    2) Interaktiivinen osuus
*    3) Lopetus
* 6) Käytetty ohjauslauseita:
*      1) if...else
*      2) switch...case
*      3) do..while
*      4) foreach...in
*      5) continue
*      6) goto
*      7) return
*/
namespace CsharpTreenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Peli.Aloitus();
            Console.WriteLine("Tässä ohjelmassa on kuusi erilaista tehtävää. Voit valita minkä tahansa tehtävän ja jatkaa niin kauan kuin haluat.");

            Peli.Tehtävä7();

            string jatkuuko = "K";
            do
            {
            Console.WriteLine("\nHaluatko jatkaa? Kirjoita K=Kyllä tai E=Ei.");
                jatkuuko = Console.ReadLine();
                if (jatkuuko=="K")
                {
                Peli.Tehtävä7();
                }
            } while (jatkuuko=="K");

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
        public static void Lopetus()
        {
            Console.Write("Hauskaa oli! Kiitos, että pelasit.\n\n");
            Console.ReadKey();
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
            Console.WriteLine("Kokeillaan, onko sinulla onnea. Heitä noppaa painamalla jotain näppäintä.");
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
            Console.WriteLine("Heitetään noppaa, kunnes saat kuutosen.");
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
        public static void Tehtävä4()
        {
            string[] tiimi = { "Sanna", "Jennina", "Anne", "Kirsi", "Cathy" };
            Console.WriteLine("BootCamp Mimmit tiimiin kuuluvat:");
            foreach (string jäsen in tiimi)
            {
                Console.WriteLine(jäsen + "!");
            }
        }
        public static void Tehtävä5()
        {
            string[] tiimi = { "Sanna", "Jennina", "Anne", "Kirsi", "Cathy" };
            Console.WriteLine("Hae BootCamp Mimmit -tiimin jäseniä nimellä:");
            string haku = Console.ReadLine();

            if (tiimi.Contains(haku))
            {
                goto Osuma;
            }
            Console.Write("Nimeä ei löytynyt listasta.");
            goto Lopetus;

        Osuma:
            Console.WriteLine(haku + " löytyi listasta.");

            Lopetus:
            Console.WriteLine("Voit tehdä uuden haun valitsemalla tehtävän 5 uudestaan.");
        }
        static int Noppa3()
        {
            Random Noppa3 = new Random();
            int arpa = Noppa3.Next(1, 7);
            return arpa;
        }
        public static void Tehtävä6()
        {
            Console.WriteLine("Paina mitä tahansa näppäintä heittääksesi arpaa.");
            Console.ReadKey();
            int numero = Noppa3();
            Console.WriteLine("Sait numeron: " + numero);
        }
        public static void Tehtävä7()
        {
            Console.WriteLine("\n\n Valitse seuraavan tehtävän numero (1-6):");

            string syöte = Console.ReadLine();
            int tehtNro = int.Parse(syöte);

            switch (tehtNro)
            {
                case 1:
                    Peli.Tehtävä();
                    break;
                case 2:
                    Peli.Tehtävä2();
                    break;
                case 3:
                    Peli.Tehtävä3();
                    break;
                case 4:
                    Peli.Tehtävä4();
                    break;
                case 5:
                    Peli.Tehtävä5();
                    break;
                case 6:
                    Peli.Tehtävä6();
                    break;
                default:
                    Console.WriteLine("Uups, kone ei tunnistanut numeroa.");
                    break;
            }
        }
    }
}