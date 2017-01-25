using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomi = new Random();
            int luku = randomi.Next(100);
            bool arvaus = true;
            int arvaukset = 0;
            while (arvaus)
            {
                int arvaa = Int32.Parse(Console.ReadLine());
                arvaukset++;
                if (arvaa == luku)
                {
                    Console.WriteLine("Arvasin oikein " + arvaukset + " Kerralla");
                    arvaus = false;
                }
                else if (arvaa < luku)
                {
                    Console.WriteLine("Luku on suurempi");
                }
                else if (arvaa > luku)
                {
                    Console.WriteLine("Luku on pienempi");
                }
            }
        }
    }
}
