using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.AlmUser.Command
{
    public class CreateAlmUserCommandValidator : AbstractValidator<CreateAlmUserCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateAlmUserCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.Firtname).NotEmpty().WithMessage("Nom obligatore");
            RuleFor(v => v.PhoneNumber).NotEmpty().WithMessage("Renseignez le numero de telephone");
            RuleFor(v => v.Lastname).NotEmpty().WithMessage("Le le prenom est obligatoire");
            RuleFor(v => v.Gender).NotEmpty().WithMessage("Sexe requis");
            RuleFor(v => v.Localisation).NotEmpty().WithMessage("Le lieu de residence est obligatoire");
        }

        public async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return await _context.almUsers.AllAsync(l => l.UserName != name);
        }
        public async Task<bool> BeUniqueEmail(string email, CancellationToken cancellationToken)
        {
            return await _context.almUsers.AllAsync(l => l.Email != email);
        }
    }
}