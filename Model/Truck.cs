using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class Truck : Vehicle
    {
        [MaxLength(20)]
        public string licensePlates { get; set; }

        public float tonnage { get; set; }
    }
}
