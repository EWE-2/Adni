using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Adni.Application.Common.Interfaces;

namespace Adni.Application.Companies.Commands.UpdateCompanyDetails
{
    public class UpdateCompanyDetailsValidator : AbstractValidator<UpdateCompanyDetailsCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCompanyDetailsValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.CompanyName).NotEmpty().WithMessage("Le nom est obligatoire");
            RuleFor(v => v.CompanyFocal).NotEmpty().WithMessage("Le contact du point focal est obligatoire");
            RuleFor(v => v.CompanyPhonenumber).NotEmpty().WithMessage("Le numero de telephone de l'entreprise est obligatoire");
            RuleFor(v => v.CompanyLocation).NotEmpty().WithMessage("Localisation obligatoire");

        }

        public async Task<bool> BeUniqueName(UpdateCompanyDetailsCommand request)
        {
            return await _context.Companies.AllAsync(c => c.CompanyName != request.CompanyName);
        }
    }
}
