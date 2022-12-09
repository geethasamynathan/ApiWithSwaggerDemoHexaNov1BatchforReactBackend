﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiWithSwaggerDemo.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
    }
}
