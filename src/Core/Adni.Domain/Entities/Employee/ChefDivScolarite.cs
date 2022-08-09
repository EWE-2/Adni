using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain;
using Adni.Domain.Enums;
using Adni.Domain.ValueObjects;

namespace Adni.Domain.Entities
{
    public class ChefDivScolarite : Employee
    {
        public bool IsOnline { get; set; }
        public EmployeeRole Role { get; set; }

    }
}