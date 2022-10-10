using Adni.Application.Common.Interfaces;
using Adni.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.AlmUser.Command;

public class ImportAlmUserCommand : IRequest<int>
{
    public string Path { get; set; }
}

public class ImportAlmUserCommandHandler : IRequestHandler<ImportAlmUserCommand, int>
{
    private IApplicationDbContext _context;

    public ImportAlmUserCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(ImportAlmUserCommand request, CancellationToken cancellationToken)
    {
        using var stream = System.IO.File.OpenRead(request.Path);
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var excelPackage = new ExcelPackage(stream);

        var worksheet = excelPackage.Workbook.Worksheets[0];
        var nEndRow = worksheet.Dimension.End.Row;

        //initialisation des conmpteurs sur les alumni ajoutés;
        var nbrAlmUserAdded = 0;

        // liste des almUser existant dans la base de donnees
        var almUserNames = _context.almUsers
            .AsNoTracking()
            .ToDictionary(x => x.Firstname, StringComparer.OrdinalIgnoreCase);

        //nombre de lignes vides avant arret de l'importation: arret apres 3 lignes vides
        int vRowLimit = 0;

        //iteration sur les occurences de la feuille
        for (int nRow = 6; nRow <= nEndRow; nRow++)
        {
            var row = worksheet.Cells[
                nRow, 1, nRow, worksheet.Dimension.End.Column];

            var firstname = row[nRow, 1].GetValue<string>();
            //Verifications: Si le champ actuel dans le fichiers excel est vide
            if (firstname == null || firstname == "") 
            {
                vRowLimit++;
                if(vRowLimit == 3)
                    break;
                continue;
            }

            var email = row[nRow, 5].GetValue<string>();
            var gender = row[nRow, 8].GetValue<char>();
            var graduateYear = row[nRow, 10].GetValue<string>();
            var phoneNumber = row[nRow, 12].GetValue<string>();
            var proStatus = row[nRow, 15].GetValue<string>();
            var companyName = row[nRow, 17].GetValue<string>();
            var position = row[nRow, 19].GetValue<string>();
            var contrat = row[nRow, 21].GetValue<string>();
            var localisation = row[nRow, 23].GetValue<string>();

            //si l'utilisateur existe, passer
            if (almUserNames.ContainsKey(firstname))
                continue;
            if (almUserNames.ContainsKey(email))
                continue;


            var command = new Domain.Entities.AlmUser
            {
                //UserName = (!(firstname == null))?firstname:"default",
                //Email = (!(email == null)) ? email : "default@company.domain",
                //NormalizedEmail = (!(email == null)) ? email.ToUpper() : "default@company.domain".ToUpper(),
                //PasswordHash = (!(email == null)) ? email : "default",
                //Firtname = (!(firstname == null)) ? firstname : "default",
                //Lastname = (!(firstname == null)) ? firstname : "default",
                UserName = firstname,
                Email = email,
                NormalizedEmail = email.ToUpper(),
                PasswordHash = email,
                Firstname = firstname,
                Lastname = "",
                Gender = gender,
                FieldId = new Guid("92004546-2065-457f-affc-0c39fc371fe6"),
                GraduateYear = graduateYear,
                PhoneNumber = phoneNumber,
                Dob = "Today",
                ProStatus = (!(proStatus == null)) ? proStatus : "Employee",
                CompanyId = new Guid("5d05ae49-bff7-43e7-87fa-53d80743101c"),
                Position = (!(position == null)) ? position : "Undefined",
                Contrat = (!(contrat == null)) ? contrat: "CDD",
                UserLocation = (!(localisation == null)) ? localisation: "Unknow"
            };

            //sending a command : adding current alumni to the database
            await _context.almUsers.AddAsync(command);
            await _context.SaveChangesAsync(cancellationToken);

            nbrAlmUserAdded++;
        }
        return nbrAlmUserAdded;
    }
}

