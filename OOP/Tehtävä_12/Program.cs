using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_12
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = new List<int>();
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Anna luku >");
                int add = Int32.Parse(Console.ReadLine());
                lista.Add(add);
                i++;
                Console.WriteLine("\n");

            }

            int size = lista.Count;
            for (int j = 0; j < lista.Count; j++)
            {
                Console.WriteLine(lista[size - 1]);
                size = size - 1;
            }

        }
    }
}
