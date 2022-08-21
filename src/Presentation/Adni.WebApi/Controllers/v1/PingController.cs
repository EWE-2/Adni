using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Adni.WebApi.Controllers.v1
{
    public class PingController : ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("pong");
        }
    }
}
