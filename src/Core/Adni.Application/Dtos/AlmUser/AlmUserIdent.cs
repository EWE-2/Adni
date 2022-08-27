using Adni.Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Dtos
{
    public class AlmUserDto : IMapFrom<Domain.Entities.AlmUser>
    {
        //Identity user informations
        public Guid AlmUserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }

        //User self information
        public string Firtname { get; set; }
        public string Lastname { get; set; }
        public char Gender { get; set; }
        public Guid FieldId { get; set; }
        public string GraduateYear { get; set; }
        public string PhoneNumber { get; set; }
        public string Dob { get; set; }

        //Professionnal informations
        public string ProStatus { get; set; }
        public Guid CompanyId { get; set; }
        public string Position { get; set; }
        public string Contrat { get; set; }
        public string Localisation { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.AlmUser, AlmUserDto>();
        }
    }
}
