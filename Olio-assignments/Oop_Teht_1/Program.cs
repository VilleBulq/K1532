using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create one instance of heater class
            // testing
            Heater sauna = new Heater();
            while (true)
            {
                sauna.ShowHeaterState();
                SetSauna(sauna);

            }
        }
        static void SetSauna(Heater sauna)
        {
            Console.WriteLine("Change sauna properties");
            Console.WriteLine("1: Sauna On/Off");
            Console.WriteLine("2: Set temperature");
            int setter = Int32.Parse(Console.ReadLine());
            if (setter == 1)
            {
                Console.WriteLine("1: TURN ON, 2:  TURN OFF");
                int setOn = Int32.Parse(Console.ReadLine());
                if (setOn == 1) { sauna.IsOn = true; }
                else if (setOn == 2) { sauna.IsOn = false; }
            }
            else if (setter == 2)
            {
                Console.WriteLine("Set temp to sauna");
                double temp = double.Parse(Console.ReadLine());
                sauna.Temperature = temp;
            }

        }
    }
}
