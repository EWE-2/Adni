using System;
using AutoMapper;
using Adni.Application.Common.Mappings;

namespace Adni.Application.Dtos.Employee;

public record EmployeeDto : IMapFrom<Domain.Entities.Employee>
{
    //Identity user informations
    public Guid EmployeeId { get; set; }
    public string? UserName { get; set; }
    public string Email { get; set; }
    public string NormalizedEmail { get; set; }
    public string PasswordHash { get; set; }

    //User self information
    public string Firstname { get; set; }
    public string? Lastname { get; set; }
    public char Gender { get; set; }
    public string? PhoneNumber { get; set; }
    public string? WhatsappNumber { get; set; }
    public string? Dob { get; set; }
    public string? UserLocation { get; set; }

    public string? ImageDirectory { get; set; }

    public bool IsOnline { get; set; }
    public string Role { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Employee, EmployeeDto>()
            .ForMember(d => d.Role, opt => opt.MapFrom(s => (string)s.Role));
    }
}
