using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainAnalysis.Models
{
    public class Complain
    {
        public string Product { get; set; }
        public string Issue { get; set; }
        public string Company { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int ComplainId { get; set; }
    }
}
