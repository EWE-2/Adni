using Adni.Application.AlmUser.Command;
using Adni.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class AlmUserController : ApiController
    {
        private IApplicationDbContext _context;

        public AlmUserController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.almUsers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_context.almUsers.FindAsync(id));
        }

        [HttpPost("ajouter")]
        public async Task<ActionResult<Guid>> Create(CreateAlmUserCommand command)
        {
            //await _context.Employies.AddAsync(company);
            //await _context.SaveChangeAsync();
            return await Mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteAlmUserCommand { AlmUserId = id });
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult> Update(Guid id, UpdateAlmUserCommand command)
        {
            if (id != command.AlmUserId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPut("updatedetails")]
        public async Task<ActionResult> UpdateDetails(Guid id, UpdateAlmUserDetailsCommand command)
        {
            if (id != command.AlmUserId)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
