using Adni.Application.Common.Mappings;
using AutoMapper;
using System;

namespace Adni.Application.Dtos.Student;

public class StudentDto : IMapFrom<Domain.Entities.Student>
{
    //Identity user informations
    public Guid UserId { get; set; }

    //User self information
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public char Gender { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string UserLocation { get; set; }
    public string Dob { get; set; }

    public string? ImageDirectory { get; set; }

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
