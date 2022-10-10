using Adni.Application.EmployeesLists.Commands.CreateEmployeesList;
using Adni.Application.EmployeesLists.Commands.DeleteCompanyList;
using Adni.Application.EmployeesLists.Commands.UpdateEmployeeList;
using Adni.Application.EmployeesLists.GetEmployees;
using Adni.Application.EmployeesLists.Queries.ExportEmployees;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class EmployeesListController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<EmployeesVm>> Get()
        {
            return await Mediator.Send(new GetEmployeesQuery());
        }

        [HttpGet("{id}")]
        public async Task<FileResult> Get(Guid id)
        {
            var vm = await Mediator.Send(new ExportEmployeesQuery { Id = id });

            return File(vm.Content, vm.ContentType, vm.FileName);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateEmployeesListCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateEmployeesListCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteEmployeesListCommand { Id = id });

            return NoContent();
        }
    }
}
