using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;
using AutoMapper;
using System;

namespace Adni.Application.Dtos
{
    public class FieldDto : IMapFrom<Domain.Entities.Field>
    {
        public Guid FieldId { get; set; }
        public string? FieldName { get; set; }
        public string? FieldDescription { get; set; }
        public string? FieldCigle { get; set; }

        public Guid DepartmentId { get; set; }
        public Domain.Entities.Department Department { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Field, FieldDto>()
                .ForMember(d => d.DepartmentId, opt => opt.MapFrom(s => (Guid)s.DepartmentId));
        }
    }
}
