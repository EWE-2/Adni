using Adni.Application.Common.Mappings;
using AutoMapper;
using System;

namespace Adni.Application.Dtos.Prospection;

public record ProspectionDto : IMapFrom<Domain.Entities.Prospection>
{
    public Guid ProspectionId { get; set; }
    public string AcademicYear { get; set; } //Id de la session de stage
    public Guid EmployeeProspectorId { get; set; }
    public Guid CompanyId { get; set; }
    // public IList<DepartmentDto> DesiredDepartmentsList { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Prospection, ProspectionDto>()
            .ForMember(d => d.EmployeeProspectorId, opt => opt.MapFrom(s => (Guid)s.EmployeeProspectorId));
    }
}
