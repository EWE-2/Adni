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
            var employee = await _context.employees.FindAsync(request.EmployeeId);

            return employee;
        }
    }
}
