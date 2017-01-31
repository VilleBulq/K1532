using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washing
{
    class Program
    {
        static void Main(string[] args)
        {
            Washing pesukone = new Washing();
            pesukone.TurnOn();
            pesukone.ShowStatus();
            pesukone.SetProgram("Puuvilla");
            pesukone.ShowStatus();
        }
    }
}
