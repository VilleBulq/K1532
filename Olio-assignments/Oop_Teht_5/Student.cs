using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Teht_5
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Ects { get; set; }
        public string Program { get; set; }

        public void SetName(string value) { Name = value; }
        public void SetAge(int value) { Age = value; }
        public void SetEmail(string value) { Email = value; }
        public void SetEcts(int value) { Ects = value; }
        public void SetProgram(string value ) { Program = value; }

        public void ShowStudent() {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Ects: " + Ects);
            Console.WriteLine("Program: " + Program);
        }

    }
}
