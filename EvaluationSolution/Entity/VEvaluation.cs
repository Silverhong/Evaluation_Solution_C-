using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class VEvaluation
    {
        public string EvId { get; set; }
        public string EvDescription { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string CreatedDate { get; set; }
        public string StaffId { get; set; }
        public string Status { get; set; }
    }
}
