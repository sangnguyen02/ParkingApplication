using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.SalaryDecorator
{
    internal class FineLate : SalaryDecoratorClass
    {
        private const float fineLate = 600;

        public override float ModifySalary(float currentSalary)
        {
            return currentSalary - fineLate;
        }
    }
}
