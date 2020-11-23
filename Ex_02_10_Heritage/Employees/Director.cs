using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_10_Heritage.Employees
{
    public class Director : Employee
    {
        public override double GetBonus()
        {
            return this.Salary + base.GetBonus();
        }
    }
}
