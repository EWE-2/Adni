using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Student.Commands;

public class UpdateStudentInformationCommandValidator : AbstractValidator<UpdateStudentInformationsCommand>
{
    private IApplicationDbContext _context;
    
    public UpdateStudentInformationCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Firstname).NotEmpty().WithMessage("Le nom est obligatoire");
        RuleFor(v => v.PhoneNumber).NotEmpty().WithMessage("Le numero de telephone  est obligatoire");
        RuleFor(v => v.Matricule).NotEmpty().WithMessage("Le Matricule est obligatoire");
    }

    public async Task<bool> BeUniqueMatricule(string matricule, CancellationToken cancellationToken)
    {
        return await _context.students.AllAsync(l => l.Matricule != matricule);
    }

}
