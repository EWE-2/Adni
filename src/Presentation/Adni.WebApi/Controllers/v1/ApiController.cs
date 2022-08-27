using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;

namespace Adni.WebApi.Controllers.v1
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private ISender _sender;
        protected ISender Mediator => _sender ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
