using Adni.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Adni.Application.Dtos.File
{
    public class FileUploadDto
    {
        public IFormFile FileDetails { get; set; }
        public FileType FileType { get; set; }
    }

}
