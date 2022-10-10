using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Field.Command.CreateFieldCommand
{
    public class CreateFieldCommandValidator : AbstractValidator<CreateFieldCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateFieldCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.FieldName).NotEmpty().WithMessage("Le nom de la filiere est obligatoire");
            RuleFor(v => v.FieldCigle).NotEmpty().WithMessage("Le cigle est obligatoire")
                .MustAsync(BeUniqueCigle).WithMessage("Ce cigle est déjà utilisé par une autre filière");
        }

        public async Task<bool> BeUniqueCigle(string fieldCigle, CancellationToken cancellationToken)
        {
            return await _context.fields.AllAsync(l => l.FieldCigle != fieldCigle);
        }
    }
}
