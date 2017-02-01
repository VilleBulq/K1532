using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Tehtävä 3

Tehtävänäsi on ohjelmoida television toiminta.
 Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja 
 tekisit Televisio-luokkaan? */
namespace Oop_Teht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();
            tv.TurnOn();
            tv.ShowTV();
            tv.ChangeChannel(10);
            tv.ChangeSource(2);
            tv.ChangeVolume(40);
            tv.ShowTV();
        }
    }
}
