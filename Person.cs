using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string name;
        public DateTime birthDate;
        public enum Genders { male, female };

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return "name: " + name + "\n" +
                   "date of birth: " + birthDate;
        }
    }
}
