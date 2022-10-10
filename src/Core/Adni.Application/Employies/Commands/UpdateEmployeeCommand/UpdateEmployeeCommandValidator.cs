using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.UpdateEmployeeCommand
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateEmployeeCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Username)
               .NotEmpty().WithMessage("Le nom du personnel est obligatoire")
               .MaximumLength(200).WithMessage("Le nom ne doit depasser 200 caracteres.")
               .MustAsync(BeUniqueName).WithMessage("Ce nom existe deja.");
        }

        public async Task<bool> BeUniqueName(string completeName, CancellationToken cancellationToken)
        {
            return await _context.employees.AllAsync(l => l.UserName == completeName);
        }
    }
}
