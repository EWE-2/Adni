using Adni.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class Employee : User
    {
        public bool IsOnline { get; set; }
        public EmployeeRole Role { get; set; }

       
    }
}