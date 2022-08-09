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
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public DateTime DoB { get; set; }
        public bool IsOnline { get; set; }
        public EmployeeRole Role { get; private set; }
    }

    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, Guid>
    {
        private IApplicationDbContext _context;

        public AddEmployeeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emplEntity = new Employee
            {
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Location = request.Location,
                Phonenumber = request.Phonenumber,
                WhatsappNumber = request.WhatsappNumber,
                DoB = request.DoB, 
                Role = request.Role,
                IsOnline = false,
            };

            _context.employees.Add(emplEntity);
            await _context.SaveChangesAsync(cancellationToken);

            return emplEntity.EmployeeId;
        }
    }
}
