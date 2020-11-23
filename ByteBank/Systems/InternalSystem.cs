using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    public class InternalSystem
    {
        public bool LogInto(Authenticable authenticableEmployee, string passworkAttempt)
        {
            if (authenticableEmployee.Authenticate(passworkAttempt))
            {
                Console.WriteLine("Correct password. Welcome to the system!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect password!");
                return false;
            }
        }
    }
}
