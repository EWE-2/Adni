using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.AddEmployeeCommand
{
    public class AddEmployeeCommand : IRequest<Guid>
    {
        //Identity user informations
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
    }

    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public AddEmployeeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emplEntity = new Employee
            {
                UserName = request.UserName,
                Email = request.Email,
                NormalizedEmail = request.NormalizedEmail,
                PasswordHash = request.PasswordHash,

                //User se = request.EmployeeId,
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Gender = request.Gender,
                PhoneNumber = request.PhoneNumber,
                WhatsappNumber = request.WhatsappNumber,
                Dob = request.Dob,
                UserLocation = request.UserLocation,

                ImageDirectory = request.ImageDirectory,

                IsOnline = false,
                Role = request.Role
                 
            };

            _context.employees.Add(emplEntity);
            await _context.SaveChangesAsync(cancellationToken);

            return emplEntity.EmployeeId;
        }
    }
}
