using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class Vehicle
    {
        [Key]
        public int ID { get; set; }

        public string name { get; set; }

        public string branch { get; set; }

        public byte[] picture { get; set; }

        public string status { get; set; }

        public string numberVehicle { get; set; }


    }
}
