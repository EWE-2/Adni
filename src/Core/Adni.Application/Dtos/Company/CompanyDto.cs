using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Adni.Domain.Entities;
using Adni.Application.Common.Mappings;

namespace Adni.Application.Dtos.Company
{
    public class CompanyDto : IMapFrom<Domain.Entities.Company>
    {
        public Guid Id { get; private set; }
        public Guid ProspectorId { get; private set; }
        public string CompanyName { get; private set; }
        public string? CompanyDescription { get; private set; }
        public string? CompanyCigle { get; private set; }
        public string CompanyPhonenumber { get; private set; }
        public string? CompanyEmail { get; private set; }
        public string CompanyLocation { get; private set; }
        public string CompanyFocal { get; private set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Company, CompanyDto>()
                .ForMember(d => d.CompanyLocation, opt => opt.MapFrom(s => (string)s.CompanyLocation));
        }

    }
}
