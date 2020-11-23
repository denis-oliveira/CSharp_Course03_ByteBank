using Ex_01_08_Overload.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_08_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            BonusManager bonusManager = new BonusManager();

            Employee peter = new Employee();
            peter.Name = "Peter Tosh";
            peter.Cpf = "358.073.758-90";
            peter.Salary = 1500;

            bonusManager.RegisterBonus(peter);

            Director paul = new Director();
            paul.Name = "Paul Neumann";
            paul.Cpf = "376.875.678-75";
            paul.Salary = 18000;

            bonusManager.RegisterBonus(paul);

            Console.WriteLine("Bonus Total: $" + bonusManager.GetBonusTotal());
            Console.ReadLine();
        }
    }
}
