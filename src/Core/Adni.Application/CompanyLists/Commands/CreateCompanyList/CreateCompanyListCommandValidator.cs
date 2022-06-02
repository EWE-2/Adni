using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Adni.Application.Common.Interfaces;

namespace Adni.Application.CompanyLists.Commands.CreateCompanyList
{/*
    public class CreateCompanyListCommandValidator : AbstractValidator<CreateCompanyListCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateCompanyListCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.City)
                .NotEmpty().WithMessage("La ville est requise.")
                .MaximumLength(100).WithMessage("Le nom de la ville ne doit pas depasser 40 caracteres.");

        }
    }*/
}
