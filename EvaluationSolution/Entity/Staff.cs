using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class Staff
    {
        [JsonIgnore]
        public string StaffId { get; set; }
        public string SName { get; set; }
        public string Sex { get; set; }
        public string Dob { get; set; }
        public string Pob { get; set; }
        public string CurrentAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DeptID { get; set; }
        public string OfficeId { get; set; }
        public string Pid { get; set; }
        public string CreatedBy { get; set; }
        public string UserGroupID { get; set; }
    }
}
