using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3
{
        class Program
        {
            static void Main(string[] args)
            {

                // Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon. 
                int luku1, luku2, luku3;
                Console.WriteLine("Anna 3 lukua:");
                luku1 = int.Parse(Console.ReadLine());
                luku2 = int.Parse(Console.ReadLine());
                luku3 = int.Parse(Console.ReadLine());
                int summa;
                int keskiarvo;
                summa = (luku1 + luku2 + luku3);
                keskiarvo = (summa / 3);
                Console.WriteLine("Summa on: " + summa);
                Console.WriteLine("Keskiarvo on: " + keskiarvo);
            }
        }
    }

