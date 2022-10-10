using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using Adni.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Student.Commands
{
    public class DeleteStudentCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteStudentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.students.FindAsync(request.Id);

            if (entity == null)
                throw new NotFoundException(nameof(Student), request.Id);

            _context.students.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
