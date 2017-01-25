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

            int[] lista = new int[5];
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Anna luku: ");
                int num = Int32.Parse(Console.ReadLine());
                lista[i] = num;

            }

            for (int i = 0; i < lista.Length / 2; i++)
            {
                int temp = lista[i];
                lista[i] = lista[lista.Length - i - 1];
                lista[lista.Length - i - 1] = temp;
            }
            // Tulostus allekain
            foreach (int n in lista)
            {
                Console.Write(n + " ");
            }



            }
        }
    }

