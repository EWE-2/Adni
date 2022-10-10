using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.AlmUser.Command;

public class UpdateAlmUserCommandValidator : AbstractValidator<UpdateAlmUserCommand>
{
    private IApplicationDbContext _context;

    public UpdateAlmUserCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.UserName)
           .NotEmpty().WithMessage("Le nom du personnel est obligatoire")
           .MaximumLength(200).WithMessage("Le nom ne doit depasser 200 caracteres.")
           .MustAsync(BeUniqueName).WithMessage("Ce nom existe deja.");
    }

    public async Task<bool> BeUniqueName(string username, CancellationToken cancellationToken)
    {
        return await _context.almUsers.AllAsync(l => l.UserName == username);
    }
}