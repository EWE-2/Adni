using MediatR;
using System;
using Adni.Application.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Adni.Application.ProspectionList.Queries.ExportProspections
{
    public class ExportProspectionsQuery : IRequest<ExportProspectionsVm>
    {
        public Guid Id { get; set; }
    }

    public class ExportProspectionsHandler : IRequestHandler<ExportProspectionsQuery, ExportProspectionsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICsvFileBuilder _fileBuilder;

        public ExportProspectionsHandler(IApplicationDbContext context, IMapper mapper, ICsvFileBuilder fileBuilder)
        {
            _context = context;
            _mapper = mapper;
            _fileBuilder = fileBuilder;
        }

        public async Task<ExportProspectionsVm> Handle(ExportProspectionsQuery request, CancellationToken cancellationToken)
        {
            var vm = new ExportProspectionsVm();

            var records = await _context.prospections
                .Where(r => r.ProspectionId == request.Id)
                .ProjectTo<ProspectionsItemRecord>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            vm.Content = _fileBuilder.BuildProspectionsFile(records);
            vm.ContentType = "text/csv";
            vm.FileName = "Prospections.csv";

            return await Task.FromResult(vm);
        }
    }
}
