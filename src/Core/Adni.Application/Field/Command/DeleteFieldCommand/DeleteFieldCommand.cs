using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Field.Command.DeleteFieldCommand
{
    public class DeleteFieldCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteFieldCommandHandler : IRequestHandler<DeleteFieldCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteFieldCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteFieldCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.fields.FindAsync(request.Id);

            if (entity == null)
                throw new NotFoundException(nameof(Field), request.Id);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
