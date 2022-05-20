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

namespace Adni.Application.EmployeesLists.Commands.CreateEmployeesList
{
    public partial class CreateEmployeesListCommand : IRequest<Guid>
    {
        public string EmployeesPosition { get; set; }
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
            var entity = new EmployeesList { EmployeesPosition = request.EmployeesPosition} ; //passer par les interfaces pour atteindre EmployeesList.EmployeesPosition
            _context.employeesLists.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.EmployeesListId;
        }

    }
}
