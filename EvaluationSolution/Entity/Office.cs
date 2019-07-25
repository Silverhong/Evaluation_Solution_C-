﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class Office
    {
        [JsonIgnore]
        public string OfficeId { get; set; }
        public string OfficeName { get; set; }
        public string DeptId { get; set; }

    }
}
