using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Teht_4
{
    class Vehicle
    {
    // PROPERTIES
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Tyres { get; set; }
    public void PrintData() {
            Console.WriteLine("Name" + Name);
            Console.WriteLine("Speed" + Speed);
            Console.WriteLine("Tyres" + Tyres);

    }
    public string ToString() {
   string info = String.Format("Name: {0} Speed: {1} Tyres: {2}", Name, Speed, Tyres);
            return info;
        }

    }
}
