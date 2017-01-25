using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool luku = true;
            int summa = 0;
            while (luku)
            {
                Console.WriteLine("Anna luku > ");
                int kysy = Int32.Parse(Console.ReadLine());
                if (kysy == 0)
                {
                    luku = false;
                    Console.WriteLine("Summa on " + summa);
                }
                summa = summa + kysy;



            }
        }
    }
}
