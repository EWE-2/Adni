using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Adni.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Adni.Domain.Entities;
using Adni.Domain.Enums;

namespace Adni.Application.EmployeesLists.Commands.CreateEmployeesList
{
    public partial class CreateEmployeesListCommand : IRequest<Guid>
    {
        public string EmployeesRole { get; set; }
        public string Location { get; set; }
    }

    public class CreateEmployeesListCommandHandler : IRequestHandler<CreateEmployeesListCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateEmployeesListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(CreateEmployeesListCommand request, CancellationToken cancellationToken)
        {
            var entity = new EmployeesList
            {
                EmployeesRole = request.EmployeesRole,
                Location = request.Location
            } ; //passer par les interfaces pour atteindre EmployeesList.EmployeesRole
            _context.employeesLists.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.EmployeesListId;
        }

    }
}
