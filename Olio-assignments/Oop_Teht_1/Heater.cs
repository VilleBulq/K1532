using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
/*
 Tehtävä 1

Tehtävänäsi on ohjelmoida kiukaan toiminta. */
    class Heater
    {
        // Properties
        public bool IsOn { get; set; } // 1. Kiuas pitää pystyä laittamaan päälle ja pois,
        public double Temperature { get; set; } // 2. sekä sen lämpötilaa että sen antamaa
        public double Humidity { get; set; } //  3. kosteutta pitää pystyä säätämään

        public void TurnOn()
        {
            IsOn = true;
        }
        public void TurnOff()
        {
            IsOn = false;
        }
        public void ShowHeaterState()
        {
            Console.WriteLine("Heater on:" + IsOn);
            Console.WriteLine("Temperature is " + Temperature);
            Console.WriteLine("Air humidity " + Humidity);
        }

        // Constructors 
        // Methods

    }
}
