using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.DeleteEmployeeCommand
{
    public class DeleteEmployeeCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        private IApplicationDbContext _context;

        public DeleteEmployeeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emplEntity = await _context.employees.FindAsync(request.Id);

            if (emplEntity == null)
                throw new NotFoundException(nameof(Employies), request.Id);

            _context.employees.Remove(emplEntity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
