using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5
{
    class Program
    {
            static void Main(string[] args)
            {
                int seconds;
                seconds = Int32.Parse(Console.ReadLine());
                int hours = (seconds / 3600);
                int minutes = (seconds % 3600) / 60;
                int sekunnit = seconds % 60;
                Console.WriteLine("Tunnint :" + hours);
                Console.WriteLine("Minuutit :" + minutes);
                Console.WriteLine("Sekunnit :" + sekunnit);

            }
        }
    }
