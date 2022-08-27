using Adni.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.UpdateEmployeeDetailsCommand
{
    public class UpdateEmployeeInformationCommandValidator : AbstractValidator<UpdateEmployeeInformationsCommand>
    {
        private readonly IApplicationDbContext _context;
        
        public UpdateEmployeeInformationCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Firstname).NotEmpty().WithMessage("Le nom est obligatoire");
            RuleFor(v => v.Phonenumber).NotEmpty().WithMessage("Le numero de telephone  est obligatoire");
            RuleFor(v => v.WhatsappNumber).NotEmpty().WithMessage("Le numero whatsapp est requis");
        }

    }
}
