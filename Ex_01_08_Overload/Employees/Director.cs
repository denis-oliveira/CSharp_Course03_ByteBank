﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_08_Overload.Employees
{
    public class Director
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }
        public double GetBonus()
        {
            return this.Salary;
        }
    }
}
