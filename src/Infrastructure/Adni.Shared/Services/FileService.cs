using Adni.Application.Common.Interfaces;
using Adni.Application.Dtos.File;
using Adni.Domain.Entities;
using Adni.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Shared.Services;

public class FileService : IFileService
{
    private IApplicationDbContext _context;

    public FileService(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> PostFileAsync(IFormFile fileData, FileType fileType, CancellationToken cancellationToken = new CancellationToken())
    {
        try
        {
            var fileDetails = new FileDetails()
            {
                Id = new Guid(),
                FileName = fileData.FileName,
                FileType = fileType,
            };
            using (var stream = new MemoryStream())
            {
                fileData.CopyTo(stream);
                fileDetails.Data = stream.ToArray();
            }
            var result = _context.fileDetails.Add(fileDetails);
            await _context.SaveChangesAsync(cancellationToken);
            
            return fileDetails.Id;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task PostMultiFileAsync(List<FileUploadDto> Data, CancellationToken cancellationToken = new CancellationToken())
    {
        try
        {
            foreach (FileUploadDto file in Data)
            {
                var fileDetails = new FileDetails()
                {
                    Id = new Guid(),
                    FileName = file.FileDetails.FileName,
                    FileType = file.FileType,
                };
                using (var stream = new MemoryStream())
                {
                    file.FileDetails.CopyTo(stream);
                    fileDetails.Data = stream.ToArray();
                }
                var result = _context.fileDetails.Add(fileDetails);
            }
            await _context.SaveChangesAsync(cancellationToken);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task DownloadFileById(Guid Id)
    {
        try
        {
            var file = _context.fileDetails.Where(x => x.Id == Id).FirstOrDefaultAsync();
            var content = new System.IO.MemoryStream(file.Result.Data);
            var path = Path.Combine(
               Directory.GetCurrentDirectory(), "\\Imports",
               file.Result.FileName);
            await CopyStream(content, path);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task CopyStream(Stream stream, string downloadPath)
    {
        using (var fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write))
        {
            await stream.CopyToAsync(fileStream);
        }
    }

}

