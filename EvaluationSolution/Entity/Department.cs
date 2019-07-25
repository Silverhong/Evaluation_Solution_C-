using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class Department
    {
        [JsonIgnore]
        public string DeptId { get; set; }
        public string Deptname { get; set; }
    }
}
