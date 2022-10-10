using Adni.Application.Department.Command;
using Adni.Data.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v1
{
    public class DepartmentController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.departments);
        }

        //[HttpPost("Ajouter")]
        //public async Task<ActionResult<Guid>> Create(CreateDepartmentCommand command)
        //{
        //    //await _context.Companies.AddAsync(company);
        //    //await _context.SaveChangeAsync();
        //    return await Mediator.Send(command);
        //}

        //[HttpDelete("Supprimer/{id}")]
        //public async Task<ActionResult> Delete(Guid id)
        //{
        //    await Mediator.Send(new DeleteDepartmentCommand { Id = id });
        //    return NoContent();
        //}

        //[HttpPut("modifier")]
        //public async Task<ActionResult> Update(System.Guid id, UpdateFieldCommand command)
        //{
        //    if (id != command.FieldId)
        //        return BadRequest();

        //    await Mediator.Send(command);
        //    return NoContent();
        //}
    }
}
