using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Anna luku:");
                int number;
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out number);
                if (result == true)
                {
                    switch (number)
                    {
                        case 1: Console.WriteLine("YKSI"); break;
                        case 2: Console.WriteLine("KAKSI"); break;
                        case 3: Console.WriteLine("KOLME"); break;
                        default: Console.WriteLine("Joku muu luku"); break;
                    }

                }
                else
                {
                    Console.WriteLine("Not interger");
                }
            }
        }
    }
}