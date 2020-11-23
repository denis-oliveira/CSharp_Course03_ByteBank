using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Developer : Employee
    {
        public Developer(string cpf) : base(3000, cpf) {}

        public override void IncreaseSalary()
        {
            this.Salary *= 1.15;
        }

        public override double GetBonus()
        {
            return this.Salary * 0.10;
        }
    }
}
