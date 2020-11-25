using ByteBank.Employees;
using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.CalculateBonus();
            Program.UseInternalSystem();
            Console.ReadLine();
        }

        public static void UseInternalSystem() {
            InternalSystem internalSystem = new InternalSystem();

            Director robert = new Director("159.753.398-04");
            robert.Name = "Robert";
            robert.Password = "123";

            AccountManager caroline = new AccountManager("326.985.628-89");
            caroline.Name = "Caroline";
            caroline.Password = "abc";

            CommercialPartner commercialPartner = new CommercialPartner();
            commercialPartner.Password = "123456";

            internalSystem.LogInto(robert, "123");
            internalSystem.LogInto(caroline, "abc");
            internalSystem.LogInto(commercialPartner, "123456");
        }

        public static void CalculateBonus()
        {
            BonusManager bonusManager = new BonusManager();

            Designer peter = new Designer("833.222.048-39");
            peter.Name = "Peter";

            Director robert = new Director("159.753.398-04");
            robert.Name = "Robert";

            Assistant igor = new Assistant("981.198.778-53");
            igor.Name = "Igor";

            AccountManager caroline = new AccountManager("326.985.628-89");
            caroline.Name = "Caroline";

            Developer denis = new Developer("358.073.758-90");
            denis.Name = "Dênis";

            bonusManager.RegisterBonus(peter);
            bonusManager.RegisterBonus(robert);
            bonusManager.RegisterBonus(igor);
            bonusManager.RegisterBonus(caroline);
            bonusManager.RegisterBonus(denis);

            Console.WriteLine("Month Bonus Total: $" + bonusManager.GetBonusTotal());
        }
    }
}