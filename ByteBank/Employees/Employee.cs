using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class Employee
    {
        public static int EmployeesTotal { get; private set; }
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }

        public Employee(double initialSalary, string cpf)
        {
            this.Salary = initialSalary;
            this.Cpf = cpf;
            Employee.EmployeesTotal++;
        }

        public abstract void IncreaseSalary();

        public abstract double GetBonus();
    }
}
