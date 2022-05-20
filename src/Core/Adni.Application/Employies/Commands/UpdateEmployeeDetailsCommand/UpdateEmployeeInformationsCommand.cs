using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.UpdateEmployeeDetailsCommand
{
    public class UpdateEmployeeInformationsCommand : IRequest
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public DateTime DoB { get; set; }
        public Guid EmployeeId { get; set; }

    }

    public class UpdateEmployeeInformationsCommandHandler : IRequestHandler<UpdateEmployeeInformationsCommand>
    {
        private IApplicationDbContext _context;

        public UpdateEmployeeInformationsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateEmployeeInformationsCommand request, CancellationToken cancellationToken)
        {
            var emplEntity = await _context.employees.FindAsync(request.EmployeeId);

            emplEntity.Firstname = request.Firstname;
            emplEntity.Lastname = request.Lastname;
            emplEntity.Location = request.Location;
            emplEntity.Phonenumber = request.Phonenumber;
            emplEntity.WhatsappNumber = request.WhatsappNumber;
            emplEntity.DoB = request.DoB;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
