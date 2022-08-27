using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Prospections.Commands.CreateProspection
{
    public class CreateProspectionCommand : IRequest<Guid>
    {
        public Guid ProspectionId { get; set; }
        public Guid SessionId { get; set; } //Id de la session de stage
        public Guid EmployeeProspectorId { get; set; }
        public Guid CompanyId { get; set; }
        // public IList<Domain.Entities.Department> DesiredDepartmentsList { get; set; }
        public IList<Domain.Entities.Field> DesiredFields { get; set; }
        public IList<PlacesDisponibles> PlacesDisponibles { get; set; }
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
                ProspectionId = request.ProspectionId,
                SessionId = request.SessionId,
                EmployeeProspectorId = request.EmployeeProspectorId,
                CompanyId = request.CompanyId,
                // DesiredDepartmentsList = request.DesiredDepartmentsList,
                DesiredFields = request.DesiredFields,
                PlacesDisponibles = request.PlacesDisponibles,
            };
            _context.prospections.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProspectionId;
        }
    }
}
