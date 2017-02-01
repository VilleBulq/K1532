using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class WashingMachine
    {
        // Properties
        public bool IsOn { get; set; }      // Pesukoneen tila päällä/pois
        public bool Operating { get; set; } // Onko ohjelma käynnissä
        public bool IsWaterOn { get; set; } // Onko vesi päällä
        public bool IsDoorOpen { get; set; } // Onko rummun ovi auki
        public string WashingProgram { get; set; } // Mikä ohjelma on käytössä
        public int Temperature { get; set; }
        public int TimeLeft { get; }// Paljonko aikaa jäljellä
        public int RoundsPerMin {get;set;} // Rummun kierrosnopeus
        // CONSTRUCTOR
        public WashingMachine() {
            IsWaterOn = false;
            IsDoorOpen = false;
            TimeLeft = 0;
            RoundsPerMin = 0;
            Operating = false;
    }
    public void TurnOn() { IsOn = true;}
    public void TurnWater() { IsWaterOn = true; }
    public void OpenDoor() { IsDoorOpen = true; }
    public void SetProgram(string value) { WashingProgram = value; }
    public void SetTemperature(int temp) { Temperature = temp; }
    public void SetRPM(int rpm) { RoundsPerMin = rpm; }
    public void ShowStatus() {
            Console.WriteLine("State: " + IsOn);
            Console.WriteLine("Running :" + Operating);
            Console.WriteLine("Program: " + WashingProgram);
            Console.WriteLine("Water state: " + IsWaterOn);
            Console.WriteLine("RPM: " + RoundsPerMin);
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine();
        }

    }
}
