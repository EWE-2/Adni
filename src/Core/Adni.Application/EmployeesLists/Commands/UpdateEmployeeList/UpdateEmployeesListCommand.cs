using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Adni.Application.Common.Interfaces;
using System.Threading;
using Adni.Application.Common.Exceptions;

namespace Adni.Application.EmployeesLists.Commands.UpdateEmployeeList
{
    public class UpdateEmployeesListCommand : IRequest
    {
        public Guid Id { get; set; }
        public string EmployeesPosition { get; set; }
    }

    public class UpdateEmployeesListCommandHandler : IRequestHandler<UpdateEmployeesListCommand>
    {
        private readonly IApplicationDbContext _context;
        
        public UpdateEmployeesListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateEmployeesListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.employeesLists.FindAsync(request.Id);
            if (entity == null)
                throw new NotFoundException(nameof(EmployeesLists), request.Id);

            entity.EmployeesPosition = request.EmployeesPosition;
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
