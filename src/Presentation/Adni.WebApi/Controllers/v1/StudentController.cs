using System.Threading.Tasks;
using Adni.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Adni.Application.Student.Commands;

namespace Adni.WebApi.Controllers.v1
{
    public class StudentController : ApiController
    {
        private readonly IApplicationDbContext _context;

        public StudentController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.students);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_context.students.FindAsync(id));
        }

        [HttpPost("ajouter")]
        public async Task<ActionResult<Guid>> Create(AddStudentCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteStudentCommand { Id = id });
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateStudentCommand command)
        {
            if(id != command.StudentId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPut("action")]
        public async Task<ActionResult> UpdateDetails(Guid id, UpdateStudentInformationsCommand command)
        {
            if (id != command.StudentId)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
