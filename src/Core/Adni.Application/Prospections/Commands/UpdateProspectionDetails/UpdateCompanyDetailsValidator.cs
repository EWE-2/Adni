using Adni.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Adni.Application.Prospections.Commands
{
    public class UpdateProspectionDetailsValidator : AbstractValidator<UpdateProspectionCommandDetails>
    {
        private readonly IApplicationDbContext _context;

        public UpdateProspectionDetailsValidator(IApplicationDbContext context)
        {
            _context = context;

            // RuleFor(v => v.DesiredDepartmentsList).NotEmpty().WithMessage("Selectionner les departemenent/domaines souhaites est obligatoire");
            //RuleFor(v => v.DesiredFields).NotEmpty().WithMessage("Selectionner les filieres souhaitees");
            RuleFor(v => v.CompanyId).NotEmpty().WithMessage("Selectionnez une entreprise");
        }

        public async Task<bool> BeUniqueName(UpdateProspectionCommandDetails request)
        {
            return await _context.prospections.AllAsync(c => c.CompanyId != request.CompanyId);
        }
    }
}
