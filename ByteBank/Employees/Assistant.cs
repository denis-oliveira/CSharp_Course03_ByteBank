using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string cpf) : base (2000, cpf) {}

        public override void IncreaseSalary()
        {
            this.Salary *= 1.10;
        }

        public override double GetBonus()
        {
            return this.Salary * 0.20;
        }
    }
}
