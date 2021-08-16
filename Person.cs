using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._05._01_Saver
{
    public class Person
    {
        
        private string Name;
        private string SurName;
        private int Age;
        private string Proffesion;
        private int Number;

        public Person()
        {

        }
        public Person(string name, string surName, int age, string prof)
        {
            Name = name;
            SurName = surName;
            Age = age;
            Proffesion = prof;
            Number = Program.data.Count+1;
            Program.data.Add(this);
        }
        public Person(string name, string surName, int age, string prof, int number)
        {
            Name = name;
            SurName = surName;
            Age = age;
            Proffesion = prof;
            Number = number;
        }

        public void GetPerson(out string name, out string surName, out int age, out string prof, out int number)
        {
            name = Name;
            surName = SurName;
            age = Age;
            prof = Proffesion;
            number = Number;
        }

        public void GetPerson (out string text)
        {
            text = $"|{Number}|{Name}|{SurName}|{Age}|{Proffesion}| ";
        }

      

    }
}