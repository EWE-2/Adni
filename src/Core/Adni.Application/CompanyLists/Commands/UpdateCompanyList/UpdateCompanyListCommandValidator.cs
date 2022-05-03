using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Adni.Application.Common.Interfaces;

namespace Adni.Application.CompanyLists.Commands.UpdateCompanyList
{
    public class UpdateCompanyListCommandValidator : AbstractValidator<UpdateCompanyListCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCompanyListCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.City)
                .NotEmpty().WithMessage("La ville est obligatoire");
        }
    }
}
