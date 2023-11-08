using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.SalaryDecorator
{
    internal class LongevityBonus : SalaryDecoratorClass
    {
        private const float BonusLongevity = 700;

        public override float ModifySalary(float currentSalary)
        {
            return currentSalary + BonusLongevity;
        }
    }
}
