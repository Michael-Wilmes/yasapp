using Microsoft.AspNetCore.Mvc;
using yasapp.Shared.Models;
using ILogger = Serilog.ILogger;


namespace yasapp.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModuleController : BaseController
    {
        public ModuleController(IConfiguration config, ILogger logger) 
            :base(config, logger)
        {
        }

        [HttpGet(Name = "Modules")]
        public IEnumerable<ModuleModel> Get()
        {
            throw new NotImplementedException();
        }
    }
}
