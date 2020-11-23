using Ex_01_08_Overload.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_08_Overload
{
    class BonusManager
    {
        private double _bonusTotal;

        public void RegisterBonus(Employee employee)
        {
            this._bonusTotal += employee.GetBonus();
        }

        public void RegisterBonus(Director director)
        {
            this._bonusTotal += director.GetBonus();
        }

        public double GetBonusTotal()
        {
            return this._bonusTotal;
        }
    }
}
