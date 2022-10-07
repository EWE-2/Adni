using Adni.Application.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Adni.Application.Dtos.Employee;

public record EmployeeListDto : IMapFrom<Domain.Entities.EmployeesList>
{
    public IList<EmployeeDto> Items { get; set; }
    public Guid Id { get; set; }
    public string UserLocation { get; set; }
    public string Role { get; set; }

    public EmployeeListDto()
    {
        Items = new List<EmployeeDto>();
    }
}
