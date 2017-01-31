using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washing
{
    class Washing
    {
        // Properties
        public bool IsOn { get; set; } // Pesukoneen tila päällä/pois
        public bool Operating {get;set;}// Onko ohjelma käynnissä
        public bool IsWaterOn { get; set; } // Onko vesi päällä
        public bool IsDoorOpen { get; set; }// Onko rummun ovi auki
        public string WashingProgram { get; set; } // Mikä ohjelma on käytössä
        public int TimeLeft { get; }// Paljonko aikaa jäljellä
        public int RoundsPerMin {get;set;} // Rummun kierrosnopeus

    public void TurnOn() { IsOn = true;}
    public void TurnWater() { IsWaterOn = true; }
    public void OpenDoor() { IsDoorOpen = true; }
    public void SetProgram(string value) { WashingProgram = value; }
        public void ShowStatus() {
            Console.WriteLine("State: " + IsOn);
            Console.WriteLine("Program: " + WashingProgram);
        }

    }
}
