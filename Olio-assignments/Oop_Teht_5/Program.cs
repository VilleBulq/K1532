using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Teht_5
/*
 * Suunnittele UML-editorilla Opiskelija-luokka, 
 * joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja. 
 * Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, 
 * joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon
 *  (esim. 5 opiskelijaa). Tulosta taulukossa olevien opiskelijoiden tiedot 
 *  käyttämällä toistorakennetta. 
 *  */
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.SetAge(10);
            stu1.SetName("Jaska");
            stu1.SetEcts(1);
            stu1.SetEmail("kokkeliskaka@kigul.com");
            stu1.SetProgram("passelorin dikrii");

            Student stu2 = new Student();
            stu2.SetAge(20);
            stu2.SetName("Poutasen niko");
            stu2.SetProgram("Lappeenranta floristi");
            stu2.SetEmail("poutisnikke@nikke.dig");
            stu2.SetEcts(2);

            Student stu3 = new Student();
            stu3.SetAge(20);
            stu3.SetName("Poutasen niko");
            stu3.SetProgram("Lappeenranta floristi");
            stu3.SetEmail("poutisnikke@nikke.dig");
            stu3.SetEcts(2);

            Student stu4 = new Student();
            stu4.SetAge(20);
            stu4.SetName("Poutasen niko");
            stu4.SetProgram("Lappeenranta floristi");
            stu4.SetEmail("poutisnikke@nikke.dig");
            stu4.SetEcts(2);

            Student[] lista = { stu1, stu2, stu3, stu4 };
            foreach(Student stu in lista) {
                stu.ShowStudent();
            }

        }
    }
}
