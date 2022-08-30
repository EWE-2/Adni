using Adni.Application.Common.Interfaces;
using Adni.Application.Prospections.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class ProspectionController : ApiController
    {
        private readonly IApplicationDbContext _context;

        public ProspectionController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.prospections);
        }

        [HttpPost("Ajouter")]
        public async Task<ActionResult<Guid>> Create(CreateProspectionCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete("Supprimer/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteProspectionCommand { Id = id });
            return NoContent();
        }
        
        [HttpPut("modifier")]
        public async Task<ActionResult> UpdateDetails(Guid id, UpdateProspectionCommandDetails command)
        {
            if (id != command.ProspectionId)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
