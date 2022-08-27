using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.AlmUser.Command
{
    public class UpdateAlmUserCommand : IRequest
    {
        public Guid AlmUserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string ConfirmedPasswordHash { get; set; }
    }

    public class UpdateAlmUserCommandHandler : IRequestHandler<UpdateAlmUserCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAlmUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateAlmUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.almUsers.FindAsync(request.AlmUserId);

            if (user == null)
                throw new NotFoundException(nameof(Domain.Entities.AlmUser), request.AlmUserId);

            user.UserName = request.UserName;

            if (request.PasswordHash == null)
                user.PasswordHash = user.PasswordHash;
            else if (request.PasswordHash == request.ConfirmedPasswordHash)
                user.PasswordHash = request.PasswordHash;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}