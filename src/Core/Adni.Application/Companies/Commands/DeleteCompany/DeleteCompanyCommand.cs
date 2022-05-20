using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Adni.Application.Common.Interfaces;
using Adni.Application.Common.Exceptions;

namespace Adni.Application.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCompanyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.companies.FindAsync(request.Id);
            if (entity == null)
                throw new NotFoundException(nameof(Companies), request.Id);
            _context.companies.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
