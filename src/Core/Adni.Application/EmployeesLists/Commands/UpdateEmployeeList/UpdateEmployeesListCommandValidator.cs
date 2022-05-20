using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Adni.Application.Common.Interfaces;

namespace Adni.Application.EmployeesLists.Commands.UpdateEmployeeList
{
    public class UpdateEmployeesListCommandValidator : AbstractValidator<UpdateEmployeesListCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateEmployeesListCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.EmployeesPosition)
                .NotEmpty().WithMessage("Le poste, role doit etre specifie et est obligatoire");
        }
    }
}
