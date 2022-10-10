using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Prospections.Commands
{
    public class DeleteProspectionCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteProspectionCommandHandler : IRequestHandler<DeleteProspectionCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteProspectionCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteProspectionCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.prospections.FindAsync(request.Id);
            if (entity == null)
                throw new NotFoundException(nameof(Prospections), request.Id);
            _context.prospections.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
