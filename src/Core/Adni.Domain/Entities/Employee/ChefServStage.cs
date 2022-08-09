using System;
using System.Collections.Generic;
using Adni.Domain;
using Adni.Domain.Enums;

namespace Adni.Domain.Entities
{
    public class ChefServStage : Employee
    {
        public bool IsOnline { get; set; }
        public EmployeeRole Role { get; set; }

    }
}