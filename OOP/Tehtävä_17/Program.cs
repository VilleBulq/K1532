using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_17
{
    class Program
    {
        /*static void Main(string[] args)
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
    }*/
static void Main(string[] args)
{
    //Luvut taulukossa 1 : 10,20,30,40,50
    //Luvut taulukossa 2 : 5,15,25,35,45
    int[] table1 = { 10, 20, 30, 40, 50 };
    int[] table2 = { 5, 15, 25, 35, 45 };
    int[] table3 = new int[table1.Length + table2.Length];
    for (int x = 1; x <= 9; x = x + 2)
    {
        if (x == 3) { table3[x - 1] = table2[x - 2]; }
        else if (x == 5) { table3[x - 1] = table2[x - 3]; }
        else if (x == 7) { table3[x - 1] = table2[x - 4]; }
        else if (x == 9) { table3[x - 1] = table2[x - 5]; }
        else { table3[x - 1] = table2[x - 1]; }
    }
    for (int z = 0; z <= 8; z = z + 2)
    {
        if (z == 2) { table3[z + 1] = table1[z - 1]; }
        else if (z == 4) { table3[z + 1] = table1[z - 2]; }
        else if (z == 6) { table3[z + 1] = table1[z - 3]; }
        else if (z == 8) { table3[z + 1] = table1[z - 4]; }
        else { table3[z + 1] = table1[z + 1]; }
    }



    foreach (int value in table3)
    {
        Console.WriteLine(value);
    }
}
    }
}


  