﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Attendance
    {
        private int _count;
        public int Count { get;  set; }

        public Attendance(int count)
        {
            _count = count;
        }
    }
}
