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
    public partial class UpdateStudentCommand : IRequest
    {
        public Guid StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Matricule { get; set; }
    }

    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private IApplicationDbContext _context;

        public UpdateStudentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var std = await _context.students.FindAsync(request.StudentId);

            if (std == null)
                throw new NotFoundException(nameof(Domain.Entities.Student), request.StudentId);

            std.Firstname = request.Firstname;
            std.Lastname = request.Lastname;
            std.Matricule = request.Matricule;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
