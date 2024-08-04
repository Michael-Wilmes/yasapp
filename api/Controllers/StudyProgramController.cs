
using Swashbuckle.AspNetCore.Annotations;

namespace yasapp.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class StudyProgramController : BaseController
    {
        public const string GROUP_INFO = "YASAPP - Study program - Service";


        /// <summary>
        /// StudyProgramController constructor
        /// </summary>
        /// <param name="config"></param>
        /// <param name="logger"></param>
        public StudyProgramController(IConfiguration config, ILogger logger)
            : base(config, logger)
        {
        }

        /// <summary>
        /// HTTP GET method to get all stud programs
        /// </summary>
        /// <returns>List of students</returns>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Json("");
            }
            catch (YasappException exc)
            {
                LogException(exc);
                return BadRequest(exc);
            }
            catch (Exception exc)
            {
                LogException(exc);
                return BadRequest(new YasappExceptionModel(exc,
                         "Error while getting all study programs",
                         "Yasap api : StudyProgramController::Get"));
            }
        }


        /// <summary>
        /// HTTP GET method to get a specific study program
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Module or not found</returns>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet("read/{id}", Name = "read")]
        public async Task<IActionResult> Read(int id)
        {
            try
            {
                throw new NotImplementedException();

                //return ok or not found
            }
            catch (YasappException exc)
            {
                LogException(exc);
                return BadRequest(exc);
            }
            catch (Exception exc)
            {
                LogException(exc);
                return BadRequest(new YasappExceptionModel(exc,
                         "Error while read study program",
                         "Yasapp api : StudyProgramController::Read"));
            }
        }

        /// <summary>
        /// Update a study program
        /// </summary>
        /// <param name="model"></param>
        /// <returns>updated model or bad request</returns>

        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] StudyProgramModel model)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (YasappException exc)
            {
                LogException(exc);
                return BadRequest(exc);
            }
            catch (Exception exc)
            {
                LogException(exc);
                return BadRequest(new YasappExceptionModel(exc,
                         "Error while updating study program",
                         "Yasapp api : StudyProgramController::Update"));
            }
        }

        /// <summary>
        /// Create a new study program
        /// </summary>
        /// <param name="model"></param>
        /// <returns>created model or bad request</returns>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPut("create")]
        public async Task<IActionResult> Create([FromBody] StudyProgramModel model)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (YasappException exc)
            {
                LogException(exc);
                return BadRequest(exc);
            }
            catch (Exception exc)
            {
                LogException(exc);
                return BadRequest(new YasappExceptionModel(exc,
                         "Error while creating study program",
                         "Yasapp api : StudyProgramController::Create"));
            }
        }

        /// <summary>
        /// Delete a study program
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ok or bad request</returns>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (YasappException exc)
            {
                LogException(exc);
                return BadRequest(exc);
            }
            catch (Exception exc)
            {
                LogException(exc);
                return BadRequest(new YasappExceptionModel(exc,
                         "Error while deleting study program",
                         "Yasapp api : StudyProgramController::Delete"));
            }
        }
    }
}
