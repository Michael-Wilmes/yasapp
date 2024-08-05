using Swashbuckle.AspNetCore.Annotations;
using Yasapp.Application.Interfaces;
using Yasapp.Domain.Entities;
using Yasapp.Domain.Entities.Masterdata;

namespace Yasapp.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class ExaminationController : BaseController
    {
        public const string GROUP_INFO = "YASAPP - Examination - Service";
        IExaminationService<ExaminationModel> _service;

        /// <summary>
        /// ExaminationController constructor
        /// </summary>
        /// <param name="config"></param>
        /// <param name="logger"></param>
        public ExaminationController(IConfiguration config, 
                                    ILogger logger, 
                                    IExaminationService<ExaminationModel> service)
            : base(config, logger)
        {
            _service   = service;
        }

        /// <summary>
        /// HTTP GET method to get all examinations
        /// </summary>
        /// <returns>List of examinations</returns>
        /// <exception cref="NotImplementedException"></exception>
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
                var list = await _service.ReadAllAsync();
                return Json(list);
            }
            catch (YasappException exc)
            {
                LogException(exc);
                return BadRequest(exc);
            }
            catch (Exception exc) { 
                LogException(exc);
                return BadRequest(new YasappExceptionModel(exc,
                         "Error while getting all examinations",
                         "Yasap api : ExaminationController::Get"));
            }
        }


        /// <summary>
        /// HTTP GET method to get a specific examination
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Examination or not found</returns>
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
                         "Error while read examination",
                         "Yasapp api : ExaminationController::Read"));
            }
        }

        /// <summary>
        /// Update an examination
        /// </summary>
        /// <param name="model"></param>
        /// <returns>updated model or bad request</returns>
        
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] ExaminationModel model)
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
                         "Error while updating examination",
                         "Yasapp api : ExaminationController::Update"));
            }
        }

        /// <summary>
        /// Create a new examination
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
        public async Task<IActionResult> Create([FromBody] ExaminationModel model)
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
                         "Error while creating examination",
                         "Yasapp api : ExaminationController::Create"));
            }
        }

        /// <summary>
        /// Delete a examination
        /// </summary>
        /// <param name="model"></param>
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
                         "Error while deleting examination",
                         "Yasapp api : ExaminationController::Delete"));
            }
        }
    }
}
