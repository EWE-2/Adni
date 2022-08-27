using System;
using AutoMapper;
using Adni.Application.Common.Mappings;

namespace Adni.Application.Dtos
{
    public class CompanyDto : IMapFrom<Domain.Entities.Company>
    {
        public Guid Id { get; set; }
        public Guid ProspectorId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyCigle { get; set; }
        public string CompanyPhonenumber { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyFocal { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Company, CompanyDto>()
                .ForMember(d => d.CompanyLocation, opt => opt.MapFrom(s => (string)s.CompanyLocation));
        }

    }
}
