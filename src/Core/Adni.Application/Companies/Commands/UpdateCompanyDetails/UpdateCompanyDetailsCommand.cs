using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Adni.Application.Common.Interfaces;
using System.Threading;

namespace Adni.Application.Companies.Commands.UpdateCompanyDetails
{
    public class UpdateCompanyDetailsCommand : IRequest
    {
        public Guid Id { get; /*private*/ set; }
        public Guid ProspectorId { get; /*private*/ set; }
        //public Guid CompanyListId { get; /*private*/ set; }
        public string CompanyName { get; /*private*/ set; }
        public string? CompanyDescription { get; /*private*/ set; }
        public string? CompanyCigle { get; /*private*/ set; }
        public string CompanyPhonenumber { get; /*private*/ set; }
        public string? CompanyEmail { get; /*private*/ set; }
        public string CompanyLocation { get; /*private*/ set; }
        public string CompanyFocal { get;/*private*/ set; }
        public bool IsConfirmed { get; set; }
    }

    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyDetailsCommand>
    {
        private IApplicationDbContext _context;

        public UpdateCompanyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCompanyDetailsCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Companies.FindAsync(request.Id);

            entity.ProspectorId = request.ProspectorId;
            entity.CompanyName = request.CompanyName;
            entity.CompanyDescription = request.CompanyDescription;
            entity.CompanyCigle = request.CompanyCigle;
            entity.CompanyPhonenumber = request.CompanyPhonenumber;
            entity.CompanyEmail = request.CompanyEmail;
            entity.CompanyLocation = request.CompanyLocation;
            entity.CompanyFocal = request.CompanyFocal;
            entity.IsConfirmed = request.IsConfirmed;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
