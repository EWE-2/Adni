using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Dtos.Prospection
{
    public class ProspectionDto : IMapFrom<Domain.Entities.Prospection>
    {
        public Guid ProspectionId { get; set; }
        public Guid SessionId { get; set; } //Id de la session de stage
        public Guid EmployeeProspectorId { get; set; }
        public Guid CompanyId { get; set; }
        // public IList<DepartmentDto> DesiredDepartmentsList { get; set; }
        public IList<FieldDto> DesiredFields { get; set; }
        public IList<PlacesDisponibles> PlacesDisponibles { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Prospection, ProspectionDto>()
                .ForMember(d => d.EmployeeProspectorId, opt => opt.MapFrom(s => (Guid)s.EmployeeProspectorId));
        }
    }
}
