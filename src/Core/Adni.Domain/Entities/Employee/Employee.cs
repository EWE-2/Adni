using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class Employee :User
    {
        public Guid EmployeeId { get; set; }
        public bool IsOnline { get; set; }
        public string Position { get; set; }

       
    }
}