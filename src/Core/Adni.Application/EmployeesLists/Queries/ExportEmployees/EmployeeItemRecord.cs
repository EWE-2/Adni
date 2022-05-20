using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;

namespace Adni.Application.EmployeesLists.Queries.ExportEmployees
{
    public class EmployeeItemRecord: IMapFrom<Company>
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
