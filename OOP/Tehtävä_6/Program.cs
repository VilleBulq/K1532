using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7.02 Litraa / 100km
            double auton_kulutus = 7.02;
            Console.WriteLine("Anna matka >");
            int matka = Int32.Parse(Console.ReadLine());
            double bensa = 1.595;
            double kulutus = matka * auton_kulutus / 100;
            double kustannus = kulutus * bensa;
            Console.WriteLine("Bensaa kuluu: " + kulutus + " kustannus " + kustannus);



        }
    }
}