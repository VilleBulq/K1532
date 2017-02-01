using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Teht_3
{
    class Television
    {
        public bool IsOn { get; set; } // Onko tv päällä
        public int Channel { get; set; } // Mikä kanava on valittu
        public int Volume { get; set; }
        public int Source { get; set; }

        public void TurnOn() { IsOn = true; }
        public void ChangeChannel(int value) { Channel = value; }
        public void ChangeVolume(int volume) { Volume = volume; }
        public void ChangeSource(int source ) { Source = source; }

        public void ShowTV() {
            Console.WriteLine("TV STATE: " + IsOn);
            Console.WriteLine("Channel: " + Channel);
            Console.WriteLine("Volume: " + Volume);
            Console.WriteLine("Source: " + Source);
            
        }
    }

}
