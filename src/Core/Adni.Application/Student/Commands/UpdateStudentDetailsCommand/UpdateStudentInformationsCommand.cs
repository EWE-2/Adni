using Adni.Application.Common.Interfaces;
using Adni.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Student.Commands.UpdateStudentDetailsCommand
{
    public class UpdateStudentInformationsCommand : IRequest
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public string DoB { get; set; }
        public Guid StudentId { get; set; }

    }

    public class UpdateStudentInformationsCommandHandler : IRequestHandler<UpdateStudentInformationsCommand>
    {
        private IApplicationDbContext _context;

        public UpdateStudentInformationsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateStudentInformationsCommand request, CancellationToken cancellationToken)
        {
            var std = await _context.students.FindAsync(request.StudentId);

            std.Firstname = request.Firstname;
            std.Lastname = request.Lastname;
            std.Email = request.Email;
            std.Location = request.Location;
            std.Phonenumber = request.Phonenumber;
            std.WhatsappNumber = request.WhatsappNumber;
            std.DoB = request.DoB;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
