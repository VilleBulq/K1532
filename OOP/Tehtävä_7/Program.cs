using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Anna vuosi >");
                int vuosi = Int32.Parse(Console.ReadLine());
                if (vuosi % 4 == 0)
                {
                    if (vuosi % 100 == 0)
                    {
                        if (vuosi % 400 == 0)
                        {
                            Console.WriteLine("On karkausvuosi.");
                        }
                        else { Console.WriteLine("Ei ole karkausvuosi."); }
                    }
                    else { Console.WriteLine("On karkausvuosi."); }
                }
                else
                {
                    Console.WriteLine("Ei ole karkausvuosi.");
                }
            }
        }
    }
}