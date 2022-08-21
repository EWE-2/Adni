using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Adni.Data.Contexts;
using System;
using Adni.Application.Companies.Commands.CreateCompany;
using Adni.Application.Companies.Commands.UpdateCompany;
using Adni.Application.Companies.Commands.UpdateCompanyDetails;
using Adni.Application.Companies.Commands.DeleteCompany;

namespace Adni.WebApi.Controllers.v1
{
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
            return Ok(_context.companies);
        }
        [HttpPost("Ajouter")]
        public async Task<ActionResult<Guid>> Create(CreateCompanyCommand command)
        {
            //await _context.Companies.AddAsync(company);
            //await _context.SaveChangeAsync();
            return await Mediator.Send(command);
        }

        [HttpDelete("Supprimer/{id}")]
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

        [HttpPut("modifierdetails")]
        public async Task<ActionResult> UpdateDetails(Guid id, UpdateCompanyDetailsCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
