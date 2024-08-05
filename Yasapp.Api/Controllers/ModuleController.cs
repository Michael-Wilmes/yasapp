
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Yasapp.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class ModuleController : BaseController
    {
        public const string GROUP_INFO = "YASAPP - Module - Service";


        /// <summary>
        /// Module controller constructor
        /// </summary>
        /// <param name="config"></param>
        /// <param name="logger"></param>
        public ModuleController(IConfiguration config, ILogger logger) 
            :base(config, logger)
        {
        }



        /// <summary>
        /// HTTP GET method to get all modules
        /// </summary>
        /// <returns>List of examinations</returns>
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
                         "Error while getting all modules",
                         "Yasap api : ModuleController::Get"));
            }
        }

        /// <summary>
        /// HTTP GET method to get a specific module
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Module or not found</returns>
        /// <exception cref="NotImplementedException"></exception>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet("read/{id}")]
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
                         "Error while read module",
                         "Yasapp api : ModuleController::Read"));
            }
        }


        /// <summary>
        /// HTTP GET method to get a specific module, for a specific study program
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Module or not found</returns>
        /// <exception cref="NotImplementedException"></exception>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet("read/{studyProgramId}/{moduleId}")]
        public async Task<IActionResult> ReadByStudyProgram(int studyProgramId, int moduleId)
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
                         "Error while read module",
                         "Yasapp api : ModuleController::Read"));
            }
        }

        /// <summary>
        /// Update a module
        /// </summary>
        /// <param name="model"></param>
        /// <returns>updated model or bad request</returns>

        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] ModuleModel model)
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
                         "Error while updating module",
                         "Yasapp api : ModuleController::Update"));
            }
        }

        /// <summary>
        /// Create a new module
        /// </summary>
        /// <param name="model"></param>
        /// <returns>created model or bad request</returns>
        /// <exception cref="NotImplementedException"></exception>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPut("create")]
        public async Task<IActionResult> Create([FromBody] ModuleModel model)
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
                         "Error while creating module",
                         "Yasapp api : ModuleController::Create"));
            }
        }

        /// <summary>
        /// Delete a module
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ok or bad request</returns>
        /// <exception cref="NotImplementedException"></exception>
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
                         "Error while deleting module",
                         "Yasapp api : ModuleController::Delete"));
            }
        }
    }
}
