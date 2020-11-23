using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    public abstract class Authenticable : Employee
    {
        public string Password { get; set; }

        public Authenticable(double initialSalary, string cpf) 
            : base (initialSalary, cpf) {}

        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
