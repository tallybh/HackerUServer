using HackerUServer.BL;
using HackerUServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace HackerUServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LecturersController : ControllerBase
    {

        private readonly ILogger<LecturersController> _logger;

        public LecturersController(ILogger<LecturersController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public  IEnumerable<Lecturer> Get()
        {
            var bl = new LecturersBL();
            return bl.GetLecturers();
        }

       
    }
}