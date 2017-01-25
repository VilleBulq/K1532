using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jekku = true;
            int[] luvut = new int[6];
            while (jekku)
            {
                // Paina 8 niin lopettaa 
                int arvosana = Int32.Parse(Console.ReadLine());
                if (arvosana > 5)
                {
                    jekku = false;
                }
                else if (arvosana == 1)
                {
                    luvut[1] += 1;
                }
                else if (arvosana == 2)
                {
                    luvut[2] += 1;
                }
                else if (arvosana == 3)
                {
                    luvut[3] += 1;
                }
                else if (arvosana == 4)
                {
                    luvut[4] += 1;
                }
                else if (arvosana == 5)
                {
                    luvut[5] += 1;
                }
                else if (arvosana == 0)
                {
                    luvut[0] += 1;
                }

            }
            String nollia = new string('*', luvut[0]);
            String ykkosia = new string('*', luvut[1]);
            String kakkosia = new string('*', luvut[2]);
            String kolmosia = new string('*', luvut[3]);
            String nelosia = new string('*', luvut[4]);
            String vitosia = new string('*', luvut[5]);
            Console.WriteLine("0: "+ nollia);
            Console.WriteLine("1: " + ykkosia);
            Console.WriteLine("2: " + kakkosia);
            Console.WriteLine("3: " + kolmosia);
            Console.WriteLine("4: " + nelosia);
            Console.WriteLine("5: " + vitosia);

        }
    }
}

