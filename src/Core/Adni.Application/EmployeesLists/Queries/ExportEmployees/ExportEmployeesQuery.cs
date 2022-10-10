using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Adni.Application.Common.Interfaces;
using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Threading;
using Adni.Domain.ValueObjects;

namespace Adni.Application.EmployeesLists.Queries.ExportEmployees
{
    public class ExportEmployeesQuery: IRequest<ExportEmployeesVm>
    {
        public Guid Id { get; set; }
    }

    public class ExportEmployeesHandler : IRequestHandler<ExportEmployeesQuery, ExportEmployeesVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICsvFileBuilder _fileBuilder;

        public ExportEmployeesHandler(IApplicationDbContext context, IMapper mapper, ICsvFileBuilder fileBuilder)
        {
            _context = context;
            _mapper = mapper;
            _fileBuilder = fileBuilder;
        }

        public async Task<ExportEmployeesVm> Handle(ExportEmployeesQuery request, CancellationToken cancellationToken)
        {
            var vm = new ExportEmployeesVm();

            var records = await _context.employees
                .Where(t => t.EmployeeId == request.Id)
                .ProjectTo<EmployeeItemRecord>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken); 

            vm.Content = _fileBuilder.BuildEmployeesFile(records);
            vm.ContentType = "text/csv";
            vm.FileName = "Personnels.csv";

            return await Task.FromResult(vm);
        }
    }
}
