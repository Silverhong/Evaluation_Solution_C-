﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class EvaluationType
    {
        [JsonIgnore]
        public string EvTId { get; set; }
        public string EvTName { get; set; }
    }
}
