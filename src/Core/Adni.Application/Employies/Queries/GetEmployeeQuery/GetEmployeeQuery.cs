using Adni.Application.Common.Interfaces;
using Adni.Application.Dtos.Employee;
using Adni.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Queries.GetEmployee
{
    public class GetEmployeeQuery : IRequest<Employee>
    {
        //Identity user informations
        public Guid UserId { get; set; }
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

    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, Employee>
    {
        private readonly IApplicationDbContext _context;

        public GetEmployeeQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
    
        public async Task<Employee> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employee = await _context.employees.FindAsync(request.UserId);

            return employee;
        }
    }
}
