using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Adni.Application.Common.Interfaces;

namespace Adni.Application.EmployeesLists.Commands.CreateEmployeesList
{
    public class CreateEmployeesListCommandValidator : AbstractValidator<CreateEmployeesListCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateEmployeesListCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            RuleFor(v => v.Location)
                .NotEmpty().WithMessage("Le poste est requis")
                .MaximumLength(100).WithMessage("Le nom du poste ne doit pas depasser 5 caracteres.");
            RuleFor(v => v.EmployeesRole)
                .NotEmpty().WithMessage("Le role de cette liste est obligatoire");

        }
    }
}
