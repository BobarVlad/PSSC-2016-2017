using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Entity
    public class Student
    {
        public RegistrationNumber RegNumber { get;  set; }
        public String Name { get;  set; }
        public Credits Credits { get;  set; }

        public Student(RegistrationNumber regNumber, String name)
        {
            RegNumber = regNumber;
            Name = name;
        }

        public Student(RegistrationNumber regNumber, String name, Credits credits)
            : this(regNumber, name)
        {
            Credits = credits;
        }
    }
}
