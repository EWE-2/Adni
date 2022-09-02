using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Adni.WebApi.Controllers.v2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ApiControllerv2 : ControllerBase
    {
        protected ISender _sender;
        protected ISender Mediator => _sender ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
