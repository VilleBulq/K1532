using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Teht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();
            veh.Name = "Auto";
            veh.Speed = 80;
            veh.Tyres = 4;
            string tiedot = veh.ToString();
            Show(tiedot);
        }
        public static void Show(string info) {
            Console.WriteLine(info);
        }
    }

}
