using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal abstract class Contract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /*public VehicleInContract vehicleInContract { get; set; }*/

        public string contractID { get; set; }

        public string name { get; set; }

        [MaxLength(50)]
        public string key { get; set; }

        public string description { get; set; }

        public DateTime? dateCreate { get; set; }

        [MaxLength(50)]
        public string status { get; set; }
    }
}
