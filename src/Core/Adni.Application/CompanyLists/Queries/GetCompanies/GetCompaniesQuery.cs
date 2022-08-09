using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Adni.Application.Common.Interfaces;
using Adni.Application.Dtos.Company;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Adni.Application.CompanyLists.GetCompanies
{
    public class GetCompaniesQuery : IRequest<CompaniesVm>
    {
    }

    public class GetCompaniesQueryHandler : IRequestHandler<GetCompaniesQuery, CompaniesVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetCompaniesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CompaniesVm> Handle(GetCompaniesQuery request, CancellationToken cancellationToken)
        {
            return new CompaniesVm
            {
                Lists = (System.Collections.Generic.IList<CompanyDto>)await _context.companiesLists
                    .ProjectTo<CompanyListDto>(_mapper.ConfigurationProvider)
                    .OrderBy(id => id.Id)
                    .ToListAsync(cancellationToken)
            };
        }
    }
}
