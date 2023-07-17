using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainAnalysis.Models
{
    public class ComparisonResult
    {
        public List<MatchModel> MatchList { get; set; }
        public List<ThreadModel> ThreadList { get; set; }
        public class MatchModel
        {
            public int MainId { get; set; }
            public string MainValue { get; set; }
            public int SimilarId { get; set; }
            public string SimilarValue { get; set; }
            public decimal Rate { get; set; }
        }
        public class ThreadModel
        {
            public string Name { get; set; }
            public string Runtime { get; set; }
        }
    }
}
