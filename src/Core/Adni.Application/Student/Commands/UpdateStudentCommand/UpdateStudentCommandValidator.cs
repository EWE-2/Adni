using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Student.Commands
{
    public class UpdateStudentCommandValidator : AbstractValidator<UpdateStudentCommand>
    {
        private IApplicationDbContext _context;

        public UpdateStudentCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Matricule)
               .NotEmpty().WithMessage("Le nom du personnel est obligatoire")
               .MaximumLength(200).WithMessage("Le nom ne doit depasser 200 caracteres.")
               .MustAsync(BeUniqueMatricule).WithMessage("Ce nom existe deja.");
        }

        public async Task<bool> BeUniqueMatricule(string matricule, CancellationToken cancellationToken)
        {
            return await _context.students.AllAsync(l => l.Matricule == matricule);
        }
    }
}
