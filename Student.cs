using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Student
    {
        string[] nume;
        string[] prenume;
        string[] cnp;
        string[] telefon;
        float nota1, nota2, nota_exam;
        public Student(string[] n, string[] p, string[] c, string[] t, float n1,float n2, float n_e)
        {
            n = nume;
            p = prenume;
            c = cnp;
            t = telefon;
            n1=nota1;
            n2 = nota2;
            n_e = nota_exam;
        }
        public string _nume
        {


            get { return _nume; }
            set { _nume = value; }
        }
        public string _prenume
        {


            get { return _prenume; }
            set { _prenume = value; }
        }
        public string _cnp
        {


            get { return _cnp; }
            set { _cnp = value; }
        }
        public string _telefon
        {


            get { return _telefon; }
            set { _telefon = value; }
        }
        public float _nota1
        {


            get { return _nota1; }
            set { _nota1 = value; }
        }
        public string _nota2
        {


            get { return _nota2; }
            set { _nota2 = value; }
        }
        public string _nota_exam
        {


            get { return _nota_exam; }
            set { _nota_exam = value; }
        }
    }
}