using System;
using AutoMapper;
using Adni.Application.Common.Mappings;

namespace Adni.Application.Dtos.Employee
{
    public class EmployeeDto : IMapFrom<Domain.Entities.Employee>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public string DoB { get; set; }
        public Guid EmployeeId { get; set; }
        public bool IsOnline { get; set; }
        public string Role { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Employee, EmployeeDto>()
                .ForMember(d => d.Role, opt => opt.MapFrom(s => (string)s.Role));
        }
    }
}
