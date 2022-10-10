using Adni.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Adni.Data.Contexts;
using System.Threading;
using Adni.Application.Dtos.File;

namespace Adni.WebApi.Controllers.v2
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ApiControllerv2
    {
        private readonly IFileService _fileService;
        private readonly ApplicationDbContext _context;

        public FileController(IFileService fileServices, ApplicationDbContext context)
        {
            _fileService = fileServices;
            _context = context;
        }

        /// <summary>
        /// Single File Upload
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost("PostSingleFile")]
        public async Task<ActionResult<Guid>> PostSingleFile([FromForm] FileUploadDto fileDetails)
        {
            CancellationToken cancellationToken = new CancellationToken();

            if (fileDetails == null)
            {
                return BadRequest();
            }
            try
            {
                return await _fileService.PostFileAsync(fileDetails.FileDetails, fileDetails.FileType, cancellationToken);
                //return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Multiple File Upload
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost("PostMultipleFile")]
        public async Task<ActionResult> PostMultipleFile([FromForm] List<FileUploadDto> fileDetails)
        {
            if (fileDetails == null)
            {
                return BadRequest();
            }
            try
            {
                await _fileService.PostMultiFileAsync(fileDetails);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Download File
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpGet("DownloadFile")]
        public async Task<ActionResult> DownloadFile(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }
            try
            {
                await _fileService.DownloadFileById(id);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
