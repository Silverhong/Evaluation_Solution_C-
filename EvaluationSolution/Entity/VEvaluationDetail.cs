﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class VEvaluationDetail
    {
        public List<VEvaluationQuestion> VEvaluationQuestion { get; set; }
        public List<VEvaluationDetailStaff> vEvaluationDetailStaff { get; set; }
    }
}
