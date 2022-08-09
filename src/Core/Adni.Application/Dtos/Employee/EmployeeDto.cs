using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using Adni.Application.Common.Mappings;
using Adni.Domain.ValueObjects;
using Adni.Domain.Enums;

namespace Adni.Application.Dtos.Employee
{
    public class EmployeeDto : IMapFrom<Domain.Entities.Employee>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public DateTime DoB { get; set; }
        public Guid EmployeeId { get; set; }
        public bool IsOnline { get; set; }
        public EmployeeRole Role { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Employee, EmployeeDto>()
                .ForMember(d => d.Role, opt => opt.MapFrom(s => (string)s.Role));
        }
    }
}
