using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class Evaluation
    {
        [JsonIgnore]
        public string EvId { get; set; }
        public string EvDescription { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string CreatedDate { get; set; }
        public string StaffId { get; set; }
        public string Status { get; set; }
        public string EvTId {get;set;}
    }
}
