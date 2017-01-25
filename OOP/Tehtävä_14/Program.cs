using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_14
{
    class Program
    {
        static void Main(string[] args)
        {
        bool jekku = true;
            int[] luvut = new int[4];
        while(jekku) {
        // Paina 8 niin lopettaa 
                int arvosana = Int32.Parse(Console.ReadLine());
                if (arvosana > 5)
                {
                    Console.WriteLine("Anna arvosana 1-5");
                    break;
                }
                else if (arvosana == 1)
                {
                    luvut[0] += 1;
                }
                else if (arvosana == 2)
                {
                    luvut[1] += 1;
                }
                else if (arvosana == 3)
                {
                    luvut[2] += 1;
                }
                else if (arvosana == 4)
                {
                    luvut[3] += 1;
                }
                else if (arvosana == 5)
                {
                    luvut[4] += 1;
                }
                else if (arvosana == 0)
                {
                    jekku = false;
                }
                
                }
            for(int i =0; i < luvut.Length; i++) {
                Console.WriteLine("Arvosanoja " + (i+1) + " On " + luvut[i]);
            }
            }
        }
    }

