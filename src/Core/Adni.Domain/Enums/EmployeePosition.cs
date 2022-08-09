using Adni.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Enums
{
    public class EmployeeRole
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string Roledescription { get; set; }

        public static explicit operator string(EmployeeRole v)
        {
            //throw new NotImplementedException();
            v = new EmployeeRole();
            return v.RoleName;
        }
    }
}
