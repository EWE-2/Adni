using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Adni.Domain.Entities;

namespace Adni.Application.Prospections.Commands.UpdateProspectionDetails
{
    public class UpdateProspectionCommandDetails : IRequest
    {
        public Guid ProspectionId { get; set; }
        public Guid SessionId { get; set; } //Id de la session de stage
        public Guid EmployeeProspectorId { get; set; }
        public Guid CompanyId { get; set; }
        public IList<Department> DesiredDepartmentsList { get; set; }
        public IList<Field> DesiredFields { get; set; }
        public int PlacesDisponibles { get; set; }
    }

    public class UpdateProspectionCommandDetailsHandler : IRequestHandler<UpdateProspectionCommandDetails>
    {
        private readonly IApplicationDbContext _context;

        public UpdateProspectionCommandDetailsHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateProspectionCommandDetails request, CancellationToken cancellationToken)
        {
            var entity = await _context.prospections.FindAsync(request.ProspectionId);

            entity.CompanyId = request.CompanyId;
            entity.DesiredDepartmentsList = request.DesiredDepartmentsList;
            entity.DesiredFields = request.DesiredFields;
            entity.PlacesDisponibles = request.PlacesDisponibles;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
