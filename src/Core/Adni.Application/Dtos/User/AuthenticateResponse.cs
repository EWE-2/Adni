using Adni.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Dtos.User
{
    public class AuthenticateResponse
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }

        
        public AuthenticateResponse(Adni.Domain.Entities.Employee user, string token)
        {
            Id = user.EmployeeId;
            Firstname = user.Firstname;
            Lastname = user.Lastname;
            Username = user.Username;
            Token = token;
        }
    }
}
