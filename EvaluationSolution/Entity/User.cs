﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class User
    {
        [JsonIgnore]
        public string UserId { get; set; }
        public string Regcom_id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Created_date { get; set; }
        public string Status { get; set; }
        public string StaffId { get; set; }
        public string Role { get; set; }
    }
}
