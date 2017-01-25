using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heppi = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            foreach(int pari in heppi) {
            if(pari % 2 == 0) {
                    Console.WriteLine("HEP " + pari );
            }
            }
        }
    }
}
