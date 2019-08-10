using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class EvaluationQuestionDetail
    {
        public string EvQId { get; set; }
        [JsonIgnore]
        public string EvQDetailId { get; set; }
        public string EvQName { get; set; }
        public string MinScore { get; set; }
        public string MaxScore { get; set; }
        public string Answer { get; set; }
    }
}
