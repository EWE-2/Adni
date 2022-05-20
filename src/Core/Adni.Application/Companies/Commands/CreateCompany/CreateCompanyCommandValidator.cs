using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Adni.Application.Common.Interfaces;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace Adni.Application.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommandValidator : AbstractValidator<CreateCompanyCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateCompanyCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.CompanyName).NotEmpty().WithMessage("Le nom est obligatoire");
            RuleFor(v => v.CompanyPhonenumber).NotEmpty().WithMessage("Renseignez le numero de telephone");
            RuleFor(v => v.CompanyLocation).NotEmpty().WithMessage("Lieu obligatoire");
            RuleFor(v => v.CompanyFocal).NotEmpty().WithMessage("Le contact du point focal est obligatoire");
        }

        public async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return await _context.companies.AllAsync(l => l.CompanyName != name);
        }
    }
}
