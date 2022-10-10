using FluentValidation;
using Adni.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.ProspectionList.Commands.UpdateProspectionsListCommand
{
    public class UpdateProspectionsListCommandValidator : AbstractValidator<UpdateProspectionsListCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateProspectionsListCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.Observation)
                .MaximumLength(500).WithMessage("L'observation ne doit pas deppaser 500 caracteres");
        }
    }
}
