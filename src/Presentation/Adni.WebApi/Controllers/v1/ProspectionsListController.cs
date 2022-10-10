using Adni.Application.ProspectionList.Commands.CreateProspectionsListCommand;
using Adni.Application.ProspectionList.Commands.DeleteProspectionsListCommand;
using Adni.Application.ProspectionList.Commands.UpdateProspectionsListCommand;
using Adni.Application.ProspectionList.Queries.ExportProspections;
using Adni.Application.ProspectionList.Queries.GetProspections;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class ProspectionsListController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<ProspectionsVm>> Get()
        {
            return await Mediator.Send(new GetProspectionsQuery());
        }

        [HttpGet("{id}")]
        public async Task<FileResult> Get(Guid id)
        {
            var vm = await Mediator.Send(new ExportProspectionsQuery { Id = id });

            return File(vm.Content, vm.ContentType, vm.FileName);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateProspectionsListCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateProspectionsListCommand command)
        {
            if (id != command.ProspectionsListId)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteProspectionsListCommand { ProspectionsListId = id });

            return NoContent();
        }
    }
}
