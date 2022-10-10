using Adni.Application.Common.Interfaces;
using Adni.Domain.Enums;

namespace Adni.Application.Dtos.File
{
    public class FileUploadDto
    {
        public IFormFile FileDetails { get; set; }
        public FileType FileType { get; set; }
    }
}
