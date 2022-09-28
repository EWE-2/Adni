using Adni.Application.AlmUser.Command;
using Adni.Application.Common.Interfaces;
using Adni.WebApi.Controllers.v1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Security;
using System.Threading.Tasks;

namespace Adni.WebApi.Controllers.v2
{
    public class AlumniUserController : ApiController
    {
        private IApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AlumniUserController(IApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        //[HttpPost("import")]
        //public async Task<IActionResult> Import(ImportAlmUserCommand command)
        //{
        //    var path = Path.Combine(
        //        _env.ContentRootPath, "Imports/sip2.xlsx");

        //    if(!_env.IsDevelopment())
        //        throw new SecurityException("Not allowed");
        //    command.Path = path;

        //    var result = await Mediator.Send(command);

        //    return new JsonResult(new
        //    {
        //        alumniNbr = result
        //    }); ;
        //}
    }
}
