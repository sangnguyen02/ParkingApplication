﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class KeepWorker : User
    {
        public string cardID { get; set; }

        public string address { get; set; }

        public byte[] picture { get; set; }

        public int? shiftID { get; set; }
        public Shift Shift { get; set; }

        public int? facilityID { get; set; }
        public Facility Facility { get; set; }

        [MaxLength(50)]
        public string facilityKeep { get; set; }
    }
}
