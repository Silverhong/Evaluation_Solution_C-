using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Infrastructure
{
    public static class ApiRouting
    {
        public static string Protocol { get; set; } = "http://";
        public static string Domain { get; set; } = "localhost";
        public static string Port { get; set; } = "5000";
        public static string Type { get; set; }
        public static string Function { get; set; }
        public static StringBuilder GetUrl(string domain="",string port="",string type="",string function="")
        {
            StringBuilder url = new StringBuilder();
            if (type != "" && function != "")
            {
                Type = type;
                Function = function;
            }
            return url.Append($"{Protocol}{Domain}:{Port}/{Type}/{Function}");
        }
    }
}
