using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Prospections.Commands
{
    public class CreateProspectionCommand : IRequest<Guid>
    {
        public string AcademicYear { get; set; } //Id de la session de stage
        public Guid EmployeeProspectorId { get; set; }
        public Guid CompanyId { get; set; }
        // public IList<Domain.Entities.Department> DesiredDepartmentsList { get; set; }
        // public IList<Domain.Entities.Field> DesiredFields { get; set; }
        // public IList<PlacesDisponibles> PlacesDisponibles { get; set; }
    }

    public class CreateProspectionCommandHandler : IRequestHandler<CreateProspectionCommand, Guid>
    {
        private IApplicationDbContext _context;

        public CreateProspectionCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateProspectionCommand request, CancellationToken cancellationToken)
        {
            var entity = new Prospection
            {
                AcademicYear = request.AcademicYear,
                EmployeeProspectorId = request.EmployeeProspectorId,
                CompanyId = request.CompanyId,
                // DesiredDepartmentsList = request.DesiredDepartmentsList,
                // DesiredFields = request.DesiredFields,
                // PlacesDisponibles = request.PlacesDisponibles,
            };
            _context.prospections.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProspectionId;
        }
    }
}
