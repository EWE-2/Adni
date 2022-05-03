using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
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
        public string Firstname { get; set; }
        public string Lastname { get; set; }
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
            var employies = await _context.Employees.FindAsync(request.EmployeeId);

            if (employies == null)
                throw new NotFoundException(nameof(Employies), request.EmployeeId);

            employies.Firstname = request.Firstname;
            employies.Lastname = request.Lastname;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
