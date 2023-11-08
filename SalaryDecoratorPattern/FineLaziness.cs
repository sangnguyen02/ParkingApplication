using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.SalaryDecorator
{
    internal class FineLaziness : SalaryDecoratorClass
    {
        private const float fineLaziness = 800;

        public override float ModifySalary(float currentSalary)
        {
            return currentSalary - fineLaziness;
        }
    }
}
