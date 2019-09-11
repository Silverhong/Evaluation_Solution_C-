using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class DailyActivitiesOnStaff
    {
        [JsonIgnore]
        public string StaDAId { get; set; }
        public string Date { get; set; }
        public string TScore { get; set; }
        public string Status { get; set; }
        public string ApprovedDate { get; set; }
        public string ApprovedScore { get; set; }
        public string ApprovedBy { get; set; }
        public string StaffId { get; set; }
        public List<DailyActivitiesDetail> details { get; set; }
    }
}
