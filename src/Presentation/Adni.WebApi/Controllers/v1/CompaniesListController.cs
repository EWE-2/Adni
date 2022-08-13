using Adni.Application.CompanyLists.Commands.CreateCompanyList;
using Adni.Application.CompanyLists.Commands.DeleteCompanyList;
using Adni.Application.CompanyLists.Commands.UpdateCompanyList;
using Adni.Application.CompanyLists.GetCompanies;
using Adni.Application.CompanyLists.Queries.ExportCompanies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class CompaniesListController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<CompaniesVm>> Get()
        {
            return await Mediator.Send(new GetCompaniesQuery());
        }

        [HttpGet("{id}")]
        public async Task<FileResult> Get(Guid id)
        {
            var vm = await Mediator.Send(new ExportCompaniesQuery { Id = id });

            return File(vm.Content, vm.ContentType, vm.FileName);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateCompanyListCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateCompanyListCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteCompanyListCommand { Id = id });

            return NoContent();
        }
    }
}
