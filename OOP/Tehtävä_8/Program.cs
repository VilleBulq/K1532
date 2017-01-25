using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            // KOLME LUKUA :D
                Console.WriteLine("Anna 3 luku >");
                int num_1 = Int32.Parse(Console.ReadLine());
                int num_2 = Int32.Parse(Console.ReadLine());
                int num_3 = Int32.Parse(Console.ReadLine());
                if (num_1 >= num_2 && num_1 >= num_3)
                {
                    Console.WriteLine(num_1 + " On suurin");
                }
                else if (num_2 >= num_1 && num_2 >= num_3)
                {
                    Console.WriteLine(num_2 + " On suurin");
                }
                else
                {
                    Console.WriteLine(num_3 + " On suurin");
                }


            }
        }
    }
}