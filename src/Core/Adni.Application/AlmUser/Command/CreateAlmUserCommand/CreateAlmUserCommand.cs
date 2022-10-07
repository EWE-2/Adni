using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.AlmUser.Command
{
    public class CreateAlmUserCommand : IRequest<Guid>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }

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

    public class CreateAlmUserCommandHandler : IRequestHandler<CreateAlmUserCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        
        public CreateAlmUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateAlmUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.Entities.AlmUser
            {
                UserName = request.UserName,
                Email = request.Email,
                NormalizedEmail = request.Email.ToUpper(),
                PasswordHash = request.PasswordHash,

                //User self information
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Gender = request.Gender,
                FieldId = request.FieldId,
                GraduateYear = request.GraduateYear,
                PhoneNumber = request.PhoneNumber,
                Dob = request.Dob,

                //Professionnal informations
                ProStatus = request.ProStatus,
                CompanyId = request.CompanyId,
                Position = request.Position,
                Contrat = request.Contrat,
                UserLocation = request.Localisation
            };
            await _context.almUsers.AddAsync(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user.UserId;

        }
    }
}