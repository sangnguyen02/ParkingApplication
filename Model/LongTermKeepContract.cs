﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class LongTermKeepContract : Contract
    {
        public bool is_Loan { get; set; }

        public float period { get; set; }

        public string typeContract { get; set; }


    }
}
