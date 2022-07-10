using HackerUServer.BL;
using HackerUServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackerUServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILogger<LanguagesController> _logger;

        public LanguagesController(ILogger<LanguagesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLanguages")]
        public IEnumerable<Language> GetLanguages()
        {
            var bl = new LecturersBL();
            return bl.GetLanguages();
        }
    }
}
