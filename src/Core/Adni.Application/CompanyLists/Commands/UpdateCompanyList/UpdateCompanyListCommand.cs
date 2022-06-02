using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Adni.Application.Common.Interfaces;
using System.Threading;
using Adni.Application.Common.Exceptions;

namespace Adni.Application.CompanyLists.Commands.UpdateCompanyList
{/*
    public class UpdateCompanyListCommand : IRequest
    {
        public Guid Id { get; set; }
        public string City { get; set; }
    }

    public class UpdateCompanyListCommandHandler : IRequestHandler<UpdateCompanyListCommand>
    {
        private readonly IApplicationDbContext _context;
        
        public UpdateCompanyListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCompanyListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.companiesLists.FindAsync(request.Id);
            if (entity == null)
                throw new NotFoundException(nameof(CompanyLists), request.Id);

            entity.City = request.City;
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }*/
}
