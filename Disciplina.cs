using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Disciplina
    {
        string[] n_disciplina;
        string[] credite;

        public Disciplina(string[] n_d, string[] c)
        {
            n_d = n_disciplina;
            c = credite;
        
        }
        public string _n_disciplina
        {


            get { return _n_disciplina; }
            set { _n_disciplina = value; }
        }
        public string _credite
        {


            get { return _credite; }
            set { _credite = value; }
        }
    }
}