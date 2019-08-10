﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class EvaluationQuestion
    {
        [JsonIgnore]
        public string EvQId { get; set; }
        public string CreatedDate { get; set; }
        public string EvQDescription { get; set; }
        public string StaffId { get; set; }
    }
}
