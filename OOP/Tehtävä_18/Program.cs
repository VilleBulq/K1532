using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // KAIKKIEN RIVIEN OLTAVA OK ETTÄ ON PALIDROMI :DD 
            // TÄÄ on aikamoinen viritys
            /*
                Console.WriteLine("Anna sana");
                string lause = Console.ReadLine();
                int pituus = lause.Length;
                Console.WriteLine("Pituus on " + pituus);
                char[] uusi = new char[pituus];
                for (int i = 0; i < lause.Length; i++)
                {
                    uusi[pituus - 1] = lause[i];
                    pituus -= 1;
                }
                for (int j = 0; j < lause.Length; j++)
                {
                    if (lause[j] == uusi[j])
                    {
                        Console.WriteLine("On palidromi");
                    }
                    else
                    {
                        Console.WriteLine("ei ole palidromi");
                    }
                }
            }*/
            string sana;
            bool pal = true;

            Console.Write("Anna sana ");
            sana = Console.ReadLine();

            for (int i = 0; i < sana.Length / 2; i++)
            {
                if (sana[i] != sana[sana.Length - 1 - i])
                {
                    Console.WriteLine("ei ole palindromi");
                    pal = false;
                    break;
                }

            }
            if (pal == true)
            {
                Console.WriteLine("palindromi");
            }
        }
    }
}


