using Adni.Application.AlmUser.Command;
using Adni.Application.Common.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Security;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class AlmUserController : ApiController
    {
        private readonly IWebHostEnvironment _env;
        private IApplicationDbContext _context;

        public AlmUserController(IApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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

        [HttpPost("import")]
        public async Task<ActionResult> Import(ImportAlmUserCommand command)
        {
            var path = Path.Combine(
                _env.ContentRootPath, "Imports\\sip.xlsx");

            if (!_env.IsDevelopment())
                throw new SecurityException("Operation non admise");
            command.Path = path;

            var result = await Mediator.Send(command);

            return new JsonResult(new
            {
                alumniNbr = result
            }); ;
        }
    }
}
