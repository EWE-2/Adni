﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public Guid HeadDepartmentId { get; set; }
        public string Departmentname { get; set; }
        public string DepartmentDescription { get; set; }
    
    }
}
