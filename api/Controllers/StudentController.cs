using api;
using Microsoft.AspNetCore.Mvc;
using yasapp.Shared.Models;
using ILogger = Serilog.ILogger;


namespace yasapp.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController :BaseController
    {//todo: add swagger definitions

        public StudentController(IConfiguration config, ILogger logger) :
            base(config, logger)
        {
        }

        [HttpGet(Name = "Students")]
        public IEnumerable<StudentModel> Get()
        {
          throw new NotImplementedException();
        }
    }
}
