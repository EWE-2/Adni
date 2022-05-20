using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Adni.Application.Common.Interfaces;
using Adni.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using Adni.Domain.Entities;

namespace Adni.Application.EmployeesLists.Commands.DeleteCompanyList
{
    public class DeleteEmployeesListCommand :IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteCompanyListCommandHandler : IRequestHandler<DeleteEmployeesListCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCompanyListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteEmployeesListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.employeesLists
                .Where(l => l.EmployeesListId == request.Id)
                .SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
                throw new NotFoundException(nameof(EmployeesList), request.Id);

            _context.employeesLists.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
