using Adni.Application.Field.Command.CreateFieldCommand;
using Adni.Application.Field.Command.DeleteFieldCommand;
using Adni.Application.Field.Command.UpdateFieldCommand;
using Adni.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class FieldController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public FieldController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.fields);
        }

        [HttpPost("Ajouter")]
        public async Task<ActionResult<Guid>> Create(CreateFieldCommand command)
        {
            //await _context.Companies.AddAsync(company);
            //await _context.SaveChangeAsync();
            return await Mediator.Send(command);
        }

        [HttpDelete("Supprimer/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteFieldCommand { Id = id });
            return NoContent();
        }

        [HttpPut("modifier")]
        public async Task<ActionResult> Update(System.Guid id, UpdateFieldCommand command)
        {
            if (id != command.FieldId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }
    }
}
