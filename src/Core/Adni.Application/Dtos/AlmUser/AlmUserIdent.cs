using Adni.Application.Common.Mappings;
using AutoMapper;
using System;

namespace Adni.Application.Dtos;

public record AlmUserDto : IMapFrom<Domain.Entities.AlmUser>
{
    //Identity user informations
    public Guid AlmUserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string NormalizedEmail { get; set; }
    public string PasswordHash { get; set; }

    //User self information
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public char Gender { get; set; }
    public string GraduateYear { get; set; }
    public string PhoneNumber { get; set; }
    public string WhatsappNumber { get; set; }
    public string UserLocation { get; set; }
    public string Dob { get; set; }
    public Guid FieldId { get; set; }

    public string? ImageDirectory { get; set; }

    //Professionnal informations
    public string ProStatus { get; set; }
    public Guid CompanyId { get; set; }
    public string Position { get; set; }
    public string Contrat { get; set; }
    public string CompanyLocation { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.AlmUser, AlmUserDto>();
    }
}

