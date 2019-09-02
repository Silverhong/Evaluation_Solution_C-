using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Entity
{
    public class RegisterCompany
    {
        public string Regcom_id { get; set; } = "";
        public string Regcom_name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Admin_Username { get; set; } = "";
        public string Admin_Password { get; set; } = "";
        public string Status { get; set; } = "";
    }
}
