using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Field.Command.UpdateFieldCommand
{
    public class UpdateFieldCommandValidator : AbstractValidator<UpdateFieldCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateFieldCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.FieldName)
                .NotEmpty().WithMessage("Le nom est obligatoire")
                .MaximumLength(200).WithMessage("Le nom ne doit depasser 200 caracteres.")
                .MustAsync(BeUniqueName).WithMessage("Ce nom existe deja.");
            RuleFor(v => v.FieldCigle)
                .NotEmpty().WithMessage("Le cigle est obligatoire")
                .MaximumLength(5).WithMessage("Le cigle ne doit pas depasser 5 caracteres.")
                .MustAsync(BeUniqueCigle).WithMessage("Ce cigle existe deja.");
        }

        public async Task<bool> BeUniqueName(string fieldName,CancellationToken cancellationToken)
        {
            return await _context.fields.AllAsync(l => l.FieldName != fieldName);
        }
        public async Task<bool> BeUniqueCigle(string fieldCigle, CancellationToken cancellationToken)
        {
            return await _context.fields.AllAsync(l => l.FieldCigle != fieldCigle);
        }
    }
}
