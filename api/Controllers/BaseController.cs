
namespace yasapp.Api.Controllers
{
    //TODO: add logging

    [ApiController]
    public abstract class BaseController : Controller
    {
        protected readonly ILogger _logger;
        protected readonly IConfiguration _config;

        public BaseController(IConfiguration config, ILogger logger)
        {
            _config = config;
            _logger = logger;
        }

        [NonAction]
        protected void LogException(Exception exc)
        {
            _logger.Error("----------- Exception Start -----------");
            _logger.Error(exc.Message);
            if (exc.InnerException != null)
            {
                _logger.Error(exc.InnerException.Message);
            }
            _logger.Error("----------- Exception END -----------");
        }

        [NonAction]
        protected void LogException(YasappException exc)
        {
            _logger.Error("----------- Exception Start -----------");
            _logger.Error($"{exc.PlaceOfOccurence} : {exc.Title} - {exc.Description}");
            exc.Messages?.ForEach(x => _logger.Error(x));
            if (exc.InnerException != null)
            {
                _logger.Error(exc.InnerException.Message);
            }
            _logger.Error("----------- Exception END -----------");
        }

        [NonAction]
        protected void CheckCollectModelState(string placeOfCheck)
        {
            if (!ModelState.IsValid)
            {
                YasappException portalException = new YasappException("Validation Fehler")
                {
                    Description = "Mindestens ein Feld ist nicht (oder falsch) gefüllt",
                    PlaceOfOccurence = placeOfCheck,
                    Messages = ModelState.Values.Aggregate(new List<string>(), (a, c) =>
                    {
                        a.AddRange(c.Errors.Select(r => r.ErrorMessage));
                        return a;
                    }, a => a)
                };

                throw portalException;
            }
        }

        //[NonAction]
        //protected bool CanReadAll()
        //{
        //    string userRole = User.FindFirstValue("https://kieskumpel.com/claim/role");//
        //    return userRole != null && userRole.ToLower() == "sysadmin";
        //}
    }
}
