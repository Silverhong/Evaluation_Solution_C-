using System;
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
        public static string checkExist { get; set; } = "CheckExist";
        public static string GetByEvId { get; set; } = "getByEvId";
        public static string GetByStaffId { get; set; } = "getByStaffId";
        public static string UpdateStatusByAid { get; set; } = "updateStatusByAid";
        public static string GetEvByStaffId { get; set; } = "getEvByStaffId";
        public static string GetAllByManager { get; set; } = "getAllByManager";
        public static string GetByStaDAId { get; set; } = "getByStaDAId";

    }
}
