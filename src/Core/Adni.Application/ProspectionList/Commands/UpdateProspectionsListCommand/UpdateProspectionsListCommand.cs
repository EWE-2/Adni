using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.ProspectionList.Commands.UpdateProspectionsListCommand
{
    public class UpdateProspectionsListCommand : IRequest
    {
        public Guid ProspectionsListId { get; set; }
        public string? Observation { get; set; }
    }

    public class UpdateProspectionsListCommandHandler : IRequestHandler<UpdateProspectionsListCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateProspectionsListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateProspectionsListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.prospectionsList.FindAsync(request.ProspectionsListId);
            if (entity == null)
                throw new NotFoundException(nameof(ProspectionsList), request.ProspectionsListId);

            entity.Observation = request.Observation;
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
