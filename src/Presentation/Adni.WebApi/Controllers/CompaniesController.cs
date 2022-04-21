using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Adni.Domain.Entities;
using Adni.Data.Contexts;

namespace Adni.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly CompanyDbContext _context;
        public CompaniesController(CompanyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Companies);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return Ok(company);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] System.Guid id)
        {
            var company = await _context.Companies.SingleOrDefaultAsync( cp => cp.Id == id);
            if (company == null)
                return NotFound();
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return Ok(company);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] System.Guid id, [FromBody] Company company)
        {
            _context.Update(company);
            await _context.SaveChangesAsync();
            return Ok(company);
        }
    }
}
