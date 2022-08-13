using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Prospections.Commands.CreateProspection
{
    public class CreateProspectionCommandValidator : AbstractValidator<CreateProspectionCommand>
    {
        private IApplicationDbContext _context;

        public CreateProspectionCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.EmployeeProspectorId).NotEmpty().WithMessage("Le prospecteur doit être défini");
            RuleFor(v => v.CompanyId).NotEmpty().WithMessage("L'entreprise prospectee doit etre connue");
            RuleFor(v => v.PlacesDisponibles).NotNull().WithMessage("Pour une filiere selectionnee, le nombre de places voulu ne peut etre nulle");
        }

        public async Task<bool> BeUniqueProspector(Guid prospectorId, CancellationToken cancellationToken)
        {
            return await _context.prospections.AllAsync(l => l.EmployeeProspectorId != prospectorId);
        }
    }
}
