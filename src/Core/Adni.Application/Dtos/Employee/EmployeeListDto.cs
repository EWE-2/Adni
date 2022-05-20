using Adni.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Dtos.Employee
{
    public class EmployeeListDto : IMapFrom<Domain.Entities.EmployeesList>
    {
        public IList<EmployeeDto> Items { get; set; }
        public Guid Id { get; set; }
        public string Position { get; set; }

        public EmployeeListDto()
        {
            Items = new List<EmployeeDto>();
        }
    }
}
