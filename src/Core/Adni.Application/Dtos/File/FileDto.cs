using Adni.Domain.Enums;
using System;
using AutoMapper;
using Adni.Domain.Entities;

namespace Adni.Application.Dtos.File;

public record FileDto
{
    public Guid Id { get; set; }
    public string FileName { get; set; }
    public byte[] Data { get; set; }
    public FileType FileType { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.FileDetails, FileDetails>()
            .ForMember(d => d.Id, opt => opt.MapFrom(s => (Guid)s.Id));
    }
}

