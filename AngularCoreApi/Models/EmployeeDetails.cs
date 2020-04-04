using System;
using System.Collections.Generic;

namespace AngularCoreApi.Models
{
    public partial class EmployeeDetails
    {
        public int EmpId { get; set; }
        public string FullName { get; set; }
        public int ManagerId { get; set; }
        public string DateOfJoining { get; set; }
    }
}
