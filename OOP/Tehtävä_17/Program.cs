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
           
            int[] table1 = { 10, 20, 30, 40, 50 };
            int[] table2 = { 5, 15, 25, 35, 45 };
            int[] table3 = new int[table1.Length];
            for (int x = 0; x < table1.Length; x++)
            {
                foreach (int i in table1)
                {
                    foreach (int l in table2)
                    {
                        if (i < l) { table3[x] = i; }
                        else { table3[x] = l; }
                    }
                }
            }
            foreach (int value in table3)
            {
                Console.WriteLine(value);
            }
        }
    }
}
