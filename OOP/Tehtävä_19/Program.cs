using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arvatut = new List<string>();
            string sana = "kakka";
            int arvauksia = 5;
            while (arvauksia >= 0)
            {
                TulostaArvatut(arvatut);
                Console.WriteLine("Arvaa sana");
                string arvaus = Console.ReadLine();
                arvatut.Add(arvaus);
                if (arvaus == sana)
                {
                    Console.WriteLine("Oikein arvattu");
                    break;
                }
                else
                {
                    TarkistaSanasta(arvaus, sana);
                }
            }

        }
        static void TarkistaSanasta(string arvaus, string sana)
        {
            for (int i = 0; i < sana.Length-1; i++)
            {
                if (arvaus[i] == sana[i])
                {
                    Console.Write("Arvattu" + arvaus[i]);
                }
            }
        }

        static void TulostaArvatut(List<string> arvatut)
        {
            foreach (string arv in arvatut)
            {
                Console.WriteLine(" Arvattu jo:" + arv);
            }
        }
    }
}

