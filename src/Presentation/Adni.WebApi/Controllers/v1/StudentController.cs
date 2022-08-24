using Adni.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Adni.WebApi.Controllers.v1
{
    public class StudentController : ApiController
    {
        private readonly IApplicationDbContext _context;
    }
}
