using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.AlmUser.Command
{
    public class UpdateAlmUserDetailsCommand : IRequest
    {
        public Guid AlmUserId { get; set; }
        public string UserName { get; set; }

        //User self information
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Gender { get; set; }
        public Guid FieldId { get; set; }
        public string GraduateYear { get; set; }
        public string PhoneNumber { get; set; }
        public string Dob { get; set; }

        //Professionnal informations
        public string ProStatus { get; set; }
        public Guid CompanyId { get; set; }
        public string Position { get; set; }
        public string Contrat { get; set; }
        public string Localisation { get; set; }
    }

    public class UpdateAlmDetailsCommandHandler : IRequestHandler<UpdateAlmUserDetailsCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAlmDetailsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateAlmUserDetailsCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.almUsers.FindAsync(request.AlmUserId);

            user.PhoneNumber = request.PhoneNumber;
            user.Firtname = request.Firstname;
            user.UserName = request.UserName;
            user.Gender = request.Gender;
            user.GraduateYear = request.GraduateYear;
            user.Lastname = request.Lastname;
            user.FieldId = request.FieldId;
            user.Localisation = request.Localisation;
            user.Dob = request.Dob;
            user.ProStatus = request.ProStatus;
            user.CompanyId = request.CompanyId;
            user.Contrat = request.Contrat;
            user.Position = request.Position;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}