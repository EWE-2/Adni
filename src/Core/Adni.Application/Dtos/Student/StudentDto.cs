using Adni.Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Dtos.Student
{
    public class StudentDto : IMapFrom<Domain.Entities.Student>
    {
        public Guid StudentId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Location { get; set; }
        public string? Phonenumber { get; set; }
        public string? WhatsappNumber { get; set; }
        public string? DoB { get; set; }
        public string? Matricule { get; set; }
        public string AcademicYear { get; set; }
        public int AcademicLevel { get; set; }
        public Guid FieldId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Student, StudentDto>()
                .ForMember(d => d.FieldId, opt => opt.MapFrom(s => (Guid)s.FieldId));
        }
    }
}
