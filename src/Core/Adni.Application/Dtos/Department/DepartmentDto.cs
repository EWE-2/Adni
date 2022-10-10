using Adni.Application.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Adni.Application.Dtos;

public record DepartmentDto : IMapFrom<Domain.Entities.Department>
{
    public Guid DepartmentId { get; set; }
    public string HeadDepartmentName { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentDescription { get; set; }
    public IList<FieldDto> Fields { get; set; }

    public DepartmentDto()
    {
        Fields = new List<FieldDto>();
    }

    public void Mapping(MappingProfile profile) => profile.CreateMap<Domain.Entities.Department, DepartmentDto>();
}
