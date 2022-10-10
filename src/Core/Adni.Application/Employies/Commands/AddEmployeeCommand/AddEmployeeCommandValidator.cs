using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.AddEmployeeCommand
{
    public class AddEmsployeeCommandValidator : AbstractValidator<AddEmployeeCommand>
    {
        private readonly IApplicationDbContext _context;

        public AddEmsployeeCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.Firstname).NotEmpty().WithMessage("Le nom est obligatoire");
            RuleFor(v => v.PhoneNumber).NotEmpty().WithMessage("Renseignez le numero de telephone");
            RuleFor(v => v.Role).NotEmpty().WithMessage("Le rôle est obligatoire")
                .MustAsync(BeUniqueName).WithMessage("Ce rôle a déjà été attribué");
            RuleFor(v => v.UserLocation).NotEmpty().WithMessage("Le lieu de residence est obligatoire");
        }

        public async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return await _context.employees.AllAsync(l => l.Firstname != name);
        }
    }
}
