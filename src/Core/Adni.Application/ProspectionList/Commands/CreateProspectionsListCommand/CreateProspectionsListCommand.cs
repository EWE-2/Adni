using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.ProspectionList.Commands.CreateProspectionsListCommand
{
    public partial class CreateProspectionsListCommand : IRequest<Guid>
    {
        public string? Observation { get; set; }
    }

    public class CreateProspectionsListCommandHandler : IRequestHandler<CreateProspectionsListCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateProspectionsListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateProspectionsListCommand request, CancellationToken cancellationToken)
        {
            var entity = new ProspectionsList { Observation = request.Observation };
            _context.prospectionsList.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProspectionsListId; 
        }
    }
}
