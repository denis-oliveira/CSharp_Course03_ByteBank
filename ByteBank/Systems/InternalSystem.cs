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
        public bool LogInto(IAuthenticable authenticablePerson, string passworkAttempt)
        {
            if (authenticablePerson.Authenticate(passworkAttempt))
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
