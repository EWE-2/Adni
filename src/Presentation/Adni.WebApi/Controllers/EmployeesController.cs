using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Adni.Domain.Entities;
using Adni.Data.Contexts;
using System;
using Adni.Application.Employies.Commands.AddEmployeeCommand;
using Adni.Application.Employies.Commands.UpdateEmployeeCommand;
using Adni.Application.Employies.Commands.UpdateEmployeeDetailsCommand;
using Adni.Application.Employies.Commands.DeleteEmployeeCommand;

namespace Adni.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployiesController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public EmployiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.employees);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Create(AddEmployeeCommand command)
        {
            //await _context.Employies.AddAsync(company);
            //await _context.SaveChangeAsync();
            return await Mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteEmployeeCommand { Id = id });
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult> Update(System.Guid id, UpdateEmployeeCommand command)
        {
            if (id != command.EmployeeId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPut("action")]
        public async Task<ActionResult> UpdateDetails(Guid id, UpdateEmployeeInformationsCommand command)
        {
            if (id != command.EmployeeId)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
