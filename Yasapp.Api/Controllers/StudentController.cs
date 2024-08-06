

using Swashbuckle.AspNetCore.Annotations;
using Yasapp.Application.Interfaces;

namespace Yasapp.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class StudentController :BaseController
    {//todo: add swagger definitions

        public const string GROUP_INFO = "YASAPP - Student - Service";
        IStudentService<StudentModel> _service;

        /// <summary>
        /// Student controller constructor
        /// </summary>
        /// <param name="service"></param>
        /// <param name="config"></param>
        /// <param name="logger"></param>
        public StudentController(IStudentService<StudentModel> service, IConfiguration config, ILogger logger) :
            base(config, logger)
        {
            _service = service;
        }

        /// <summary>
        /// HTTP GET method to get all students
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
                return Json(await _service.ReadAllAsync());
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
                         "Error while getting all students",
                         "Yasap api : StudentController::Get"));
            }
        }

        /// <summary>
        /// HTTP GET method to get all students
        /// </summary>
        /// <returns>List of students</returns>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet("all_by_study_program/{studyProgramId}")]
        public async Task<IActionResult> GetByStudyProgram(int studyProgramId)
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
                         "Error while getting all students by study program",
                         "Yasap api : StudentController::GetByStudyProgram"));
            }
        }

        /// <summary>
        /// HTTP GET method to get a specific student
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Module or not found</returns>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpGet("read/{studentId}")]
        public async Task<IActionResult> Read(int studentId)
        {
            try
            {
                var student = await _service.ReadAsync(studentId);
                if (student == null)
                {
                    return NotFound($"Student with id {studentId} does not exists");
                }
                
                return Ok(student);
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
                         "Error while read student",
                         "Yasapp api : StudentController::Read"));
            }
        }

        /// <summary>
        /// Update a student
        /// </summary>
        /// <param name="model"></param>
        /// <returns>updated model or bad request</returns>

        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] StudentModel model)
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
                         "Error while updating student",
                         "Yasapp api : StudentController::Update"));
            }
        }

        /// <summary>
        /// Create a new student
        /// </summary>
        /// <param name="model"></param>
        /// <returns>created model or bad request</returns>
        [SwaggerOperation(Tags = new[] { GROUP_INFO })]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //todo: add authorized
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [HttpPut("create")]
        public async Task<IActionResult> Create([FromBody] StudentModel model)
        {
            try
            {
                //todo: validation
               var newObj = _service.CreateAsync(model);
               return CreatedAtAction("Create", newObj);
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
                         "Error while creating student",
                         "Yasapp api : StudentController::Create"));
            }
        }

        /// <summary>
        /// Delete a student
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
                         "Error while deleting student",
                         "Yasapp api : StudentController::Delete"));
            }
        }
    }
}
