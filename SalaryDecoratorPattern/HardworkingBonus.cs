﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.SalaryDecorator
{
    internal class HardworkingBonus : SalaryDecoratorClass
    {
        private const float BonusHardWorking = 500;

        public override float ModifySalary(float currentSalary)
        {
            return currentSalary + BonusHardWorking;
        }
    }
}
