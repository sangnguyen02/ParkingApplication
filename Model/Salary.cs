using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class Salary
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int salaryID { get; set; }
        public float? BasicSalary { get; set; }
        public string role { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<FixWorker> FixWorkers { get; set; }
        public virtual ICollection<KeepWorker> KeepWorkers { get; set; }
        
    }
}
