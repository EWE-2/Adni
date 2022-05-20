using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Adni.Application.Common.Interfaces;

namespace Adni.Application.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandValidator : AbstractValidator<UpdateCompanyCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCompanyCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Name)
                .NotEmpty().WithMessage("Le nom est obligatoire")
                .MaximumLength(200).WithMessage("Le nom ne doit depasser 200 caracteres.")
                .MustAsync(BeUniqueName).WithMessage("Ce nom existe deja.");
        }

        public async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
        {
            return await _context.companies.AllAsync(l => l.CompanyName != name);
        }
    }
}
