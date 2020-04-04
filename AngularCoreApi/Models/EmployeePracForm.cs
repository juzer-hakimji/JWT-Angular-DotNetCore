using System;
using System.Collections.Generic;

namespace AngularCoreApi.Models
{
    public partial class EmployeePracForm
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpCountry { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
    }
}
