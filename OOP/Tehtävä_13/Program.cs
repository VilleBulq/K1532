using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_13
{
            class Program
        {
            static void Main(string[] args)
            {
                List<int> pisteet = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Anna Pisteet:");
                    int piste = Int32.Parse(Console.ReadLine());
                    pisteet.Add(piste);
                }
                int pienin = pisteet.Min();
                int suurin = pisteet.Max();
                int tulos = pisteet.Sum();
                int kaikki = tulos - pienin - suurin;

                Console.WriteLine(kaikki);

            }
        }
    }

}
    }
}
