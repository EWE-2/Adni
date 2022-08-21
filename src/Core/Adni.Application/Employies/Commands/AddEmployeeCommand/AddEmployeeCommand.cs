using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using Adni.Domain.Enums;
using Adni.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.AddEmployeeCommand
{
    public class AddEmployeeCommand : IRequest<Guid>
    {
        public bool IsOnline { get; set; }
        public string Role { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public string DoB { get; set; }
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
                IsOnline = false,
                Role = request.Role,
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Username = request.Username,
                Password = request.Password,
                Location = request.Location,
                Phonenumber = request.Phonenumber,
                WhatsappNumber = request.WhatsappNumber,
                DoB = request.DoB, 
            };

            _context.employees.Add(emplEntity);
            await _context.SaveChangesAsync(cancellationToken);

            return emplEntity.EmployeeId;
        }
    }
}
