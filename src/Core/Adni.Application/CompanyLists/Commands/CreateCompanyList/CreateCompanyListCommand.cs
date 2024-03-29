﻿using System;
using System.Threading.Tasks;
using MediatR;
using Adni.Application.Common.Interfaces;
using System.Threading;
using Adni.Domain.Entities;

namespace Adni.Application.CompanyLists.Commands.CreateCompanyList;

public partial class CreateCompanyListCommand : IRequest<Guid>
{
    public string City { get; set; }
}

public class CreateCompanyListCommandHandler : IRequestHandler<CreateCompanyListCommand, Guid>
{
    private readonly IApplicationDbContext _context;

    public CreateCompanyListCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Guid> Handle(CreateCompanyListCommand request, CancellationToken cancellationToken)
    {
        var entity = new CompaniesList { City = request.City } ; //passer par les interfaces pour atteindre CompanyList.City
        _context.companiesLists.Add(entity);
        await _context.SaveChangesAsync(cancellationToken);

        return entity.CompaniesListId;
    }

}
