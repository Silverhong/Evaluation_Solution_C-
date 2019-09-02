using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class AssignStaff
    {
        [JsonIgnore]
        public string Aid { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string EvID { get; set; }
        public string StaffId { get; set; }
    }
}
