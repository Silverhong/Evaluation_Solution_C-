using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class VDailyActivities
    {
        public string No { get; set; }
        public string Date { get; set; }
        public string Score { get; set; }
        public string Status { get; set; }
        public List<VDailyActivitiesDetail> details { get; set; }
    }
}
