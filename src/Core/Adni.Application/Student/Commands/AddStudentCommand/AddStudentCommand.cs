using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Student.Commands
{
    public class AddStudentCommand : IRequest<Guid>
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Location { get; set; }
        public string? Phonenumber { get; set; }
        public string? WhatsappNumber { get; set; }
        public string? DoB { get; set; }
        public string? Matricule { get; set; }
        public string AcademicYear { get; set; }
        public int AcademicLevel { get; set; }
        public Guid FieldId { get; set; }
    }

    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public AddStudentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Student
            {
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Email = request.Email,
                Location = request.Location,
                Phonenumber = request.Phonenumber,
                WhatsappNumber = request.WhatsappNumber,
                DoB = request.DoB, 
                Matricule = request.Matricule,
                AcademicYear = request.AcademicYear,
                AcademicLevel = request.AcademicLevel,
                FieldId = request.FieldId
            };

            _context.students.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.StudentId;
        }
    }
}
