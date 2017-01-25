using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_20
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){Valikko();}
        }
        // Valikolle oma aliohjelma
        static void Valikko()
        {
            Console.WriteLine("1: Add new user");
            Console.WriteLine("2: Show users");
            Console.WriteLine("3: Delete user");
            int valinta = Int32.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Add_user();
            }
            else if (valinta == 2)
            {
                Show_users();
            }
            else if (valinta == 3)
            {
                Delete_user();
            }
        } // Valikko Loppuu
        // Käyttäjän lisääminen
        static void Add_user()
        {
            Console.WriteLine("Write username");
            string username = Console.ReadLine();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("users.txt", true))
            {
                file.WriteLine(username);
                Console.WriteLine("Lisätty käyttäjä " + username);
            }
        }
        // Tulostaa ensinkaikki käyttäjät
        static string[] Show_users() {
            string[] lines = System.IO.File.ReadAllLines("users.txt");
            int i = 0;
            foreach (string line in lines) {  
                Console.WriteLine("Nimi " + line + " id: " + i);
                i++;
            }
            return lines;
        }
        static void Delete_user() {
            string[] tiedot = Show_users();
            Console.WriteLine("Valitse poistettavan id");
            int deleteid = int.Parse(Console.ReadLine());
            tiedot[deleteid] = "";
            WriteToFile(tiedot);
         }
         static void WriteToFile(string[] data) {
            using (System.IO.StreamWriter tieto = new System.IO.StreamWriter("users.txt")) {
            foreach(string line in data) {
                    if (line != "")
                    {
                        tieto.WriteLine(line);
                    }

                }
            }
         }
    }
}
