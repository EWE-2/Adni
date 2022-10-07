using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using Adni.Domain.Enums;
using Adni.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Student.Commands
{
    public class UpdateStudentInformationsCommand : IRequest
    {
        //Identity user informations
        public Guid UserId { get; set; }

        //User self information
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserLocation { get; set; }
        public string Dob { get; set; }

        public string? ImageDirectory { get; set; }

        public string? Matricule { get; set; }
        public string AcademicYear { get; set; }
        public int AcademicLevel { get; set; }
        public Guid FieldId { get; set; }

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
            var std = await _context.students.FindAsync(request.UserId);

            std.Firstname = (request.Firstname != null) ? request.Firstname : std.Firstname;
            std.Lastname = (request.Lastname != null) ? request.Lastname : std.Lastname;
            std.Email = (request.Email != null) ? request.Email : std.Email;
            std.UserLocation = (request.UserLocation != null) ? request.UserLocation : std.UserLocation;
            std.PhoneNumber = (request.PhoneNumber != null) ? request.PhoneNumber: std.PhoneNumber;
            std.Dob = (request.Dob != null) ? request.Dob : std.Dob;
            std.Gender = request.Gender == 0 ? std.Gender : request.Gender;
            std.Matricule = request.Matricule == null ? std.Matricule : request.Matricule;
            std.ImageDirectory = request.ImageDirectory == null ? std.ImageDirectory : request.ImageDirectory; ;
            std.AcademicYear = request.AcademicYear == null ? std.AcademicYear : request.AcademicYear;
            std.AcademicLevel = request.AcademicLevel == 0 ? std.AcademicLevel : request.AcademicLevel;
            std.FieldId = request.FieldId == Guid.Empty ? std.FieldId : request.FieldId;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
