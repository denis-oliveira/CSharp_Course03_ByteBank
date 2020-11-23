using Ex_02_10_Heritage.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_10_Heritage
{
    class BonusManager
    {
        private double _bonusTotal;

        public void RegisterBonus(Employee employee)
        {
            this._bonusTotal += employee.GetBonus();
        }

        public double GetBonusTotal()
        {
            return this._bonusTotal;
        }
    }
}
