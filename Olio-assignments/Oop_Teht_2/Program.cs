using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine pesukone = new WashingMachine();
            pesukone.TurnOn();
            pesukone.ShowStatus();
            pesukone.SetRPM(1200);
            pesukone.SetTemperature(50);
            pesukone.ShowStatus();
            
         
        }
    }
}
