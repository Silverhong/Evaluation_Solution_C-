using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class VEvaluationQuestionDetail
    {
        public int EvQId { get; set; }
        public int EvQDetailId { get; set; }
        public string EvQName { get; set; }
        public int MinScore { get; set; }
        public int MaxScore { get; set; }
        public string Answer { get; set; }
    }
}
