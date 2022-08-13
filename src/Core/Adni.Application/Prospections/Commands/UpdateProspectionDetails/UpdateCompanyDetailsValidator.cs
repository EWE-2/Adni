using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Prospections.Commands.UpdateProspectionDetails
{
    public class UpdateCompanyDetailsValidator : AbstractValidator<UpdateProspectionCommandDetails>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCompanyDetailsValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.DesiredDepartmentsList).NotEmpty().WithMessage("Selectionner les departemenent/domaines souhaites est obligatoire");
            RuleFor(v => v.DesiredFields).NotEmpty().WithMessage("Selectionner les filieres souhaitees");
            RuleFor(v => v.PlacesDisponibles).NotEmpty().WithMessage("Les places disponibles de doivent pas etre nulles");
            RuleFor(v => v.CompanyId).NotEmpty().WithMessage("Selectionnez une entreprise");
        }

        public async Task<bool> BeUniqueName(UpdateProspectionCommandDetails request)
        {
            return await _context.prospections.AllAsync(c => c.CompanyId != request.CompanyId);
        }
    }
}
