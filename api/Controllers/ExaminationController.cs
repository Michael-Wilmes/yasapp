using Swashbuckle.AspNetCore.Annotations;

namespace yasapp.Api.Controllers
{
    [Produces("application/json")]
    public class ExaminationController : BaseController
    {
        public const string GROUP_INFO = "YASAPP - Examination - Service";

        /// <summary>
        /// ExaminationController constructor
        /// </summary>
        /// <param name="config"></param>
        /// <param name="logger"></param>
        public ExaminationController(IConfiguration config, ILogger logger)
            : base(config, logger)
        {
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
        [HttpGet(Name = "examinations")]
        public async Task<IActionResult> Get()
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
        [HttpGet("{id}", Name = "read")] 
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
        [HttpPost(Name = "update")]
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
        [HttpPut(Name = "create")]
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
        [HttpDelete("{id}", Name = "delete")]
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
