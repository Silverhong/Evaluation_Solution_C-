using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class AssignScore
    {
        [JsonIgnore]
        public string AssignScoreId { get; set; }
        public string Date { get; set; }
        public string AvgScore { get; set; }
        public string ForAssignId { get; set; }
        public string ByAssignId { get; set; }
        public List<AssignScoreDetail> ListAssignScoreDetails { get; set; }
    }
}
