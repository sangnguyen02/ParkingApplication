using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class Accessory
    {
        [Key]
        public int ID { get; set; }

        public string name { get; set; }

        public float? price { get; set; }

        public Accessory()
        {
            this.BillFixes = new HashSet<BillFix>();
        }

        public virtual ICollection<BillFix> BillFixes { get; set; }
    }
}
