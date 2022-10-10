using Adni.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class EmployeesList
    {
        public Guid EmployeesListId { get; set; }
        public IList<Employee> Employees { get; set; }
        public string EmployeesRole { get; set; }
        public string Location { get; set; }

        public EmployeesList()
        {
            Employees = new List<Employee>();
        }

    }
}
