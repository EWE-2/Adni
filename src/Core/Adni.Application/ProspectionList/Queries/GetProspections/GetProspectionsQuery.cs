using MediatR;
using System;
using Adni.Application.Common.Interfaces;
using Adni.Application.Common.Mappings;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Adni.Application.Dtos.Prospection;
using Microsoft.EntityFrameworkCore;

namespace Adni.Application.ProspectionList.Queries.GetProspections
{
    public class GetProspectionsQuery : IRequest<ProspectionsVm>
    {
    }

    public class GetProspectionsQueryHandler : IRequestHandler<GetProspectionsQuery, ProspectionsVm>
    {
        private IApplicationDbContext _context;
        private IMapper _mapper;

        public GetProspectionsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProspectionsVm> Handle(GetProspectionsQuery request, CancellationToken cancellationToken)
        {
            return new ProspectionsVm
            {
                Lists = (IList<ProspectionsVm>)await _context.prospections
                .ProjectTo<ProspectionsListDto>(_mapper.ConfigurationProvider)
                .OrderBy(id => id.ProspectionsListId)
                .ToListAsync(cancellationToken)
            };
        }
    }
}
