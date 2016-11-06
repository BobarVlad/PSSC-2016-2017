using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
    enum PositionType
    {
        Asistent,
        Lector,
        Conferentiar,
        Profesor
    }
    interface IProfessor 
    {
        PositionType position
        {
            get;
            set;
        }

        void verifyStudents();
    }
}
