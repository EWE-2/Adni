using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;
using Adni.Domain.Enums;

namespace Adni.Application.EmployeesLists.Queries.ExportEmployees
{
    public class EmployeeItemRecord: IMapFrom<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
    }
}
