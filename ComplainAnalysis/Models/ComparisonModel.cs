using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainAnalysis.Models
{
    public class ComparisonModel
    {
        public int ComplainId { get; set; }
        public string[] Value { get; set; }
        public string Text { get; set; }
        public int WordCount { get; set; }
    }
}
