using Adni.Application.AlmUser.Command;
using Adni.Application.Common.Interfaces;
using Adni.WebApi.Controllers.v1;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
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

        [HttpGet]
        public async Task<IActionResult> Import()
        {
            var path = Path.Combine(
                _env.ContentRootPath, "Imports/sip.xlsx");
            Console.WriteLine(path);

            using var stream = System.IO.File.OpenRead(path);
            using var excelPackage = new ExcelPackage(stream);

            var worksheet = excelPackage.Workbook.Worksheets[0];

            var nEndRow = worksheet.Dimension.End.Row;

            //initialisation des conmpteurs sur les alumni ajoutés;
            var nbrAlmUserAdded = 0;

            // liste des almUser existant dans la base de donnees
            //var almUserNames = _context.almUsers.AsNoTracking().ToDictionaryAsync(x => x.Firtname, StringComparer.OrdinalIgnoreCase);

            //iteration sur les occurences de la feuille
            for(int nRow = 2; nRow <= nEndRow; nRow++)
            {
                var row = worksheet.Cells[
                    nRow, 1, nRow, worksheet.Dimension.End.Column];

                var email = row[nRow, 5].GetValue<string>();
                var firstname = row[nRow, 1].GetValue<string>();
                var gender = row[nRow, 8].GetValue<char>();
                var graduateYear = row[nRow, 10].GetValue<string>();
                var phoneNumber = row[nRow, 12].GetValue<string>();
                var proStatus = row[nRow, 15].GetValue<string>();
                var companyName = row[nRow, 17].GetValue<string>();
                var position = row[nRow, 19].GetValue<string>();
                var contrat = row[nRow, 21].GetValue<string>();
                var localisation = row[nRow, 23].GetValue<string>();

                //si l'utilisateur existe, passer
                //if (almUserNames.ContainsKey(firstname))
                //    continue;

                var command = new CreateAlmUserCommand
                {
                    UserName = null,
                    Email = email,
                    NormalizedEmail = email.ToLower(),
                    PasswordHash = null,
                    Firtname = firstname,
                    Lastname = null,
                    Gender = gender,
                    FieldId = Guid.Empty,
                    GraduateYear = graduateYear,
                    PhoneNumber = phoneNumber,
                    Dob = null,
                    ProStatus = proStatus,
                    CompanyId = Guid.Empty,
                    Position = position,
                    Contrat = contrat,
                    Localisation = localisation
                };

                //sending a command : adding current alumni to the database
                await Mediator.Send(command);

                nbrAlmUserAdded++;
            }
            return new JsonResult(new
            {
                alumni = nbrAlmUserAdded,
            });
        }
    }
}
