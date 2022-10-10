using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.ProspectionList.Commands.DeleteProspectionsListCommand
{
    public class DeleteProspectionsListCommand : IRequest
    {
        public Guid ProspectionsListId { get; set; }
    }

    public class DeleteProspectionsListCommandHandler : IRequestHandler<DeleteProspectionsListCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteProspectionsListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteProspectionsListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.prospectionsList
                .Where(l => l.ProspectionsListId == request.ProspectionsListId)
                .SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
                throw new NotFoundException(nameof(ProspectionsList), request.ProspectionsListId);

            _context.prospectionsList.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
