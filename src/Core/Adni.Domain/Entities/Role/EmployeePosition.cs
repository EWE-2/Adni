using Adni.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class EmployeeRole
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string? Roledescription { get; set; }

        public static explicit operator string(EmployeeRole v)
        {
            v = new EmployeeRole();
            return v.RoleName;
        }
    }
}
