using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Adni.WebApi.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ApiControllerv2 : ControllerBase
    {
        protected ISender _sender;
        protected ISender Mediator => _sender ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
