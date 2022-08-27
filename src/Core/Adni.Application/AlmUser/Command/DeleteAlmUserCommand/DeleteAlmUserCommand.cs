using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.AlmUser.Command
{
    public class DeleteAlmUserCommand : IRequest
    {
        public Guid AlmUserId { get; set; }
    }

    public class DeleteAlmUserCommandHandler : IRequestHandler<DeleteAlmUserCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAlmUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteAlmUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.almUsers.FindAsync(request.AlmUserId);

            if (user == null)
                throw new NotFoundException(nameof(Domain.Entities.AlmUser), request.AlmUserId);

            _context.almUsers.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}