using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Adni.Application.Common.Interfaces;
using Adni.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using Adni.Domain.Entities;

namespace Adni.Application.CompanyLists.Commands.DeleteCompanyList
{/*
    public class DeleteCompanyListCommand :IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteCompanyListCommandHandler : IRequestHandler<DeleteCompanyListCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCompanyListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteCompanyListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.companiesLists
                .Where(l => l._companiesListId == request.Id)
                .SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
                throw new NotFoundException(nameof(CompaniesList), request.Id);

            _context.companiesLists.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }*/
}
