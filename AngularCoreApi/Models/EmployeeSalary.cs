using System;
using System.Collections.Generic;

namespace AngularCoreApi.Models
{
    public partial class EmployeeSalary
    {
        public int EmpId { get; set; }
        public string Project { get; set; }
        public int Salary { get; set; }
    }
}
