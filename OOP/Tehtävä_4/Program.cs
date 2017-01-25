using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_4
{
    class Program
    {

        // Tee ohjelma, jossa kysytään käyttäjältä tämän ikä.Jos ikä on alle 18 vuotta, tulosta
        //  "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori". 
        static void Main(string[] args)
        {
            int ika;
            Console.WriteLine("Anna ikä");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (ika >= 18 & ika < 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }
    }
}
