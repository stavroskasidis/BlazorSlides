using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace BlazorSlides.Server.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class SlidesController : ControllerBase
    {
        private readonly IHostEnvironment hostEnvironment;

        public SlidesController(IHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var fileName = $"{id}.md";
            var filePath = Path.Combine(hostEnvironment.ContentRootPath, "Slides", fileName);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            return File(System.IO.File.OpenRead(filePath), "application/text");
        }
        [HttpGet("Count")]
        public int Count()
        {
            var slidesFolder = Path.Combine(hostEnvironment.ContentRootPath, "Slides");
            return Directory.GetFiles(slidesFolder).Length;
        }
    }
}
