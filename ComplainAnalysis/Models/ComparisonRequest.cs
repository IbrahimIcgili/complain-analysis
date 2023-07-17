using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainAnalysis.Models
{
    public class ComparisonRequest
    {
        public int? ComplaintId { get; set; }
        public bool IsSameProducts { get; set; }
        public Fields CompareField { get; set; }
        public Fields ValueField { get; set; }
        public int ThresholdRatio { get; set; }
        public int ThreadCount { get; set; }
        public int DataCount { get; set; }
    }
    public enum Fields
    {
        PRODUCT = 1,
        ISSUE = 2,
        COMPANY = 3,
        STATE = 4,
        COMPLAINT_ID = 5,
        ZIP_CODE = 6
    }
}
