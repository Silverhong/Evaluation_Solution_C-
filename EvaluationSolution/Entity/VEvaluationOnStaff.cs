using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class VEvaluationOnStaff
    {
        public string AssignId { get; set; }
        public string EvaDescription { get; set; }
        public List<VEvaluationOnStaffQuestion> Questions { get; set; }
        public List<VEvaluationOnStaffStaff> Staff { get; set; }
    }
}
