using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class EmployeesList
    {
        public IList<Employee> Employees { get; set; }
        public Guid EmployeesListId { get; set; }
        public string EmployeesPosition { get; set; }
        public EmployeesList()
        {
            Employees = new List<Employee>();
        } 
    }
}
