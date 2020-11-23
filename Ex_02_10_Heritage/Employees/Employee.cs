using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_10_Heritage.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }
        public virtual double GetBonus()
        {
            return Salary * 0.10;
        }
    }
}
