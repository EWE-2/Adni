using Adni.Application.Dtos.File;
using Adni.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.Common.Interfaces
{
    public interface IFileService
    {
        public Task PostFileAsync(IFormFile fileData, FileType fileType);
        public Task PostMultiFileAsync(List<FileUploadDto> fileData);
        public Task DownloadFileById(Guid id);
    }
}
