using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = { 4, 2, 3, 4, 5 };
            int[] luvut2 = { 5, 4, 5, 6, 7 };
            int[] jarjes = new int[9];
            for (int i = 0; i < 5; i++)
            {
                jarjes[i] = luvut[i];
            }
            for (int i = 6; i < 9; i++)
            {
                jarjes[i] = luvut2[i];
            }
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(jarjes[i]);
            }
        }



    }
}