using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_02_10_Heritage.Employees;

namespace Ex_02_10_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            BonusManager manager = new BonusManager();

            Employee peter = new Employee();
            peter.Name = "Peter Door";
            peter.Cpf = "543.879.157-20";
            peter.Salary = 2000;
            manager.RegisterBonus(peter);

            Director robert = new Director();
            robert.Name = "Robert Craw";
            robert.Cpf = "454.658.148-30";
            robert.Salary = 15000;
            manager.RegisterBonus(robert);

            Employee robertTest = robert;

            Console.WriteLine("Bonus of a Director reference: " + robert.GetBonus());
            Console.WriteLine("Bonus of a Employee reference: " + robertTest.GetBonus());

            Console.WriteLine("Employee Name: " + peter.Name);
            Console.WriteLine("Employee Bonus: $" + peter.GetBonus());
            Console.WriteLine("Director Name: " + robert.Name);
            Console.WriteLine("Director Bonus: $" + robert.GetBonus());
            Console.WriteLine("Bonus Total: $" + manager.GetBonusTotal());
            Console.ReadLine();
        }
    }
}
