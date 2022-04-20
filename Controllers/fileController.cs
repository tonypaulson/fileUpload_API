using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using file_upload.Models;
using file_upload.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace file_upload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class fileController : ControllerBase
    {
        private readonly fileService _fileService;
        private readonly ILogger<fileController> _logger;

        public fileController(fileService fileService,ILogger<fileController> logger)
        {
            _fileService = fileService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult>AddFile([FromBody] fileModel fileModel)
        {
            try
            {
                var id = await _fileService.AddFile(fileModel);
                return StatusCode(201, new { Id = id });
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
