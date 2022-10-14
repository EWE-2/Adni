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

        //Identifiant de la filiere
        Guid ui = new Guid();

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
            var field = row[nRow, 9].GetValue<string>();

            //si l'utilisateur existe, passer
            if (almUserNames.ContainsKey(firstname))
                continue;
            if (almUserNames.ContainsKey(email))
                continue;

            //repartir l'utilisateur dans les filieres
            switch (field)
            {
                case "TTIC":
                    ui = new Guid("04a083bd-2b54-4861-90a7-1d55ea874393");
                    break;
                case "ROI":
                    ui = new Guid("f205d735-598f-43c2-93e8-0db5cc63a63a");
                    break;
                case "TCI":
                    ui = new Guid("8b4350b2-417a-412a-a6cd-459aa148b32e");
                    break;
                case "HSSI":
                    ui = new Guid("b55fcfdb-d636-4c4d-8d26-53ac9ee55e04");
                    break;
                case "TAU":
                    ui = new Guid("f7f1d334-7af0-4bcd-ab59-72dafd79f7e2");
                    break;
                case "GCI":
                    ui = new Guid("3e4cc7d6-62a5-41a0-8936-d75fa87a59bc");
                    break;
                case "PEI":
                    ui = new Guid("9ea061ac-63a2-4cf7-935d-a60cd0d17b7f");
                    break;
                case "PEI/GM":
                    ui = new Guid("9ea061ac-63a2-4cf7-935d-a60cd0d17b7f");
                    break;
                default:
                    ui = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afb2");
                    break;
            }
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
                FieldId = new Guid(),
                GraduateYear = graduateYear,
                PhoneNumber = phoneNumber,
                Dob = "Today",
                ProStatus = (!(proStatus == null)) ? proStatus : "Employee",
                CompanyId = new Guid(companyName),
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

