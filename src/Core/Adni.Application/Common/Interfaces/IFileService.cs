using Adni.Application.Dtos.File;
using Adni.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Common.Interfaces
{
    public interface IFileService
    {
        public Task<Guid> PostFileAsync(IFormFile fileData, FileType fileType, CancellationToken cancellationToken);
        public Task PostMultiFileAsync(List<FileUploadDto> fileData, CancellationToken cancellationToken = new CancellationToken());
        public Task DownloadFileById(Guid id);
    }
}
