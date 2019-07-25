using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class Usergroup
    {
        [JsonIgnore]
        public string UserGroupID { get; set; }
        public string Name { get; set; }
    }
}
