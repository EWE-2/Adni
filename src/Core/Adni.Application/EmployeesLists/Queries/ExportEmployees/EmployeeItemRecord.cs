using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;

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
