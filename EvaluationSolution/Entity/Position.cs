using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class Position
    {
        [JsonIgnore]
        public string Pid { get; set; }
        public string Pname { get; set; }
    }
}
