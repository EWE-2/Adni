using MediatR;
using Adni.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Adni.Domain.Entities;
using Adni.Domain.Interfaces;

namespace Adni.Application.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommand : IRequest<Guid>
    {
        public Guid ProspectorId { get; set; }
        //public Guid CompanyListId { get; set; }
        public string CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? CompanyCigle { get; set; }
        public string CompanyPhonenumber { get; set; }
        public string? CompanyEmail { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyFocal { get; set; }
        public bool IsConfirmed { get; set; }

    }

    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, Guid>
    {
        private IApplicationDbContext _context;

        public CreateCompanyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var entity = new Company
            {
                ProspectorId = request.ProspectorId,
                IsConfirmed = false,
                CompanyName = request.CompanyName,
                CompanyDescription = request.CompanyDescription,
                CompanyCigle = request.CompanyCigle,
                CompanyPhonenumber = request.CompanyPhonenumber,
                CompanyEmail = request.CompanyEmail,
                CompanyLocation = request.CompanyLocation,
                CompanyFocal = request.CompanyFocal,

            };
            _context.companies.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
