﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Infrastructure
{
    public static class ApiFunction
    {
        public static string GetAll { get; set; } = "getAll";
        public static string GetById { get; set; } = "getById";
        public static string Add { get; set; } = "Add";
        public static string DeleteById { get; set; } = "deleteById";
    }
}
