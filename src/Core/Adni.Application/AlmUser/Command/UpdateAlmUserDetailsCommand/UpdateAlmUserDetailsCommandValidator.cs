using Adni.Application.Common.Interfaces;
using FluentValidation;

namespace Adni.Application.AlmUser.Command
{
    public class UpdateAlmUserDetailsCommandValidator : AbstractValidator<UpdateAlmUserCommand>
    {
        private readonly IApplicationDbContext _context;
        
        public UpdateAlmUserDetailsCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.UserName).NotEmpty().WithMessage("Le nom d'utilisation est oblige");
        }
    }
}