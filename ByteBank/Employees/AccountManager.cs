using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class AccountManager : Authenticable
    {
        public AccountManager(string cpf) : base(4000, cpf) {}

        public override void IncreaseSalary()
        {
            this.Salary *= 1.05;
        }
        public override double GetBonus()
        {
            return this.Salary * 0.25; ;
        }
    }
}
