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
            int[] uusitaulukko = new int[table1.Length + table2.Length];
            Array.Copy(table1, uusitaulukko, table1.Length);
            Array.Copy(table2, 0, uusitaulukko, table1.Length, table2.Length);
            Array.Sort(uusitaulukko);

            foreach (int l in uusitaulukko) {
                Console.Write(l+ " ");
            }

        }
    }
    }

  