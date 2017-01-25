using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_11
{
    class Program
    {
        static void Main(string[] args)
        {
        // FOR SHITTI
            int i, k;
            int luku;
            Console.WriteLine("Anna luku:");
            luku = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= luku; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}