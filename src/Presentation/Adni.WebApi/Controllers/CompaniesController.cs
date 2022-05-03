using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Adni.Domain.Entities;
using Adni.Data.Contexts;
using System;
using Adni.Application.Companies.Commands.CreateCompany;
using Adni.Application.Companies.Commands.UpdateCompany;
using Adni.Application.Companies.Commands.UpdateCompanyDetails;
using Adni.Application.Companies.Commands.DeleteCompany;

namespace Adni.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public CompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Companies);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateCompanyCommand command)
        {
            //await _context.Companies.AddAsync(company);
            //await _context.SaveChangeAsync();
            return await Mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteCompanyCommand { Id = id});
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult> Update(System.Guid id,UpdateCompanyCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPut("action")]
        public async Task<ActionResult> UpdateDetails(Guid id, UpdateCompanyDetailsCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
