using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Teht_6
{
    class Drunk
    {
        public double BloodAlcohol { get; set; }
        public string Drink { get; set; }
        public bool Putka { get; set; }
        public int Angry { get; set; }
        public bool PassedOut { get; set; }

        public void DrinkSome() {
            BloodAlcohol += 0.1;
        }
        public void HowDrunk() {
            Console.WriteLine("Alcohol in blood: " + BloodAlcohol);
            Console.WriteLine("Which drink u drinking: " + Drink);
            Console.WriteLine("Are you in jail?" + Putka);
            Console.WriteLine("How angry you are: " + Angry);
            Console.WriteLine("Are you passed out: " + PassedOut);
            }
    }
}
