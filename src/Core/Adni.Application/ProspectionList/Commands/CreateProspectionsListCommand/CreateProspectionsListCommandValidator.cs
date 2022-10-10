using Adni.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.ProspectionList.Commands.CreateProspectionsListCommand
{
    public class CreateProspectionsListCommandValidator : AbstractValidator<CreateProspectionsListCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateProspectionsListCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.Observation)
                .MaximumLength(500).WithMessage("Les observations ne peuvent dépasser 500 caractères");
        }
    }
}
