using Adni.Application.Common.Interfaces;
using Adni.Application.Dtos.User;
using Adni.Domain.Entities;
using Adni.Identity.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly List<Employee> _users = new List<Employee>
        {
            new Employee
            {
                EmployeeId = Guid.Parse("5D8E0BDA-6011-4F3F-83E3-350D2CF7D11E"),
                Firstname = "EKE EKE",
                Lastname = "Samule",
                Username = "DrEKE.CDS",
                Password = "MachineL!"
            }
        };

        private readonly AuthSettings _authSettings;
        public UserService(IOptions<AuthSettings> appSettings) => _authSettings = appSettings.Value;

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(u => u.Username == model.UserName && u.Password == model.Password);

            if (user == null)
                return null;

            var token = GenerateJwtToken(user);


            return new AuthenticateResponse(user, token);
        }


        public Employee GetById(Guid id) => _users.FirstOrDefault(u => u.EmployeeId == id);

        private string GenerateJwtToken(Employee user)
        {
            byte[] key = Encoding.ASCII.GetBytes(_authSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.EmployeeId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}
