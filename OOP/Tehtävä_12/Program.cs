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
            
            for(int i = 0; i < lista.Length; i++) {
                Console.WriteLine("Anna luku: ");
                int num = Int32.Parse(Console.ReadLine());
                lista[i] = num;
               
            }
            int pituus = lista.Length;
            Console.WriteLine("Pituus : " + pituus);
            int[] temp = new int[5];
            for (int j = 0; j < lista.Length; j++) {
                temp[j] = lista[pituus-1];
                pituus = pituus - 1;

            }
            foreach(int n in lista) {
                Console.WriteLine("Luku" + n);
            }
         


        }
    }
}
