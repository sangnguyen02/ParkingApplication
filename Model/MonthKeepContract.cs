using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class MonthKeepContract : Contract
    {
        public string option { get; set; }



        public int? customerID { get; set; }
        public Customer Customer { get; set; }
    }
}
