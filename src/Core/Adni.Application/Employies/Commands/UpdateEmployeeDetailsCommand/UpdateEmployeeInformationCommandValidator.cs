using Adni.Application.Common.Interfaces;
using FluentValidation;

namespace Adni.Application.Employies.Commands.UpdateEmployeeDetailsCommand;

public class UpdateEmployeeInformationCommandValidator : AbstractValidator<UpdateEmployeeInformationsCommand>
{
    private readonly IApplicationDbContext _context;
    
    public UpdateEmployeeInformationCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Firstname).NotEmpty().WithMessage("Le nom est obligatoire");
        RuleFor(v => v.PhoneNumber).NotEmpty().WithMessage("Le numero de telephone  est obligatoire");
        RuleFor(v => v.WhatsappNumber).NotEmpty().WithMessage("Le numero whatsapp est requis");
    }

}
