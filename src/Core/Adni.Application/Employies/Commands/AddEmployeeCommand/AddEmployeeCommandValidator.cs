using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.AddEmployeeCommand
{
    public class AddEmployeeCommandValidator : AbstractValidator<AddEmployeeCommand>
    {
        private readonly IApplicationDbContext _context;

        public AddEmployeeCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.Firstname).NotEmpty().WithMessage("Le nom est obligatoire");
            RuleFor(v => v.Phonenumber).NotEmpty().WithMessage("Renseignez le numero de telephone");
            RuleFor(v => v.Role).NotEmpty().WithMessage("Le role est obligatoire");
            RuleFor(v => v.Location).NotEmpty().WithMessage("Le lieu de residence est obligatoire");
        }

        public async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return await _context.employees.AllAsync(l => l.Firstname != name);
        }
    }
}
