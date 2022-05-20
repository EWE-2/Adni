using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Adni.Application.Common.Interfaces;
using Adni.Application.Dtos.Employee;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Adni.Application.EmployeesLists.GetEmployees
{
    public class GetEmployeesQuery : IRequest<EmployeesVm>
    {
    }

    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, EmployeesVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetEmployeesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<EmployeesVm> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            return new EmployeesVm
            {
                Lists = (System.Collections.Generic.IList<EmployeeDto>)await _context.employeesLists
                    .ProjectTo<EmployeeListDto>(_mapper.ConfigurationProvider)
                    .OrderBy(id => id.Id)
                    .ToListAsync(cancellationToken)
            };
        }
    }
}
