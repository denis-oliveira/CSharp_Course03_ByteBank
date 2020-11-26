using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        public string Password { get; set; }

        public AuthenticableEmployee(double initialSalary, string cpf) 
            : base (initialSalary, cpf) {}

        public bool Authenticate(string passwordAttempt)
        {
            return this.Password == passwordAttempt;
        }
    }
}
