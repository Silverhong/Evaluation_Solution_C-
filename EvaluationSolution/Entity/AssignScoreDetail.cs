using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class AssignScoreDetail
    {
        [JsonIgnore]
        public string AssignScoreDetailId { get; set; }
        public string AssignScoreId { get; set; }
        public string EvQId { get; set; }
        public string Score { get; set; }

    }
}
