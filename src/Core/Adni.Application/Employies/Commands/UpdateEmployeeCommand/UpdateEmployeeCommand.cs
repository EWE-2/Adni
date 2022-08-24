using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using Adni.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.UpdateEmployeeCommand
{
    public partial class UpdateEmployeeCommand : IRequest
    {
        public Guid EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private IApplicationDbContext _context;

        public UpdateEmployeeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employies = await _context.employees.FindAsync(request.EmployeeId);

            if (employies == null)
                throw new NotFoundException(nameof(Employies), request.EmployeeId);

            employies.Username = request.Username;
            if (request.Password == null)
                employies.Password = employies.Password;
            else
                employies.Username = request.Password;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
