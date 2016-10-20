using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Decanat
    {
        List<string> profesori = new List<string>();
        List<string> studenti = new List<string>();
        List<string> discipline = new List<string>();
        public Decanat(List<string> prof, List<string> stud, List<string> dis)
        {
            prof = profesori;
            stud = studenti;
            dis = discipline;
        }
        public List<string> _profesori
        {
            get { return _profesori; }
            set { _profesori = value; }
        }
        public List<string> _studenti
        {
            get { return _studenti; }
            set { _studenti = value; }
        }
        public List<string> _discipline
        {
            get { return _discipline; }
            set { _discipline = value; }
        }
    }

}