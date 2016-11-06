using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //Entity
    public class Professor
    {
        public String Name { get;  set; }

        public Professor(String name)
        {
            Name = name;
        }
    }
}
