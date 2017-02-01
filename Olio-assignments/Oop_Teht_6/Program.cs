using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Teht_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Drunk ville = new Drunk();
            ville.DrinkSome();
            ville.HowDrunk();
            ville.DrinkSome();
            ville.Drink = "Bisse";
            ville.Putka = true;
            ville.HowDrunk();
        }
    }
}
