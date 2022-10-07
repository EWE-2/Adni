using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Student.Commands
{
    public class AddStudentCommandValidator : AbstractValidator<AddStudentCommand>
    {
        private readonly IApplicationDbContext _context;

        public AddStudentCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.Firstname).NotEmpty().WithMessage("Le nom est obligatoire");
            RuleFor(v => v.PhoneNumber).NotEmpty().WithMessage("Renseignez le numero de telephone");
            RuleFor(v => v.Matricule).NotEmpty().WithMessage("Le matricule est obligatoire")
                .MustAsync(BeUniqueName).WithMessage("Ce matricule a déjà été attribué");
            RuleFor(v => v.UserLocation).NotEmpty().WithMessage("Le lieu de residence est obligatoire");
        }

        public async Task<bool> BeUniqueName(string matricule, CancellationToken cancellationToken)
        {
            return await _context.students.AllAsync(l => l.Matricule != matricule);
        }
    }
}
